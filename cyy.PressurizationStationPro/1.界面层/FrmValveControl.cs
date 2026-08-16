using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyy.PressurizationStationPro
{
    public partial class FrmValveControl : Form
    {
        public FrmValveControl(string valveName,bool state,PlcDataService dataService)
        {
            InitializeComponent();
            this.TopMost = true;

            this.valveName = valveName;
            this.state = state;
            this.dataService = dataService;


            this.lbl_Message.Text = "是否确定要" + (this.state ? "关闭" : "打开") + valveName + "?";
            

        }

        private string valveName = string.Empty;
        private bool state = false;
        private PlcDataService dataService;





        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (dataService.IsConnected)
            {


                bool result = true;
                switch (valveName)
                {
                    case "进水阀":
                        result = dataService.VavelInControl(!this.state);
                        
                        break;
                    case "出水阀":
                        result = dataService.VavelOutControl(!this.state);
                        
                        break;
                    default:
                        new FrmMsgNoAck("未知的阀门名称，请检查！", "阀门控制").ShowDialog();
                        return;
                }
                
               // if (result)
              //  {
                     this.DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    new FrmMsgNoAck("阀门控制失败，请检查！", "阀门控制").ShowDialog();
                //}

            }
            else
            {
                new FrmMsgNoAck("请检查PLC连接是否正常！", "阀门控制").ShowDialog();
            }
        }
        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
}


