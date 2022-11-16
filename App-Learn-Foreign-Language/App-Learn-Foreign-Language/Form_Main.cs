using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Text;

namespace App_Learn_English
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        List<Vocabulary> listVocabulary = new List<Vocabulary>();

        Vocabulary _currentVocabulary = new Vocabulary();

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form_Main(List<Vocabulary> _listVocabulary)
        {
            InitializeComponent();

            listVocabulary = new List<Vocabulary>(_listVocabulary);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();

            Set_Info_Vocabulary();

            Setting_Speaker();
        }

        private void Set_Info_Vocabulary()
        {
            _currentVocabulary = listVocabulary.OrderBy(x=>x.Date_Study).FirstOrDefault();

            StringBuilder sBuilder = new StringBuilder();

            lbl_Word.Text = _currentVocabulary.Word;
            lbl_API.Text = _currentVocabulary.API;

            if(!String.IsNullOrEmpty(_currentVocabulary.Explain_English))
            {
                sBuilder.Append(_currentVocabulary.Explain_English);
            }

            if (!String.IsNullOrEmpty(_currentVocabulary.Explain_Vietnamese))
            {
                sBuilder.Append("\n");
                sBuilder.Append(_currentVocabulary.Explain_Vietnamese);
            }

            if (!String.IsNullOrEmpty(_currentVocabulary.Example))
            {
                sBuilder.Append("\n");
                sBuilder.Append("Ex: ");
                sBuilder.Append(_currentVocabulary.Example);
            }


            lbl_Explain.TextAlign = ContentAlignment.TopLeft;
            lbl_Explain.Text = Convert.ToString(sBuilder);
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

        private void Setting_Speaker()
        {
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10
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

            Set_Info_Vocabulary();
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

            Set_Info_Vocabulary();
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

            Set_Info_Vocabulary();
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

            Set_Info_Vocabulary();
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

            Set_Info_Vocabulary();
        }

        private void lbl_loudspeaker_Click(object sender, EventArgs e)
        {
            synthesizer.Speak(lbl_Word.Text);
        }
        #endregion
    }
}
