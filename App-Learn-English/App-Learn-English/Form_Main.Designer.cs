
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel_Vocabulary = new System.Windows.Forms.Panel();
            this.panel_Vocabulary_Main = new System.Windows.Forms.Panel();
            this.panel_Vocabulary_Right = new System.Windows.Forms.Panel();
            this.panel_Vocabulary_Left = new System.Windows.Forms.Panel();
            this.panel_Explain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel_Vocabulary.SuspendLayout();
            this.panel_Vocabulary_Main.SuspendLayout();
            this.panel_Explain.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(280, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 250);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 250);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(280, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 250);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.lbl_Minimize);
            this.panel_Top.Controls.Add(this.lbl_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(280, 25);
            this.panel_Top.TabIndex = 4;
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Minimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Minimize.Location = new System.Drawing.Point(210, 0);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(35, 25);
            this.lbl_Minimize.TabIndex = 1;
            this.lbl_Minimize.Text = "-";
            this.lbl_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Close
            // 
            this.lbl_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Close.Location = new System.Drawing.Point(245, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(35, 25);
            this.lbl_Close.TabIndex = 0;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 225);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(280, 25);
            this.panelBottom.TabIndex = 9;
            // 
            // panel_Vocabulary
            // 
            this.panel_Vocabulary.Controls.Add(this.panel_Vocabulary_Main);
            this.panel_Vocabulary.Controls.Add(this.panel_Vocabulary_Right);
            this.panel_Vocabulary.Controls.Add(this.panel_Vocabulary_Left);
            this.panel_Vocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Vocabulary.Location = new System.Drawing.Point(0, 25);
            this.panel_Vocabulary.Name = "panel_Vocabulary";
            this.panel_Vocabulary.Size = new System.Drawing.Size(280, 77);
            this.panel_Vocabulary.TabIndex = 10;
            // 
            // panel_Vocabulary_Main
            // 
            this.panel_Vocabulary_Main.Controls.Add(this.label5);
            this.panel_Vocabulary_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Vocabulary_Main.Location = new System.Drawing.Point(40, 0);
            this.panel_Vocabulary_Main.Name = "panel_Vocabulary_Main";
            this.panel_Vocabulary_Main.Size = new System.Drawing.Size(200, 77);
            this.panel_Vocabulary_Main.TabIndex = 2;
            // 
            // panel_Vocabulary_Right
            // 
            this.panel_Vocabulary_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Vocabulary_Right.Location = new System.Drawing.Point(240, 0);
            this.panel_Vocabulary_Right.Name = "panel_Vocabulary_Right";
            this.panel_Vocabulary_Right.Size = new System.Drawing.Size(40, 77);
            this.panel_Vocabulary_Right.TabIndex = 1;
            // 
            // panel_Vocabulary_Left
            // 
            this.panel_Vocabulary_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Vocabulary_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Vocabulary_Left.Name = "panel_Vocabulary_Left";
            this.panel_Vocabulary_Left.Size = new System.Drawing.Size(40, 77);
            this.panel_Vocabulary_Left.TabIndex = 0;
            // 
            // panel_Explain
            // 
            this.panel_Explain.Controls.Add(this.label6);
            this.panel_Explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Explain.Location = new System.Drawing.Point(0, 102);
            this.panel_Explain.Name = "panel_Explain";
            this.panel_Explain.Size = new System.Drawing.Size(280, 123);
            this.panel_Explain.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "5 Ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "1 Phút";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(70, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "10 Phút";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(140, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "1 Ngày";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 16.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 77);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Vocabulary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 123);
            this.label6.TabIndex = 0;
            this.label6.Text = "Explain";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 250);
            this.Controls.Add(this.panel_Explain);
            this.Controls.Add(this.panel_Vocabulary);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panel_Vocabulary.ResumeLayout(false);
            this.panel_Vocabulary_Main.ResumeLayout(false);
            this.panel_Explain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel_Explain;
        private System.Windows.Forms.Panel panel_Vocabulary;
        private System.Windows.Forms.Panel panel_Vocabulary_Main;
        private System.Windows.Forms.Panel panel_Vocabulary_Right;
        private System.Windows.Forms.Panel panel_Vocabulary_Left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

