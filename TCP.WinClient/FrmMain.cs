using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP.WinClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StatusLbl.Text = "You are Valid User";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
           FrmLogin frmLogin =new FrmLogin();
            frmLogin.Show();
            this.Close();
           
        }
    }
}
