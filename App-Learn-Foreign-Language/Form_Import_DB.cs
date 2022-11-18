using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using App_Learn_Foreign_Language;
using DevExpress.DataAccess.Excel;

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
            // Set form in bottom right
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            //Set form alway top
            this.TopMost = true;
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_DocBottom_Click(object sender, EventArgs e)
        {
            Set_Form_Bottom_Right_Screen();
        }

        private void lbl_Import_Data_Input_Click(object sender, EventArgs e)
        {
            //Get link file excel
            OpenFileDialog theDialog = new OpenFileDialog
            {
                Title = "Chọn file dữ liệu cho chương trình",
                Filter = "Files Excel|*.xls;*.xlsx"
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new Excel data source.
                ExcelDataSource excelDataSource = new ExcelDataSource
                {
                    FileName = theDialog.FileName
                };

                // Select a required worksheet.
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings
                {
                    WorksheetIndex = 0
                };

                // Specify import settings.
                ExcelSourceOptions excelSourceOptions = new ExcelSourceOptions
                {
                    ImportSettings = excelWorksheetSettings,
                    SkipHiddenRows = false,
                    SkipHiddenColumns = false,
                    UseFirstRowAsHeader = true
                };
                excelDataSource.SourceOptions = excelSourceOptions;

                excelDataSource.Fill();

                DataTable tableDataVocabulary = new DataTable();
                tableDataVocabulary.Columns.Add("STT", typeof(int));
                tableDataVocabulary.Columns.Add("Type", typeof(string));
                tableDataVocabulary.Columns.Add("Word", typeof(string));
                tableDataVocabulary.Columns.Add("API", typeof(string));
                tableDataVocabulary.Columns.Add("Explain_Vietnamese", typeof(string));
                tableDataVocabulary.Columns.Add("Explain_English", typeof(string));
                tableDataVocabulary.Columns.Add("Example", typeof(string));
                tableDataVocabulary.Columns.Add("Date_Study", typeof(DateTime));

                tableDataVocabulary = excelDataSource.ExcelToDataTable();

                List<Vocabulary> listVocabulary = 
                    (
                        from
                            row in tableDataVocabulary.AsEnumerable()
                        where
                           !String.IsNullOrEmpty(Convert.ToString(row.Field<string>("Word")))
                        select new Vocabulary
                        {
                            STT                 = Convert.ToInt32(row["STT"]),
                            Type                = Convert.ToString(row["Type"]),
                            Word                = Convert.ToString(row["Word"]),
                            API                 = Convert.ToString(row["API"]),
                            Explain_Vietnamese  = Convert.ToString(row["Explain_Vietnamese"]),
                            Explain_English     = Convert.ToString(row["Explain_English"]),
                            Example             = Convert.ToString(row["Example"]),
                            Date_Study          = row["Date_Study"] != DBNull.Value ? Convert.ToDateTime(row["Date_Study"]) : DateTime.Now
                        }).ToList();

                MessageBox.Show("Import dữ liệu chương trình thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                Form_Main _formMain = new Form_Main(listVocabulary);
                _formMain.Show();
            }
        }

        #region Moveable
        bool mouseDown = false;
        Point StartPoint = new Point(0, 0);
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel_Top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point currentPoint = PointToScreen(e.Location);
                this.Location = new Point(currentPoint.X - StartPoint.X, currentPoint.Y - StartPoint.Y);
            }    
        }
        #endregion

        private void lbl_Close_MouseHover(object sender, EventArgs e)
        {
            lbl_Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            lbl_Close.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
    }
}
