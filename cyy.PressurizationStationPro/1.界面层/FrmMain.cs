using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using xbd.ControlLib;
using xbd.s7netplus;

namespace cyy.PressurizationStationPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += UpdateTimer_Tick;
            this.updateTimer.Start();



            this.Load += FrmMain_Load;
            this.FormClosing += FrmMain_FormClosing;
        }

        #region 字段和属性
        /// <summary>
        /// 系统配置文件的路径
        /// </summary>
        private string sysInfoPath = Application.StartupPath + "\\SysInfo.ini";

        /// <summary>
        /// 系统配置文件服务对象
        /// </summary>
        private SysInfoService infoService = new SysInfoService();


        /// <summary>
        /// 系统配置对象
        /// </summary>
        private SysInfo sysInfo = new SysInfo();


        /// <summary>
        ///多线程取消源
        /// </summary>
        private CancellationTokenSource cts;



        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();

        private PlcDataService dataService = new PlcDataService();


        /// <summary>
        /// 第一次扫描标志位
        /// </summary>
        private bool FirstScan = true;



        private MessageFilter messageFilter;

        //登录时间
        private DateTime LoginTime = DateTime.Now;

        //摄像头采集对象
        private CameraHelper camera = null;

        private HistoryDataService historyService = new HistoryDataService();

        /// <summary>
        /// 把上次存储的时间记录下来
        /// </summary>
        private DateTime LastTime= DateTime.Now;
        
        #endregion

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            this.lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " +
                new CultureInfo("zh-CN").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);


            this.led_PLCState.State = dataService.IsConnected;


            //如果大于0才启用该功能，鼠标键盘无操作
            if (sysInfo.ScreeenTime>0)
            {
                Program.TickCount++;
                if (sysInfo.ScreeenTime*1000/this.updateTimer.Interval==Program.TickCount)
                {
                    //锁屏，调用windows底层API
                    LockWorkStation();
                }
            }

            //启动用户自动注销功能
            if (sysInfo.LogoffTime>0)
            {
                if (Program.CurrentUser!=null)
                {
                    TimeSpan timeSpan = DateTime.Now - this.LoginTime;
                    if (timeSpan.TotalSeconds>sysInfo.LogoffTime)
                    {
                        Program.CurrentUser = null;
                        this.btn_UserLogin.Text = "用户登录";
                        this.lbl_User.Text = "未登录"; 

                    }
                }
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new FrmMsgWithAck("是否确定退出系统","退出系统").ShowDialog()==DialogResult.OK)
            {
                camera?.StopCamera();
                updateTimer.Stop();
                cts?.Cancel();
               
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.sysInfo = infoService.GetSysInfoFromPath(sysInfoPath);
            if (sysInfo==null)
            {
                new FrmMsgNoAck("系统配置失败！", "系统配置").ShowDialog();
                return;
            }

            // 锁屏处理
            if (sysInfo.ScreeenTime>0)
            {
                messageFilter = new MessageFilter();
                Application.AddMessageFilter(messageFilter);
            }

           
            cts = new CancellationTokenSource();
            Task.Run(new Action(() =>
            {
                PLCCommunication();
            }));

            //采集摄像头

            this.camera = new CameraHelper(sysInfo.CameraIndex,this.vsp_Panel);
            this.camera.StartCamera();



        }
        /// <summary>
        /// 多线程方法体，与PLC实时通信
        /// </summary>
        private void PLCCommunication()
        {
            while (!cts.IsCancellationRequested)
            {

                //已经连接成功
                if (dataService.IsConnected)
                {
                    var data = dataService.ReadPLCData();

                    if (data.IsSuccess)
                    {
                        //清零出错次数
                        dataService.ErrorTimes = 0;

                        //更新
                        this.UpdateUIData(data.Content);

                        //存储
                        int timeSpan = DateTime.Now.Second - LastTime.Second;
                        if (timeSpan==1||timeSpan==-59)
                        {
                            historyService.AddHistoryData(new HistoryData()
                            {
                                InsertTime = DateTime.Now,
                                PressureIn = data.Content.PressureIn.ToString("f2"),
                                PressureOut = data.Content.PressureOut.ToString("f2"),
                                TempIn1 = data.Content.TempIn1.ToString("f2"),
                                TempIn2 = data.Content.TempIn2.ToString("f2"),
                                TempOut= data.Content.TempOut.ToString("f2"),
                                PressureTank1 = data.Content.PressureTank1.ToString("f2"),
                                PressureTank2 = data.Content.PressureTank2.ToString("f2"),
                                LevelTank1 = data.Content.LevelTank1.ToString("f2"),
                               LevelTank2 = data.Content.LevelTank2.ToString("f2"),
                                PressureTankOut = data.Content.PressureTankOut.ToString("f2"),
                            }
                                );
                        }
                        LastTime = DateTime.Now;
                    }
                    else
                    {
                        //容错次数
                        dataService.ErrorTimes++;

                        if (dataService.ErrorTimes>=dataService.AllowErrorTimes)
                        {
                            dataService.IsConnected = false;
                        }
                    }
                    Thread.Sleep(300);

                }
                //连接
                else
                {
                    //如果是第一次扫描，直接连接
                    //如果不是第一次扫描，先断开再连接
                    if (!dataService.IsFirstScan)
                    {
                        Thread.Sleep(3000);

                        //断开连接
                        dataService.DisConnect();
                    }
                    else
                    {
                        dataService.IsFirstScan = false;
                    }

                    //连接
               var result=     dataService.Connect(this.sysInfo);
                    dataService.IsConnected = result.IsSuccess;

                }
            }
        }

       


        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            new FrmParamSet(this.sysInfo, this.infoService, this.sysInfoPath).ShowDialog();
        }


       
        /// <summary>
        /// 更新UI界面
        /// </summary>
        /// <param name="plcData"></param>
        private void UpdateUIData(PlcData plcData)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    //委托处理
                    this.Invoke(new Action<PlcData>(UpdateUIData), plcData);
                }
                catch (Exception)
                {

                    return;
                }
               
            }
            else
            {
                if (FirstScan)
                {
                    //第一次扫描执行，后续不执行
                    this.toggle_Pump1.Checked = plcData.InPump1State;
                    this.toggle_Pump2.Checked = plcData.InPump2State;
                    FirstScan = false;
                
                }

                this.lbl_pressureIn.Text = plcData.PressureIn.ToString("f2") + " bar";
                this.lbl_pressureOut.Text = plcData.PressureOut.ToString("f2") + " bar";
                this.meter_pressureIn.Value = plcData.PressureIn;
                this.meter_pressureOut.Value = plcData.PressureOut;

                this.ms_TempIn1.ParamValue = plcData.TempIn1;
                this.ms_TempIn2.ParamValue = plcData.TempIn2;
                this.ms_TempOut.ParamValue = plcData.TempOut;
                this.ms_PressureTank1.ParamValue = plcData.PressureTank1;
                this.ms_PressureTank2.ParamValue = plcData.PressureTank2;
                this.ms_PressureTankOut.ParamValue = plcData.PressureTankOut;

                this.led_RunState.State = plcData.SysRunState;
                this.led_SysAlarmState.State = !plcData.SysAlarmState;


                this.lbl_PressureTank1.Text = plcData.PressureTank1.ToString("f2");
                this.lbl_LevelTank1.Text = plcData.LevelTank1.ToString("f2");
                this.lbl_PressureTank2.Text = plcData.PressureTank2.ToString("f2");
                this.lbl_LevelTank2.Text = plcData.LevelTank2.ToString("f2");
                this.lbl_PressureTankOut.Text = plcData.PressureTankOut.ToString("f2");


                this.lbl_TempIn1.Text = plcData.TempIn1.ToString("f2");
                this.lbl_TempIn2.Text = plcData.TempIn2.ToString("f2");
                this.lbl_TempOut.Text = plcData.TempOut.ToString("f2");
                this.lbl_PreTankOut.Text = plcData.PressureTankOut.ToString("f2");


                this.Pump_In1.IsRun = plcData.InPump1State;
                this.Pump_In2.IsRun = plcData.InPump2State;

                this.Valve_In.State = plcData.ValveInState;
                this.Valve_Out.State = plcData.ValveOutState;

                this.motor_Pump1.PumpState = plcData.CirclePump1State ? PumpState.运行 : PumpState.停止;
                this.motor_Pump2.PumpState = plcData.CirclePump2State ? PumpState.运行 : PumpState.停止;

                //量程  2m
                this.Wave_Tank1.Value = Convert.ToInt32((plcData.LevelTank1 / 2.0f) * 100.0f);
                this.Wave_Tank2.Value = Convert.ToInt32((plcData.LevelTank2 / 2.0f) * 100.0f);


                this.btn_Pump1.Text = plcData.CirclePump1State ? "停止" : "启动";
                this.btn_Pump2.Text = plcData.CirclePump2State ? "停止" : "启动";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pump1_Click(object sender, EventArgs e)
        {
            dataService.CirclePump1Control(this.btn_Pump1.Text == "启动");
        }

        private void btn_Pump2_Click(object sender, EventArgs e)
        {
            dataService.CirclePump2Control(this.btn_Pump2.Text == "启动");
        }

        private void toggle_Pump1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataService.InPump1Control(this.toggle_Pump1.Checked))
            {
                this.toggle_Pump1.CheckedChanged -= toggle_Pump1_CheckedChanged;
                this.toggle_Pump1.Checked = !this.toggle_Pump1.Checked;
                this.toggle_Pump1.CheckedChanged += toggle_Pump1_CheckedChanged;
            }


        }

        private void toggle_Pump2_CheckedChanged(object sender, EventArgs e)
        {

            if (dataService.InPump2Control(this.toggle_Pump2.Checked))
            {
                this.toggle_Pump2.CheckedChanged -= toggle_Pump2_CheckedChanged;
                this.toggle_Pump2.Checked = !this.toggle_Pump2.Checked;
                this.toggle_Pump2.CheckedChanged += toggle_Pump2_CheckedChanged;
            }
        }

        private void btn_SysReset_Click(object sender, EventArgs e)
        {
            dataService.SysReset();
        }


        private void CommonValve_DoubleClick(object sender, EventArgs e)
        {
                if (sender is xbdValve valve)
            {
                FrmValveControl frmValveControl = new FrmValveControl(valve.ValveName, valve.State, this.dataService);
                frmValveControl.ShowDialog();
            }
        }


        #region 系统锁屏

        [DllImport("user32")]
        public static extern bool LockWorkStation();









        #endregion

        private void btn_UserLogin_Click(object sender, EventArgs e)
        {

            if (this.btn_UserLogin.Text=="用户登录")
            {
                DialogResult dialogResult = new FrmLogin().ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    this.lbl_User.Text = Program.CurrentUser.LoginName;

                    //记录登录时间
                    LoginTime=DateTime.Now;
                    this.btn_UserLogin.Text = "用户管理";
                }
        }

            else
            {
                if (Program.CurrentUser!=null&&Program.CurrentUser.RoleName==RoleName.管理员)
                {
                    FrmUserManage frmUserManage = new FrmUserManage();
                    frmUserManage.ShowDialog();
                }

                else
                {
                    new FrmMsgNoAck("用户权限不足！", "权限管理").ShowDialog();
                }
            }


        }

        private void btn_History_Click(object sender, EventArgs e)
          {
            if (Program.CurrentUser != null && Program.CurrentUser.RoleName != RoleName.操作员)
            {
                new FrmHistory().ShowDialog();
            }

            else
            {
                new FrmMsgNoAck("用户权限不足！", "权限管理").ShowDialog();
            }
            
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser != null && Program.CurrentUser.RoleName !=RoleName.操作员)
            {
                new FrmReport().ShowDialog();
            }

            else
            {
                new FrmMsgNoAck("用户权限不足！", "权限管理").ShowDialog();
            }
            
        }

        private void lbl_User_Click(object sender, EventArgs e)
        {
            if (new FrmMsgWithAck("是否确认要注销登录？","注销用户").ShowDialog()==DialogResult.OK)
            {
                Program.CurrentUser = null;
                this.btn_UserLogin.Text = "用户登录";
                this.lbl_User.Text = "未登录";
            }
        }

        #region 无边框拖动 

        private Point mPoint;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion
    }


    #region 消息筛选器 
    public class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //如果检测到有鼠标或则键盘的消息，则使计数为0.....
            if (m.Msg == 0x0200 || m.Msg == 0x0201 || m.Msg == 0x0204 || m.Msg == 0x0207)
            {
                Program.TickCount = 0;
            }
            return false;
        }
    }
    #endregion


}
