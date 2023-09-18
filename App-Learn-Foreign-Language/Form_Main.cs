using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Collections.Generic;
using App_Learn_Foreign_Language;

namespace App_Learn_English
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        readonly List<Vocabulary> listVocabulary = new List<Vocabulary>();

        Vocabulary _currentVocabulary = new Vocabulary();

        readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        #region Main Setting
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

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = 
                    MessageBox.Show("Bạn có muốn backup dữ liệu trước khi ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;    // Stopping Form Close perocess.
                }
            }
        }

        private void Setting_Speaker()
        {
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10
        }

        private void Set_Info_Vocabulary()
        {
            _currentVocabulary = listVocabulary.OrderBy(x => x.Date_Study).FirstOrDefault();

            StringBuilder sBuilder_ExplainEN = new StringBuilder();
            StringBuilder sBuilder_ExplainVN = new StringBuilder();
            StringBuilder sBuilder_Example = new StringBuilder();

            lbl_Word.Text = _currentVocabulary.Word;
            lbl_API.Text = _currentVocabulary.API;

            if (!String.IsNullOrEmpty(_currentVocabulary.Explain_English))
            {
                sBuilder_ExplainEN.Append(_currentVocabulary.Explain_English);
            }

            if (!String.IsNullOrEmpty(_currentVocabulary.Explain_Vietnamese))
            {
                sBuilder_ExplainVN.Append(_currentVocabulary.Explain_Vietnamese);
            }

            if (!String.IsNullOrEmpty(_currentVocabulary.Example))
            {
                sBuilder_Example.Append(_currentVocabulary.Example);
            }

            memoEdit_ExplainEN.EditValue = Convert.ToString(sBuilder_ExplainEN).Replace(".", ".\r\n");
            memoEdit_ExplainVN.EditValue = Convert.ToString(sBuilder_ExplainVN).Replace(".", ".\r\n");
            memoEdit_Example.EditValue = Convert.ToString(sBuilder_Example).Replace(".", ".\r\n");

            xtraTab_Main.SelectedTabPageIndex = 0;
        }

        private void Set_Form_Bottom_Right_Screen()
        {
            // Set form in bottom right
            this.StartPosition = FormStartPosition.Manual;
            this.Location = 
                new Point(
                    Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                    Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            //Set form alway top
            this.TopMost = true;
        }
        #endregion

        #region Moveable
        bool mouseDown = false;
        Point StartPoint = new Point(0, 0);
        private void Panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point currentLocation = PointToScreen(e.Location);
                this.Location = new Point(currentLocation.X - StartPoint.X, currentLocation.Y - StartPoint.Y);
            }    
        }

        private void Panel_Top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        #endregion

        #region ButtonEvent
        private void Lbl_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Lbl_Main_Dock_Bottom_Click(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();
        }
        
        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
                MessageBox.Show(
                    "Bạn có muốn backup dữ liệu cho lần học sau.\nBấm Ok để mở màn hình sao lưu.\nBấm No để thoát khỏi chương trình.", 
                    "Thông Báo", 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Form_OutputData form_OutputData = new Form_OutputData(listVocabulary)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                form_OutputData.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void Lbl_OneMinute_Click(object sender, EventArgs e)
        {
            foreach(Vocabulary data in listVocabulary)
            {
                if(_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = DateTime.Now.AddMinutes(1);
                }    
            }

            Handle_Hide_And_Show_Explain(false);

            Set_Info_Vocabulary();
        }

        private void Lbl_TenMinute_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = DateTime.Now.AddMinutes(10);
                }
            }

            Handle_Hide_And_Show_Explain(false);

            Set_Info_Vocabulary();
        }

        private void Lbl_ThirtyMinute_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = DateTime.Now.AddMinutes(30);
                }
            }

            Handle_Hide_And_Show_Explain(false);

            Set_Info_Vocabulary();
        }

        private void Lbl_OneDay_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = DateTime.Now.AddDays(1);
                }
            }

            Handle_Hide_And_Show_Explain(false);

            Set_Info_Vocabulary();
        }

        private void Lbl_FiveDays_Click(object sender, EventArgs e)
        {
            foreach (Vocabulary data in listVocabulary)
            {
                if (_currentVocabulary.STT.Equals(data.STT))
                {
                    data.Date_Study = DateTime.Now.AddDays(5);
                }
            }

            Handle_Hide_And_Show_Explain(false);

            Set_Info_Vocabulary();
        }

        private void Lbl_loudspeaker_Click(object sender, EventArgs e)
        {
            synthesizer.Speak(lbl_Word.Text);
        }

        private void btn_Explain_Click(object sender, EventArgs e)
        {
            Handle_Hide_And_Show_Explain(true);

            synthesizer.Speak(lbl_Word.Text);
        }

        private void Handle_Hide_And_Show_Explain(bool IsEnableExplain)
        {
            btn_Explain.Visible = !IsEnableExplain;
            lbl_API.Visible = IsEnableExplain;
            memoEdit_ExplainEN.Visible = IsEnableExplain;
            memoEdit_ExplainVN.Visible = IsEnableExplain;
            memoEdit_Example.Visible = IsEnableExplain;
        }
        
        private void memoEdit_ExplainEN_MouseUp(object sender, MouseEventArgs e)
        {
            string selectedText = memoEdit_ExplainEN.SelectedText.Trim().Replace(",","").Replace(".", "").Replace("[", "").Replace("]", "");

            // Check if have selected text
            if (!string.IsNullOrEmpty(selectedText))
            {
                // Handle event when user selected text
                string oxfordUrl = $"https://www.oxfordlearnersdictionaries.com/definition/english/{selectedText}";

                // Open Chrome
                Process.Start("chrome.exe", oxfordUrl);
            }
        }

        private void memoEdit_ExplainVN_MouseUp(object sender, MouseEventArgs e)
        {
            string selectedText = memoEdit_ExplainVN.SelectedText.Trim().Replace(",", "").Replace(".", "").Replace("[", "").Replace("]", "");

            // Check if have selected text
            if (!string.IsNullOrEmpty(selectedText))
            {
                // Handle event when user selected text
                string oxfordUrl = $"https://www.oxfordlearnersdictionaries.com/definition/english/{selectedText}";

                // Open Chrome
                Process.Start("chrome.exe", oxfordUrl);
            }
        }

        private void memoEdit_Example_MouseUp(object sender, MouseEventArgs e)
        {
            string selectedText = memoEdit_Example.SelectedText.Replace(",", "").Replace(".", "").Replace("[", "").Replace("]", "");

            // Check if have selected text
            if (!string.IsNullOrEmpty(selectedText))
            {
                // Handle event when user selected text
                string oxfordUrl = $"https://www.oxfordlearnersdictionaries.com/definition/english/{selectedText}";

                // Open Chrome
                Process.Start("chrome.exe", oxfordUrl);
            }
        }
        #endregion
    }
}
