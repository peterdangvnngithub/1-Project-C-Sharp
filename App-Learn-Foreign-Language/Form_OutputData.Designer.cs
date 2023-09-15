
namespace App_Learn_Foreign_Language
{
    partial class Form_OutputData
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_Output = new DevExpress.XtraBars.BarButtonItem();
            this.Action = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl_ListVocabulary = new DevExpress.XtraGrid.GridControl();
            this.ListVocabulary_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ListVocabulary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListVocabulary_View)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtn_Output});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Action});
            this.ribbon.Size = new System.Drawing.Size(442, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtn_Output
            // 
            this.barBtn_Output.Caption = "Output Data";
            this.barBtn_Output.Id = 1;
            this.barBtn_Output.ImageOptions.SvgImage = global::App_Learn_Foreign_Language.Properties.Resources.exporttoxls;
            this.barBtn_Output.Name = "barBtn_Output";
            this.barBtn_Output.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtn_Output_ItemClick);
            // 
            // Action
            // 
            this.Action.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Action.Name = "Action";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_Output);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // gridControl_ListVocabulary
            // 
            this.gridControl_ListVocabulary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ListVocabulary.Location = new System.Drawing.Point(0, 158);
            this.gridControl_ListVocabulary.MainView = this.ListVocabulary_View;
            this.gridControl_ListVocabulary.MenuManager = this.ribbon;
            this.gridControl_ListVocabulary.Name = "gridControl_ListVocabulary";
            this.gridControl_ListVocabulary.Size = new System.Drawing.Size(442, 267);
            this.gridControl_ListVocabulary.TabIndex = 2;
            this.gridControl_ListVocabulary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListVocabulary_View});
            // 
            // ListVocabulary_View
            // 
            this.ListVocabulary_View.GridControl = this.gridControl_ListVocabulary;
            this.ListVocabulary_View.Name = "ListVocabulary_View";
            // 
            // Form_OutputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.gridControl_ListVocabulary);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::App_Learn_Foreign_Language.Properties.Resources.icon_language;
            this.Name = "Form_OutputData";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Form Output Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_OutputData_FormClosed);
            this.Load += new System.EventHandler(this.Form_OutputData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ListVocabulary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListVocabulary_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Action;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl_ListVocabulary;
        private DevExpress.XtraGrid.Views.Grid.GridView ListVocabulary_View;
        private DevExpress.XtraBars.BarButtonItem barBtn_Output;
    }
}