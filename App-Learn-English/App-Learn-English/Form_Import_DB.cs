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
    public partial class Form_Import_DB : DevExpress.XtraEditors.XtraForm
    {
        public Form_Import_DB()
        {
            InitializeComponent();
        }

        private void Form_Import_DB_Load(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();
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

        private void lbl_Import_Data_Input_Click(object sender, EventArgs e)
        {

        }
    }
}
