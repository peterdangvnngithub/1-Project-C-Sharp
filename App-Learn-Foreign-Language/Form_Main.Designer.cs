
namespace App_Learn_English
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_Main_Minimize = new System.Windows.Forms.Label();
            this.lbl_Main_Dock_Bottom = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lbl_ThirtyMinute = new System.Windows.Forms.Label();
            this.lbl_OneDay = new System.Windows.Forms.Label();
            this.lbl_TenMinute = new System.Windows.Forms.Label();
            this.lbl_OneMinute = new System.Windows.Forms.Label();
            this.lbl_FiveDays = new System.Windows.Forms.Label();
            this.panel_Vocabulary = new System.Windows.Forms.Panel();
            this.panel_Word = new System.Windows.Forms.Panel();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.panel_API = new System.Windows.Forms.Panel();
            this.btn_Explain = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_loudspeaker = new System.Windows.Forms.Label();
            this.lbl_API = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.xtraTab_Main = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTab_Explain = new DevExpress.XtraTab.XtraTabPage();
            this.panel_Example = new System.Windows.Forms.Panel();
            this.memoEdit_ExplainVN = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTab_ExplainEN = new DevExpress.XtraTab.XtraTabPage();
            this.panel_Explan = new System.Windows.Forms.Panel();
            this.memoEdit_ExplainEN = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTab_Example = new DevExpress.XtraTab.XtraTabPage();
            this.memoEdit_Example = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_Top.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel_Vocabulary.SuspendLayout();
            this.panel_Word.SuspendLayout();
            this.panel_API.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Main)).BeginInit();
            this.xtraTab_Main.SuspendLayout();
            this.xtraTab_Explain.SuspendLayout();
            this.panel_Example.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_ExplainVN.Properties)).BeginInit();
            this.xtraTab_ExplainEN.SuspendLayout();
            this.panel_Explan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_ExplainEN.Properties)).BeginInit();
            this.xtraTab_Example.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Example.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.labelControl1);
            this.panel_Top.Controls.Add(this.lbl_Main_Minimize);
            this.panel_Top.Controls.Add(this.lbl_Main_Dock_Bottom);
            this.panel_Top.Controls.Add(this.lbl_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(5, 5);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(270, 25);
            this.panel_Top.TabIndex = 4;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseUp);
            // 
            // lbl_Main_Minimize
            // 
            this.lbl_Main_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Main_Minimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Main_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Main_Minimize.Location = new System.Drawing.Point(171, 0);
            this.lbl_Main_Minimize.Name = "lbl_Main_Minimize";
            this.lbl_Main_Minimize.Size = new System.Drawing.Size(35, 25);
            this.lbl_Main_Minimize.TabIndex = 3;
            this.lbl_Main_Minimize.Text = "-";
            this.lbl_Main_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Main_Minimize.Click += new System.EventHandler(this.Lbl_Minimize_Click);
            // 
            // lbl_Main_Dock_Bottom
            // 
            this.lbl_Main_Dock_Bottom.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_Dock_Bottom.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Main_Dock_Bottom.Appearance.Options.UseFont = true;
            this.lbl_Main_Dock_Bottom.Appearance.Options.UseForeColor = true;
            this.lbl_Main_Dock_Bottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Main_Dock_Bottom.Location = new System.Drawing.Point(206, 0);
            this.lbl_Main_Dock_Bottom.Name = "lbl_Main_Dock_Bottom";
            this.lbl_Main_Dock_Bottom.Size = new System.Drawing.Size(29, 25);
            this.lbl_Main_Dock_Bottom.TabIndex = 5;
            this.lbl_Main_Dock_Bottom.Text = "  ↓  ";
            this.lbl_Main_Dock_Bottom.ToolTip = "Dock To Bottom";
            this.lbl_Main_Dock_Bottom.Click += new System.EventHandler(this.Lbl_Main_Dock_Bottom_Click);
            // 
            // lbl_Close
            // 
            this.lbl_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Close.Location = new System.Drawing.Point(235, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(35, 25);
            this.lbl_Close.TabIndex = 0;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Click += new System.EventHandler(this.Lbl_Close_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lbl_ThirtyMinute);
            this.panelBottom.Controls.Add(this.lbl_OneDay);
            this.panelBottom.Controls.Add(this.lbl_TenMinute);
            this.panelBottom.Controls.Add(this.lbl_OneMinute);
            this.panelBottom.Controls.Add(this.lbl_FiveDays);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 225);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(270, 25);
            this.panelBottom.TabIndex = 9;
            // 
            // lbl_ThirtyMinute
            // 
            this.lbl_ThirtyMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ThirtyMinute.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_ThirtyMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_ThirtyMinute.Location = new System.Drawing.Point(108, 0);
            this.lbl_ThirtyMinute.Name = "lbl_ThirtyMinute";
            this.lbl_ThirtyMinute.Size = new System.Drawing.Size(54, 25);
            this.lbl_ThirtyMinute.TabIndex = 10;
            this.lbl_ThirtyMinute.Text = "30 Phút";
            this.lbl_ThirtyMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ThirtyMinute.Click += new System.EventHandler(this.Lbl_ThirtyMinute_Click);
            // 
            // lbl_OneDay
            // 
            this.lbl_OneDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_OneDay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_OneDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_OneDay.Location = new System.Drawing.Point(162, 0);
            this.lbl_OneDay.Name = "lbl_OneDay";
            this.lbl_OneDay.Size = new System.Drawing.Size(54, 25);
            this.lbl_OneDay.TabIndex = 9;
            this.lbl_OneDay.Text = "1 Ngày";
            this.lbl_OneDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OneDay.Click += new System.EventHandler(this.Lbl_OneDay_Click);
            // 
            // lbl_TenMinute
            // 
            this.lbl_TenMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TenMinute.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_TenMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_TenMinute.Location = new System.Drawing.Point(54, 0);
            this.lbl_TenMinute.Name = "lbl_TenMinute";
            this.lbl_TenMinute.Size = new System.Drawing.Size(54, 25);
            this.lbl_TenMinute.TabIndex = 8;
            this.lbl_TenMinute.Text = "10 Phút";
            this.lbl_TenMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TenMinute.Click += new System.EventHandler(this.Lbl_TenMinute_Click);
            // 
            // lbl_OneMinute
            // 
            this.lbl_OneMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_OneMinute.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_OneMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_OneMinute.Location = new System.Drawing.Point(0, 0);
            this.lbl_OneMinute.Name = "lbl_OneMinute";
            this.lbl_OneMinute.Size = new System.Drawing.Size(54, 25);
            this.lbl_OneMinute.TabIndex = 7;
            this.lbl_OneMinute.Text = "1 Phút";
            this.lbl_OneMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OneMinute.Click += new System.EventHandler(this.Lbl_OneMinute_Click);
            // 
            // lbl_FiveDays
            // 
            this.lbl_FiveDays.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_FiveDays.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_FiveDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_FiveDays.Location = new System.Drawing.Point(216, 0);
            this.lbl_FiveDays.Name = "lbl_FiveDays";
            this.lbl_FiveDays.Size = new System.Drawing.Size(54, 25);
            this.lbl_FiveDays.TabIndex = 6;
            this.lbl_FiveDays.Text = "5 Ngày";
            this.lbl_FiveDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_FiveDays.Click += new System.EventHandler(this.Lbl_FiveDays_Click);
            // 
            // panel_Vocabulary
            // 
            this.panel_Vocabulary.Controls.Add(this.panel_Word);
            this.panel_Vocabulary.Controls.Add(this.panel_API);
            this.panel_Vocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Vocabulary.Location = new System.Drawing.Point(5, 30);
            this.panel_Vocabulary.Name = "panel_Vocabulary";
            this.panel_Vocabulary.Size = new System.Drawing.Size(270, 61);
            this.panel_Vocabulary.TabIndex = 0;
            // 
            // panel_Word
            // 
            this.panel_Word.Controls.Add(this.lbl_Word);
            this.panel_Word.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Word.Location = new System.Drawing.Point(0, 0);
            this.panel_Word.Name = "panel_Word";
            this.panel_Word.Size = new System.Drawing.Size(270, 28);
            this.panel_Word.TabIndex = 2;
            // 
            // lbl_Word
            // 
            this.lbl_Word.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Word.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Word.Location = new System.Drawing.Point(0, 0);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(270, 28);
            this.lbl_Word.TabIndex = 0;
            this.lbl_Word.Text = "New Word";
            this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_API
            // 
            this.panel_API.Controls.Add(this.btn_Explain);
            this.panel_API.Controls.Add(this.lbl_loudspeaker);
            this.panel_API.Controls.Add(this.lbl_API);
            this.panel_API.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_API.Location = new System.Drawing.Point(0, 31);
            this.panel_API.Name = "panel_API";
            this.panel_API.Size = new System.Drawing.Size(270, 30);
            this.panel_API.TabIndex = 1;
            // 
            // btn_Explain
            // 
            this.btn_Explain.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Explain.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.btn_Explain.Appearance.Options.UseFont = true;
            this.btn_Explain.Appearance.Options.UseForeColor = true;
            this.btn_Explain.Location = new System.Drawing.Point(87, 2);
            this.btn_Explain.Name = "btn_Explain";
            this.btn_Explain.Size = new System.Drawing.Size(75, 23);
            this.btn_Explain.TabIndex = 3;
            this.btn_Explain.Text = "Explain";
            this.btn_Explain.Click += new System.EventHandler(this.btn_Explain_Click);
            // 
            // lbl_loudspeaker
            // 
            this.lbl_loudspeaker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_loudspeaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_loudspeaker.Location = new System.Drawing.Point(240, 0);
            this.lbl_loudspeaker.Name = "lbl_loudspeaker";
            this.lbl_loudspeaker.Size = new System.Drawing.Size(30, 25);
            this.lbl_loudspeaker.TabIndex = 1;
            this.lbl_loudspeaker.Text = "🕪";
            this.lbl_loudspeaker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_loudspeaker.Click += new System.EventHandler(this.Lbl_loudspeaker_Click);
            // 
            // lbl_API
            // 
            this.lbl_API.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_API.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_API.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.lbl_API.Location = new System.Drawing.Point(0, 0);
            this.lbl_API.Name = "lbl_API";
            this.lbl_API.Size = new System.Drawing.Size(270, 30);
            this.lbl_API.TabIndex = 1;
            this.lbl_API.Text = "API";
            this.lbl_API.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_API.Visible = false;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.xtraTab_Main);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(5, 91);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(270, 134);
            this.panel_Main.TabIndex = 0;
            // 
            // xtraTab_Main
            // 
            this.xtraTab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTab_Main.Location = new System.Drawing.Point(0, 0);
            this.xtraTab_Main.Name = "xtraTab_Main";
            this.xtraTab_Main.SelectedTabPage = this.xtraTab_Explain;
            this.xtraTab_Main.Size = new System.Drawing.Size(270, 134);
            this.xtraTab_Main.TabIndex = 2;
            this.xtraTab_Main.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTab_ExplainEN,
            this.xtraTab_Explain,
            this.xtraTab_Example});
            // 
            // xtraTab_Explain
            // 
            this.xtraTab_Explain.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTab_Explain.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.xtraTab_Explain.Appearance.Header.Options.UseFont = true;
            this.xtraTab_Explain.Appearance.Header.Options.UseForeColor = true;
            this.xtraTab_Explain.Controls.Add(this.panel_Example);
            this.xtraTab_Explain.Name = "xtraTab_Explain";
            this.xtraTab_Explain.Size = new System.Drawing.Size(268, 109);
            this.xtraTab_Explain.Text = "Explain VN";
            // 
            // panel_Example
            // 
            this.panel_Example.Controls.Add(this.memoEdit_ExplainVN);
            this.panel_Example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Example.Location = new System.Drawing.Point(0, 0);
            this.panel_Example.Name = "panel_Example";
            this.panel_Example.Size = new System.Drawing.Size(268, 109);
            this.panel_Example.TabIndex = 5;
            // 
            // memoEdit_ExplainVN
            // 
            this.memoEdit_ExplainVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit_ExplainVN.EditValue = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" +
    "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.memoEdit_ExplainVN.Location = new System.Drawing.Point(0, 0);
            this.memoEdit_ExplainVN.Name = "memoEdit_ExplainVN";
            this.memoEdit_ExplainVN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit_ExplainVN.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.memoEdit_ExplainVN.Properties.Appearance.Options.UseFont = true;
            this.memoEdit_ExplainVN.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit_ExplainVN.Size = new System.Drawing.Size(268, 109);
            this.memoEdit_ExplainVN.TabIndex = 4;
            this.memoEdit_ExplainVN.Visible = false;
            this.memoEdit_ExplainVN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoEdit_ExplainVN_MouseUp);
            // 
            // xtraTab_ExplainEN
            // 
            this.xtraTab_ExplainEN.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTab_ExplainEN.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.xtraTab_ExplainEN.Appearance.Header.Options.UseFont = true;
            this.xtraTab_ExplainEN.Appearance.Header.Options.UseForeColor = true;
            this.xtraTab_ExplainEN.Controls.Add(this.panel_Explan);
            this.xtraTab_ExplainEN.Name = "xtraTab_ExplainEN";
            this.xtraTab_ExplainEN.Size = new System.Drawing.Size(268, 109);
            this.xtraTab_ExplainEN.Text = "Explain EN";
            // 
            // panel_Explan
            // 
            this.panel_Explan.Controls.Add(this.memoEdit_ExplainEN);
            this.panel_Explan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Explan.Location = new System.Drawing.Point(0, 0);
            this.panel_Explan.Name = "panel_Explan";
            this.panel_Explan.Size = new System.Drawing.Size(268, 109);
            this.panel_Explan.TabIndex = 4;
            // 
            // memoEdit_ExplainEN
            // 
            this.memoEdit_ExplainEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit_ExplainEN.EditValue = resources.GetString("memoEdit_ExplainEN.EditValue");
            this.memoEdit_ExplainEN.Location = new System.Drawing.Point(0, 0);
            this.memoEdit_ExplainEN.Name = "memoEdit_ExplainEN";
            this.memoEdit_ExplainEN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit_ExplainEN.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.memoEdit_ExplainEN.Properties.Appearance.Options.UseFont = true;
            this.memoEdit_ExplainEN.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit_ExplainEN.Size = new System.Drawing.Size(268, 109);
            this.memoEdit_ExplainEN.TabIndex = 2;
            this.memoEdit_ExplainEN.Visible = false;
            this.memoEdit_ExplainEN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoEdit_ExplainEN_MouseUp);
            // 
            // xtraTab_Example
            // 
            this.xtraTab_Example.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTab_Example.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.xtraTab_Example.Appearance.Header.Options.UseFont = true;
            this.xtraTab_Example.Appearance.Header.Options.UseForeColor = true;
            this.xtraTab_Example.Controls.Add(this.memoEdit_Example);
            this.xtraTab_Example.Name = "xtraTab_Example";
            this.xtraTab_Example.Size = new System.Drawing.Size(268, 109);
            this.xtraTab_Example.Text = "Example";
            // 
            // memoEdit_Example
            // 
            this.memoEdit_Example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit_Example.EditValue = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" +
    "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.memoEdit_Example.Location = new System.Drawing.Point(0, 0);
            this.memoEdit_Example.Name = "memoEdit_Example";
            this.memoEdit_Example.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit_Example.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.memoEdit_Example.Properties.Appearance.Options.UseFont = true;
            this.memoEdit_Example.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit_Example.Size = new System.Drawing.Size(268, 109);
            this.memoEdit_Example.TabIndex = 5;
            this.memoEdit_Example.Visible = false;
            this.memoEdit_Example.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoEdit_Example_MouseUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 25);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = " ⋮  ";
            this.labelControl1.ToolTip = "About App";
            // 
            // Form_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Vocabulary);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::App_Learn_Foreign_Language.Properties.Resources.icon_language;
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panel_Vocabulary.ResumeLayout(false);
            this.panel_Word.ResumeLayout(false);
            this.panel_API.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Main)).EndInit();
            this.xtraTab_Main.ResumeLayout(false);
            this.xtraTab_Explain.ResumeLayout(false);
            this.panel_Example.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_ExplainVN.Properties)).EndInit();
            this.xtraTab_ExplainEN.ResumeLayout(false);
            this.panel_Explan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_ExplainEN.Properties)).EndInit();
            this.xtraTab_Example.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Example.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Vocabulary;
        private System.Windows.Forms.Panel panel_Word;
        
        private System.Windows.Forms.Label lbl_FiveDays;
        private System.Windows.Forms.Label lbl_OneDay;
        private System.Windows.Forms.Label lbl_TenMinute;
        private System.Windows.Forms.Label lbl_OneMinute;
        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_ThirtyMinute;
        private DevExpress.XtraEditors.SimpleButton btn_Explain;
        private DevExpress.XtraEditors.LabelControl lbl_Main_Dock_Bottom;
        private System.Windows.Forms.Label lbl_Main_Minimize;
        private System.Windows.Forms.Panel panel_API;
        private System.Windows.Forms.Label lbl_loudspeaker;
        private System.Windows.Forms.Panel panel_Explan;
        private DevExpress.XtraEditors.MemoEdit memoEdit_ExplainEN;
        private System.Windows.Forms.Panel panel_Example;
        private DevExpress.XtraEditors.MemoEdit memoEdit_ExplainVN;
        private System.Windows.Forms.Label lbl_API;
        private DevExpress.XtraTab.XtraTabControl xtraTab_Main;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Explain;
        private DevExpress.XtraTab.XtraTabPage xtraTab_ExplainEN;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Example;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Example;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

