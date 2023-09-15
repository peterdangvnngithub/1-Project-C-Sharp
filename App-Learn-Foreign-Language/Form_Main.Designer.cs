
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.lbl_DocBottom = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lbl_ThirtyMinute = new System.Windows.Forms.Label();
            this.lbl_OneDay = new System.Windows.Forms.Label();
            this.lbl_TenMinute = new System.Windows.Forms.Label();
            this.lbl_OneMinute = new System.Windows.Forms.Label();
            this.lbl_FiveDays = new System.Windows.Forms.Label();
            this.panel_Vocabulary = new System.Windows.Forms.Panel();
            this.panel_Vocabulary_Main = new System.Windows.Forms.Panel();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.panel_Vocabulary_Right = new System.Windows.Forms.Panel();
            this.btnAPI = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_loudspeaker = new System.Windows.Forms.Label();
            this.lbl_API = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoEdit_Example = new DevExpress.XtraEditors.MemoEdit();
            this.lbl_Example = new System.Windows.Forms.Label();
            this.panel_Explan = new System.Windows.Forms.Panel();
            this.btnExplain = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit_Explain = new DevExpress.XtraEditors.MemoEdit();
            this.lbl_Explain = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel_Vocabulary.SuspendLayout();
            this.panel_Vocabulary_Main.SuspendLayout();
            this.panel_Vocabulary_Right.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Example.Properties)).BeginInit();
            this.panel_Explan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Explain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.lbl_Minimize);
            this.panel_Top.Controls.Add(this.lbl_DocBottom);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "⋮";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Minimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Minimize.Location = new System.Drawing.Point(165, 0);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(35, 25);
            this.lbl_Minimize.TabIndex = 3;
            this.lbl_Minimize.Text = "-";
            this.lbl_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Minimize.Click += new System.EventHandler(this.Lbl_Minimize_Click);
            // 
            // lbl_DocBottom
            // 
            this.lbl_DocBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_DocBottom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_DocBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_DocBottom.Location = new System.Drawing.Point(200, 0);
            this.lbl_DocBottom.Name = "lbl_DocBottom";
            this.lbl_DocBottom.Size = new System.Drawing.Size(35, 25);
            this.lbl_DocBottom.TabIndex = 2;
            this.lbl_DocBottom.Text = "↓";
            this.lbl_DocBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_DocBottom.Click += new System.EventHandler(this.Lbl_DocBottom_Click);
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
            this.panelBottom.Location = new System.Drawing.Point(5, 243);
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
            this.panel_Vocabulary.Controls.Add(this.panel_Vocabulary_Main);
            this.panel_Vocabulary.Controls.Add(this.panel_Vocabulary_Right);
            this.panel_Vocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Vocabulary.Location = new System.Drawing.Point(5, 30);
            this.panel_Vocabulary.Name = "panel_Vocabulary";
            this.panel_Vocabulary.Size = new System.Drawing.Size(270, 56);
            this.panel_Vocabulary.TabIndex = 10;
            // 
            // panel_Vocabulary_Main
            // 
            this.panel_Vocabulary_Main.Controls.Add(this.lbl_Word);
            this.panel_Vocabulary_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Vocabulary_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Vocabulary_Main.Name = "panel_Vocabulary_Main";
            this.panel_Vocabulary_Main.Size = new System.Drawing.Size(270, 28);
            this.panel_Vocabulary_Main.TabIndex = 2;
            // 
            // lbl_Word
            // 
            this.lbl_Word.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Word.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Word.Location = new System.Drawing.Point(0, 0);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(270, 28);
            this.lbl_Word.TabIndex = 2;
            this.lbl_Word.Text = "New Word";
            this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_Vocabulary_Right
            // 
            this.panel_Vocabulary_Right.Controls.Add(this.btnAPI);
            this.panel_Vocabulary_Right.Controls.Add(this.lbl_loudspeaker);
            this.panel_Vocabulary_Right.Controls.Add(this.lbl_API);
            this.panel_Vocabulary_Right.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Vocabulary_Right.Location = new System.Drawing.Point(0, 31);
            this.panel_Vocabulary_Right.Name = "panel_Vocabulary_Right";
            this.panel_Vocabulary_Right.Size = new System.Drawing.Size(270, 25);
            this.panel_Vocabulary_Right.TabIndex = 1;
            // 
            // btnAPI
            // 
            this.btnAPI.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPI.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.btnAPI.Appearance.Options.UseFont = true;
            this.btnAPI.Appearance.Options.UseForeColor = true;
            this.btnAPI.Location = new System.Drawing.Point(87, 2);
            this.btnAPI.Name = "btnAPI";
            this.btnAPI.Size = new System.Drawing.Size(75, 23);
            this.btnAPI.TabIndex = 3;
            this.btnAPI.Text = "API";
            this.btnAPI.Click += new System.EventHandler(this.btnAPI_Click);
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
            this.lbl_API.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_API.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.lbl_API.Location = new System.Drawing.Point(38, 2);
            this.lbl_API.Name = "lbl_API";
            this.lbl_API.Size = new System.Drawing.Size(187, 23);
            this.lbl_API.TabIndex = 1;
            this.lbl_API.Text = "API";
            this.lbl_API.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_API.Visible = false;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel1);
            this.panel_Main.Controls.Add(this.panel_Explan);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(5, 86);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(270, 157);
            this.panel_Main.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memoEdit_Example);
            this.panel1.Controls.Add(this.lbl_Example);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 62);
            this.panel1.TabIndex = 5;
            // 
            // memoEdit_Example
            // 
            this.memoEdit_Example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit_Example.EditValue = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" +
    "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.memoEdit_Example.Location = new System.Drawing.Point(0, 15);
            this.memoEdit_Example.Name = "memoEdit_Example";
            this.memoEdit_Example.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit_Example.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.memoEdit_Example.Properties.Appearance.Options.UseFont = true;
            this.memoEdit_Example.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit_Example.Size = new System.Drawing.Size(270, 47);
            this.memoEdit_Example.TabIndex = 4;
            this.memoEdit_Example.Visible = false;
            this.memoEdit_Example.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoEdit_Example_MouseUp);
            // 
            // lbl_Example
            // 
            this.lbl_Example.AutoSize = true;
            this.lbl_Example.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Example.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Example.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_Example.Location = new System.Drawing.Point(0, 0);
            this.lbl_Example.Name = "lbl_Example";
            this.lbl_Example.Size = new System.Drawing.Size(58, 15);
            this.lbl_Example.TabIndex = 2;
            this.lbl_Example.Text = "Example:";
            this.lbl_Example.Visible = false;
            // 
            // panel_Explan
            // 
            this.panel_Explan.Controls.Add(this.btnExplain);
            this.panel_Explan.Controls.Add(this.memoEdit_Explain);
            this.panel_Explan.Controls.Add(this.lbl_Explain);
            this.panel_Explan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Explan.Location = new System.Drawing.Point(0, 0);
            this.panel_Explan.Name = "panel_Explan";
            this.panel_Explan.Size = new System.Drawing.Size(270, 95);
            this.panel_Explan.TabIndex = 4;
            // 
            // btnExplain
            // 
            this.btnExplain.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplain.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.btnExplain.Appearance.Options.UseFont = true;
            this.btnExplain.Appearance.Options.UseForeColor = true;
            this.btnExplain.Location = new System.Drawing.Point(87, 72);
            this.btnExplain.Name = "btnExplain";
            this.btnExplain.Size = new System.Drawing.Size(75, 23);
            this.btnExplain.TabIndex = 3;
            this.btnExplain.Text = "Explain";
            this.btnExplain.Click += new System.EventHandler(this.BtnExplain_Click);
            // 
            // memoEdit_Explain
            // 
            this.memoEdit_Explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit_Explain.EditValue = resources.GetString("memoEdit_Explain.EditValue");
            this.memoEdit_Explain.Location = new System.Drawing.Point(0, 15);
            this.memoEdit_Explain.Name = "memoEdit_Explain";
            this.memoEdit_Explain.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit_Explain.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.memoEdit_Explain.Properties.Appearance.Options.UseFont = true;
            this.memoEdit_Explain.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit_Explain.Size = new System.Drawing.Size(270, 80);
            this.memoEdit_Explain.TabIndex = 2;
            this.memoEdit_Explain.Visible = false;
            this.memoEdit_Explain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoEdit_Explain_MouseUp);
            // 
            // lbl_Explain
            // 
            this.lbl_Explain.AutoSize = true;
            this.lbl_Explain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Explain.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Explain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_Explain.Location = new System.Drawing.Point(0, 0);
            this.lbl_Explain.Name = "lbl_Explain";
            this.lbl_Explain.Size = new System.Drawing.Size(52, 15);
            this.lbl_Explain.TabIndex = 0;
            this.lbl_Explain.Text = "Explain:";
            this.lbl_Explain.Visible = false;
            // 
            // Form_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 273);
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
            this.panelBottom.ResumeLayout(false);
            this.panel_Vocabulary.ResumeLayout(false);
            this.panel_Vocabulary_Main.ResumeLayout(false);
            this.panel_Vocabulary_Right.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Example.Properties)).EndInit();
            this.panel_Explan.ResumeLayout(false);
            this.panel_Explan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Explain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Vocabulary;
        private System.Windows.Forms.Panel panel_Vocabulary_Main;
        
        private System.Windows.Forms.Label lbl_FiveDays;
        private System.Windows.Forms.Label lbl_OneDay;
        private System.Windows.Forms.Label lbl_TenMinute;
        private System.Windows.Forms.Label lbl_OneMinute;
        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_DocBottom;
        private System.Windows.Forms.Label lbl_ThirtyMinute;
        private DevExpress.XtraEditors.SimpleButton btnAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.Panel panel_Vocabulary_Right;
        private System.Windows.Forms.Label lbl_loudspeaker;
        private System.Windows.Forms.Label lbl_Example;
        private System.Windows.Forms.Label lbl_Explain;
        private System.Windows.Forms.Panel panel_Explan;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Explain;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Example;
        private DevExpress.XtraEditors.SimpleButton btnExplain;
        private System.Windows.Forms.Label lbl_API;
    }
}

