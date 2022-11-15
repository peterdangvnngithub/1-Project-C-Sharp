using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace App_Learn_English
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        List<Vocabulary> listVocabulary = new List<Vocabulary>();

        Vocabulary _currentVocabulary = new Vocabulary();

        public Form_Main(List<Vocabulary> _listVocabulary)
        {
            InitializeComponent();

            listVocabulary = new List<Vocabulary>(_listVocabulary);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();

            Set_Info();
        }

        private void Set_Info()
        {
            _currentVocabulary = listVocabulary.OrderBy(x=>x.Date_Study).FirstOrDefault();

            lbl_Word.Text = _currentVocabulary.Word;
            lbl_API.Text = _currentVocabulary.API;

            lbl_Explain.TextAlign = ContentAlignment.TopLeft;
            lbl_Explain.Text = _currentVocabulary.Explain_English + "\n" + _currentVocabulary.Explain_Vietnamese;
        }

        private void Set_Form_BackGround_Transparent()
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
        }

        private void Set_Form_Bottom_Right_Screen()
        {
            // Set form in bottom right
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            //Set form alway top
            this.TopMost = true;
        }

        #region Moveable
        bool mouseDown = false;
        Point StartPoint = new Point(0, 0);
        private void panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point currentLocation = PointToScreen(e.Location);
                this.Location = new Point(currentLocation.X - StartPoint.X, currentLocation.Y - StartPoint.Y);
            }    
        }

        private void panel_Top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        #endregion

        #region ButtonEvent
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_DocBottom_Click(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_OneMinute_Click(object sender, EventArgs e)
        {
            foreach(Vocabulary data in listVocabulary)
            {
                if(_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = data.Date_Study.AddMinutes(1);
                }    
            }

            Set_Info();
        }

        private void lbl_TenMinute_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = data.Date_Study.AddMinutes(10);
                }
            }

            Set_Info();
        }

        private void lbl_ThirtyMinute_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = data.Date_Study.AddMinutes(30);
                }
            }

            Set_Info();
        }

        private void lbl_OneDay_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = data.Date_Study.AddDays(1);
                }
            }

            Set_Info();
        }

        private void lbl_FiveĐays_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = data.Date_Study.AddDays(5);
                }
            }

            Set_Info();
        }
        #endregion
    }
}
