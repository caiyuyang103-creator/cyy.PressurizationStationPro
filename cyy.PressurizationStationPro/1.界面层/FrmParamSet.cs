using AForge.Video.DirectShow;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.s7netplus;

namespace cyy.PressurizationStationPro
{
    public partial class FrmParamSet : Form
    {
       
        public FrmParamSet(SysInfo sysInfo, SysInfoService infoService, string sysInfoPath)
        {
            InitializeComponent();

            this.sysInfo = sysInfo;
            this.infoService = infoService;
            this.sysInfoPath = sysInfoPath;

            //初始化
            this.cmb_CpuType.DataSource = Enum.GetNames(typeof(CpuType));

            FilterInfoCollection infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo item in infoCollection)
            {

                this.cmb_Camera.Items.Add(item.Name);

            }

            //更新
            if (this.sysInfo!=null)
            {
                this.txt_IPAddress.Text = this.sysInfo.IPAddress;
                this.cmb_CpuType.Text = this.sysInfo.CpuType.ToString();
                this.txt_Rack.Text = this.sysInfo.Rack.ToString();
                this.txt_Slot.Text = this.sysInfo.Slot.ToString();

                this.toggle_AutoStart.Checked = this.sysInfo.AutoStart;
                this.txt_ScreenTime.Text = this.sysInfo.ScreeenTime.ToString();
                this.txt_LogoffTime.Text = this.sysInfo.LogoffTime.ToString();

                if (infoCollection.Count>this.sysInfo.CameraIndex)
                {
                    this.cmb_Camera.SelectedIndex = this.sysInfo.CameraIndex;
                }
                
            }
            this.toggle_AutoStart.CheckedChanged += this.toggle_AutoStart_CheckedChanged_1;

        }

       

        public SysInfo sysInfo;
        public SysInfoService infoService;
        public string sysInfoPath;




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

        private void btn_PLCSet_Click(object sender, EventArgs e)
        {
            if (this.sysInfo==null)
            {
                this.sysInfo = new SysInfo();
            }

            this.sysInfo.IPAddress = this.txt_IPAddress.Text.Trim();
            this.sysInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), this.cmb_CpuType.Text.Trim(), true);
            this.sysInfo.Rack = Convert.ToInt16(this.txt_Rack.Text.Trim());
            this.sysInfo.Slot = Convert.ToInt16(this.txt_Slot.Text.Trim());

       


            bool result = infoService.SetSysInfoToPath(this.sysInfo, this.sysInfoPath);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FrmMsgNoAck("通信参数写入失败", "通信参数").ShowDialog();
            }
        }

        private void btn_PLCCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_SysSet_Click(object sender, EventArgs e)
        {
            if (this.sysInfo == null)
            {
                this.sysInfo = new SysInfo();
            }

            this.sysInfo.ScreeenTime = Convert.ToInt32(this.txt_ScreenTime.Text.Trim());
            this.sysInfo.LogoffTime= Convert.ToInt32(this.txt_LogoffTime.Text.Trim());
            this.sysInfo.CameraIndex = this.cmb_Camera.SelectedIndex;

            this.sysInfo.AutoStart = this.toggle_AutoStart.Checked;

            bool result = infoService.SetSysInfoToPath(this.sysInfo, this.sysInfoPath);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FrmMsgNoAck("系统参数写入失败", "系统参数").ShowDialog();
            }
        }
        
        private void btn_SysCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        
           
        

        #region 开机启动
        /// <summary>  
        /// 修改程序在注册表中的键值  
        /// </summary>  
        /// <param name="isAuto">true:开机启动,false:不开机自启</param> 
        private void AutoStart(bool isAuto = true)
        {
            if (isAuto == true)
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.SetValue("PressurizationStationPro", System.Windows.Forms.Application.ExecutablePath);
                R_run.Close();
                R_local.Close();
            }
            else
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.DeleteValue("PressurizationStationPro", false);
                R_run.Close();
                R_local.Close();
            }
        }

        #endregion

        private void toggle_AutoStart_CheckedChanged_1(object sender, EventArgs e)
        {
            AutoStart(this.toggle_AutoStart.Checked);
        }
    }
}
