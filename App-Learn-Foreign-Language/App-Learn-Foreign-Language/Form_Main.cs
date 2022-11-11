using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Learn_English
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();
        }

        private void Set_Form_BackGround_Transparent()
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
        }

        private void Set_Form_Bottom_Right_Screen()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
