using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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
                    WorksheetName = "Sheet1"
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

                DataTable tableEmployee = new DataTable();
                tableEmployee.Columns.Add("STT", typeof(int));
                tableEmployee.Columns.Add("CODE", typeof(string));
                tableEmployee.Columns.Add("NAME", typeof(string));
                tableEmployee.Columns.Add("M", typeof(string));
                tableEmployee.Columns.Add("E1", typeof(string));
                tableEmployee.Columns.Add("E2", typeof(string));
                tableEmployee.Columns.Add("E3", typeof(string));
                tableEmployee.Columns.Add("E4", typeof(string));
                tableEmployee.Columns.Add("WK", typeof(string));

                tableEmployee = excelDataSource.ExcelToDataTable();

                //using (ATPOS_Entities db = new ATPOS_Entities())
                //{
                //    foreach (DataRow row in tableEmployee.Rows)
                //    {
                //        string _EmpCode = Convert.ToString(row["CODE"]);
                //        string _M = Convert.ToString(row["M"]);
                //        string _E1 = Convert.ToString(row["E1"]);
                //        string _E2 = Convert.ToString(row["E2"]);
                //        string _E3 = Convert.ToString(row["E3"]);
                //        string _E4 = Convert.ToString(row["E4"]);
                //        string _WK = Convert.ToString(row["WK"]);

                //        //Check exit employee in date in DB
                //        var isExist = db.DATA_SHIFT.Where(x => (x.WORKER.Equals(_EmpCode))
                //                                            && (x.DATE.Equals(get_date.Date))).SingleOrDefault();

                //        if (isExist != null)
                //        {
                //            //If exist employee update info

                //        }
                //        else
                //        {
                //            //Otherwise add new
                //        }

                //        //Excute
                //        try
                //        {
                //            db.SaveChanges();
                //        }
                //        catch (Exception ex)
                //        {
                //            MessageBox.Show($"Loại lỗi: {ex.GetType()}.\nLỗi: {ex}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); // What is the real exception?
                //        }
                //    }
                //}

                MessageBox.Show("Import dữ liệu chương trình thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
