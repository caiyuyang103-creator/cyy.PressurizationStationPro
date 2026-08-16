namespace cyy.PressurizationStationPro
{
    partial class FrmParamSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.cmb_Camera = new System.Windows.Forms.ComboBox();
            this.cmb_CpuType = new System.Windows.Forms.ComboBox();
            this.toggle_AutoStart = new xbd.ControlLib.xbdToggle();
            this.txt_Slot = new System.Windows.Forms.TextBox();
            this.txt_LogoffTime = new System.Windows.Forms.TextBox();
            this.txt_Rack = new System.Windows.Forms.TextBox();
            this.txt_ScreenTime = new System.Windows.Forms.TextBox();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.btn_SysCancel = new System.Windows.Forms.Button();
            this.btn_PLCCancel = new System.Windows.Forms.Button();
            this.btn_SysSet = new System.Windows.Forms.Button();
            this.btn_PLCSet = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.MainPanel.Controls.Add(this.cmb_Camera);
            this.MainPanel.Controls.Add(this.cmb_CpuType);
            this.MainPanel.Controls.Add(this.toggle_AutoStart);
            this.MainPanel.Controls.Add(this.txt_Slot);
            this.MainPanel.Controls.Add(this.txt_LogoffTime);
            this.MainPanel.Controls.Add(this.txt_Rack);
            this.MainPanel.Controls.Add(this.txt_ScreenTime);
            this.MainPanel.Controls.Add(this.txt_IPAddress);
            this.MainPanel.Controls.Add(this.btn_SysCancel);
            this.MainPanel.Controls.Add(this.btn_PLCCancel);
            this.MainPanel.Controls.Add(this.btn_SysSet);
            this.MainPanel.Controls.Add(this.btn_PLCSet);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.label14);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label16);
            this.MainPanel.Controls.Add(this.label13);
            this.MainPanel.Controls.Add(this.label15);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(612, 392);
            this.MainPanel.TabIndex = 0;
            // 
            // cmb_Camera
            // 
            this.cmb_Camera.FormattingEnabled = true;
            this.cmb_Camera.Location = new System.Drawing.Point(443, 253);
            this.cmb_Camera.Name = "cmb_Camera";
            this.cmb_Camera.Size = new System.Drawing.Size(135, 36);
            this.cmb_Camera.TabIndex = 8;
            // 
            // cmb_CpuType
            // 
            this.cmb_CpuType.FormattingEnabled = true;
            this.cmb_CpuType.Location = new System.Drawing.Point(116, 147);
            this.cmb_CpuType.Name = "cmb_CpuType";
            this.cmb_CpuType.Size = new System.Drawing.Size(155, 36);
            this.cmb_CpuType.TabIndex = 8;
            // 
            // toggle_AutoStart
            // 
            this.toggle_AutoStart.Checked = false;
            this.toggle_AutoStart.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_AutoStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_AutoStart.Location = new System.Drawing.Point(460, 94);
            this.toggle_AutoStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_AutoStart.Name = "toggle_AutoStart";
            this.toggle_AutoStart.Size = new System.Drawing.Size(86, 35);
            this.toggle_AutoStart.SwitchType = xbd.ControlLib.SwitchType.Quadrilateral;
            this.toggle_AutoStart.TabIndex = 7;
            this.toggle_AutoStart.Texts = null;
            this.toggle_AutoStart.TrueColor = System.Drawing.Color.LimeGreen;
            // 
            // txt_Slot
            // 
            this.txt_Slot.Location = new System.Drawing.Point(116, 253);
            this.txt_Slot.Name = "txt_Slot";
            this.txt_Slot.Size = new System.Drawing.Size(155, 35);
            this.txt_Slot.TabIndex = 6;
            // 
            // txt_LogoffTime
            // 
            this.txt_LogoffTime.Location = new System.Drawing.Point(443, 200);
            this.txt_LogoffTime.Name = "txt_LogoffTime";
            this.txt_LogoffTime.Size = new System.Drawing.Size(115, 35);
            this.txt_LogoffTime.TabIndex = 6;
            // 
            // txt_Rack
            // 
            this.txt_Rack.Location = new System.Drawing.Point(116, 200);
            this.txt_Rack.Name = "txt_Rack";
            this.txt_Rack.Size = new System.Drawing.Size(155, 35);
            this.txt_Rack.TabIndex = 6;
            // 
            // txt_ScreenTime
            // 
            this.txt_ScreenTime.Location = new System.Drawing.Point(443, 147);
            this.txt_ScreenTime.Name = "txt_ScreenTime";
            this.txt_ScreenTime.Size = new System.Drawing.Size(115, 35);
            this.txt_ScreenTime.TabIndex = 6;
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(116, 94);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(155, 35);
            this.txt_IPAddress.TabIndex = 6;
            // 
            // btn_SysCancel
            // 
            this.btn_SysCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SysCancel.FlatAppearance.BorderSize = 0;
            this.btn_SysCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SysCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SysCancel.Image = global::cyy.PressurizationStationPro.Properties.Resources.Yellow;
            this.btn_SysCancel.Location = new System.Drawing.Point(474, 321);
            this.btn_SysCancel.Name = "btn_SysCancel";
            this.btn_SysCancel.Size = new System.Drawing.Size(104, 39);
            this.btn_SysCancel.TabIndex = 5;
            this.btn_SysCancel.Text = "取消设置";
            this.btn_SysCancel.UseVisualStyleBackColor = true;
            this.btn_SysCancel.Click += new System.EventHandler(this.btn_SysCancel_Click);
            // 
            // btn_PLCCancel
            // 
            this.btn_PLCCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_PLCCancel.FlatAppearance.BorderSize = 0;
            this.btn_PLCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PLCCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PLCCancel.Image = global::cyy.PressurizationStationPro.Properties.Resources.Yellow;
            this.btn_PLCCancel.Location = new System.Drawing.Point(167, 321);
            this.btn_PLCCancel.Name = "btn_PLCCancel";
            this.btn_PLCCancel.Size = new System.Drawing.Size(104, 39);
            this.btn_PLCCancel.TabIndex = 5;
            this.btn_PLCCancel.Text = "取消设置";
            this.btn_PLCCancel.UseVisualStyleBackColor = true;
            this.btn_PLCCancel.Click += new System.EventHandler(this.btn_PLCCancel_Click);
            // 
            // btn_SysSet
            // 
            this.btn_SysSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SysSet.FlatAppearance.BorderSize = 0;
            this.btn_SysSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SysSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SysSet.Image = global::cyy.PressurizationStationPro.Properties.Resources.Pink;
            this.btn_SysSet.Location = new System.Drawing.Point(345, 321);
            this.btn_SysSet.Name = "btn_SysSet";
            this.btn_SysSet.Size = new System.Drawing.Size(104, 39);
            this.btn_SysSet.TabIndex = 5;
            this.btn_SysSet.Text = "设置完成";
            this.btn_SysSet.UseVisualStyleBackColor = true;
            this.btn_SysSet.Click += new System.EventHandler(this.btn_SysSet_Click);
            // 
            // btn_PLCSet
            // 
            this.btn_PLCSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_PLCSet.FlatAppearance.BorderSize = 0;
            this.btn_PLCSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PLCSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PLCSet.Image = global::cyy.PressurizationStationPro.Properties.Resources.Pink;
            this.btn_PLCSet.Location = new System.Drawing.Point(38, 321);
            this.btn_PLCSet.Name = "btn_PLCSet";
            this.btn_PLCSet.Size = new System.Drawing.Size(104, 39);
            this.btn_PLCSet.TabIndex = 5;
            this.btn_PLCSet.Text = "设置完成";
            this.btn_PLCSet.UseVisualStyleBackColor = true;
            this.btn_PLCSet.Click += new System.EventHandler(this.btn_PLCSet_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lbl_Exit);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(612, 48);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Exit.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.White;
            this.lbl_Exit.Location = new System.Drawing.Point(554, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(58, 47);
            this.lbl_Exit.TabIndex = 3;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "参数设置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cyy.PressurizationStationPro.Properties.Resources.Param;
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 1);
            this.label1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(319, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "摄像头选择：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "插槽号：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(337, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 24);
            this.label16.TabIndex = 3;
            this.label16.Text = "息屏时间：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(337, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "注销时间：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(564, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "秒";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(564, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "机架号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "CPU类型：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(337, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "开机启动:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(297, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 301);
            this.label9.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(337, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "▶系统参数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "▶通信参数";
            // 
            // FrmParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 394);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmParamSet";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_PLCSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Slot;
        private System.Windows.Forms.TextBox txt_Rack;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.Button btn_PLCCancel;
        private System.Windows.Forms.Label label9;
        private xbd.ControlLib.xbdToggle toggle_AutoStart;
        private System.Windows.Forms.TextBox txt_LogoffTime;
        private System.Windows.Forms.TextBox txt_ScreenTime;
        private System.Windows.Forms.Button btn_SysCancel;
        private System.Windows.Forms.Button btn_SysSet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_CpuType;
        private System.Windows.Forms.ComboBox cmb_Camera;
    }
}