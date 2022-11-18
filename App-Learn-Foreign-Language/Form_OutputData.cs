using App_Learn_English;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraPrinting;

namespace App_Learn_Foreign_Language
{
    public partial class Form_OutputData : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Vocabulary> listVocabulary = new List<Vocabulary>();

        private GridColumn gridCol_OrderNumber          = new GridColumn();
        private GridColumn gridCol_Type                 = new GridColumn();
        private GridColumn gridCol_Word                 = new GridColumn();
        private GridColumn gridCol_API                  = new GridColumn();
        private GridColumn gridCol_Explain_Vietnamese   = new GridColumn();
        private GridColumn gridCol_Explain_English      = new GridColumn();
        private GridColumn gridCol_Example              = new GridColumn();
        private GridColumn gridCol_Date_Study           = new GridColumn();

        public Form_OutputData(List<Vocabulary> _listVocabulary)
        {
            InitializeComponent();

            listVocabulary = _listVocabulary;
        }

        private void Form_OutputData_Load(object sender, EventArgs e)
        {
            Define_GridView();

            gridControl_ListVocabulary.DataSource = listVocabulary;
        }

        private void Define_GridView()
        {
            ListVocabulary_View.OptionsPrint.AutoWidth = false;
            ListVocabulary_View.OptionsView.ColumnAutoWidth = false;

            // ORDER NUMBER (STT)
            gridCol_OrderNumber.Name = "gridCol_OrderNumber";
            gridCol_OrderNumber.Caption = "STT";
            gridCol_OrderNumber.FieldName = "STT";
            gridCol_OrderNumber.VisibleIndex = 0;
            gridCol_OrderNumber.Width = 50;
            gridCol_OrderNumber.AppearanceCell.Options.UseTextOptions = true;
            gridCol_OrderNumber.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

            // TYPE
            gridCol_Type.Name = "gridCol_Type";
            gridCol_Type.Caption = "Type";
            gridCol_Type.FieldName = "Type";
            gridCol_Type.VisibleIndex = 0;
            gridCol_Type.Width = 110;
            gridCol_Type.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Type.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

            // WORD
            gridCol_Word.Name = "gridCol_Word";
            gridCol_Word.Caption = "Word";
            gridCol_Word.FieldName = "Word";
            gridCol_Word.VisibleIndex = 0;
            gridCol_Word.Width = 110;
            gridCol_Word.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Word.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

            // API
            gridCol_API.Name = "gridCol_API";
            gridCol_API.Caption = "API";
            gridCol_API.FieldName = "API";
            gridCol_API.VisibleIndex = 0;
            gridCol_API.Width = 114;
            gridCol_API.AppearanceCell.Options.UseTextOptions = true;
            gridCol_API.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

            // EXPLAIN VIETNAMESE
            gridCol_Explain_Vietnamese.Name = "gridCol_Explain_Vietnamese";
            gridCol_Explain_Vietnamese.Caption = "Explain_Vietnamese";
            gridCol_Explain_Vietnamese.FieldName = "Explain_Vietnamese";
            gridCol_Explain_Vietnamese.VisibleIndex = 0;
            gridCol_Explain_Vietnamese.Width = 150;
            gridCol_Explain_Vietnamese.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Explain_Vietnamese.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;

            // EXPLAIN ENGLISH
            gridCol_Explain_English.Name = "gridCol_Explain_English";
            gridCol_Explain_English.Caption = "Explain_English";
            gridCol_Explain_English.FieldName = "Explain_English";
            gridCol_Explain_English.VisibleIndex = 0;
            gridCol_Explain_English.Width = 150;
            gridCol_Explain_English.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Explain_English.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;

            // EXAMPLE
            gridCol_Example.Name = "gridCol_Example";
            gridCol_Example.Caption = "Example";
            gridCol_Example.FieldName = "Example";
            gridCol_Example.VisibleIndex = 0;
            gridCol_Example.Width = 224;
            gridCol_Example.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Example.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;

            // DATE STUDY
            gridCol_Date_Study.Name = "gridCol_Date_Study";
            gridCol_Date_Study.Caption = "Date_Study";
            gridCol_Date_Study.FieldName = "Date_Study";
            gridCol_Date_Study.ColumnEdit = new RepositoryItemDateEdit();
            gridCol_Date_Study.VisibleIndex = 0;
            gridCol_Date_Study.Width = 120;
            gridCol_Date_Study.AppearanceCell.Options.UseTextOptions = true;
            gridCol_Date_Study.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridCol_Date_Study.DisplayFormat.FormatString = "dd/MM/yyyy";
            gridCol_Date_Study.DisplayFormat.FormatType = FormatType.DateTime;

            // Add column to gridview
            ListVocabulary_View.Columns.Add(gridCol_OrderNumber);
            ListVocabulary_View.Columns.Add(gridCol_Type);
            ListVocabulary_View.Columns.Add(gridCol_Word);
            ListVocabulary_View.Columns.Add(gridCol_API);
            ListVocabulary_View.Columns.Add(gridCol_Explain_Vietnamese);
            ListVocabulary_View.Columns.Add(gridCol_Explain_English);
            ListVocabulary_View.Columns.Add(gridCol_Example);
            ListVocabulary_View.Columns.Add(gridCol_Date_Study);

            // Set common attribute
            foreach (GridColumn c in ListVocabulary_View.Columns)
            {
                c.AppearanceHeader.Options.UseFont = true;
                c.AppearanceHeader.Options.UseForeColor = true;
                c.AppearanceHeader.Options.UseTextOptions = true;
                c.AppearanceHeader.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                c.AppearanceHeader.ForeColor = Color.Black;
                c.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                c.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            }
        }

        private void barBtn_Output_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Title = "Save Vocabulary Data",
                FileName = $"{DateTime.Now.ToString("dd-MM-yyyy-hhMMss")}_Vocabulary",
                Filter = "Files Excel|*.xlsx;*.xls"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                XlsxExportOptionsEx xlsxExportOptionsEx = new XlsxExportOptionsEx();
                xlsxExportOptionsEx.AllowSortingAndFiltering = DefaultBoolean.False;

                gridControl_ListVocabulary.ExportToXlsx(path, xlsxExportOptionsEx);

                // Open the created XLSX file with the default application.
                Process.Start(path);
            }
        }
    }
}