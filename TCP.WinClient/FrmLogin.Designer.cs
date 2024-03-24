using System;

namespace TCP.WinClient
{
    partial class FrmLogin
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
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.PnlCenter = new System.Windows.Forms.Panel();
            this.XmitBtn = new System.Windows.Forms.Button();
            this.TxtUname = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            this.PnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Pnl1.Controls.Add(this.PnlCenter);
            this.Pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(800, 450);
            this.Pnl1.TabIndex = 0;
            this.Pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl1_Paint);
            // 
            // PnlCenter
            // 
            this.PnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlCenter.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlCenter.Controls.Add(this.XmitBtn);
            this.PnlCenter.Controls.Add(this.TxtUname);
            this.PnlCenter.Controls.Add(this.TxtPass);
            this.PnlCenter.Controls.Add(this.Lb1);
            this.PnlCenter.Location = new System.Drawing.Point(248, 52);
            this.PnlCenter.Name = "PnlCenter";
            this.PnlCenter.Size = new System.Drawing.Size(282, 316);
            this.PnlCenter.TabIndex = 0;
            // 
            // XmitBtn
            // 
            this.XmitBtn.BackColor = System.Drawing.Color.LightGreen;
            this.XmitBtn.Location = new System.Drawing.Point(83, 210);
            this.XmitBtn.Name = "XmitBtn";
            this.XmitBtn.Size = new System.Drawing.Size(101, 29);
            this.XmitBtn.TabIndex = 3;
            this.XmitBtn.Text = "SUBMIT";
            this.XmitBtn.UseVisualStyleBackColor = false;
            this.XmitBtn.Click += new System.EventHandler(this.XmitBtn_Click);
            // 
            // TxtUname
            // 
            this.TxtUname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUname.Location = new System.Drawing.Point(42, 77);
            this.TxtUname.Name = "TxtUname";
            this.TxtUname.Size = new System.Drawing.Size(193, 29);
            this.TxtUname.TabIndex = 1;
            // 
            // TxtPass
            // 
            this.TxtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(42, 133);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(193, 29);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Lb1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lb1.Location = new System.Drawing.Point(55, 13);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(157, 33);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "User Login";
            this.Lb1.Click += new System.EventHandler(this.Lb1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Pnl1.ResumeLayout(false);
            this.PnlCenter.ResumeLayout(false);
            this.PnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Lb1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel PnlCenter;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button XmitBtn;
        private System.Windows.Forms.TextBox TxtUname;
        private System.Windows.Forms.TextBox TxtPass;
    }
}

