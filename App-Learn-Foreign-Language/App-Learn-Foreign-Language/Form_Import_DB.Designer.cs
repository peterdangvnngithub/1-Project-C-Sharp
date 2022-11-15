
namespace App_Learn_English
{
    partial class Form_Import_DB
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
            this.lbl_Close = new System.Windows.Forms.Label();
            this.panel_Explain = new System.Windows.Forms.Panel();
            this.lbl_Import_Data_Input = new System.Windows.Forms.Label();
            this.lbl_DocBottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.panel_Top.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(241, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 119);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(241, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 119);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(241, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 119);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.lbl_DocBottom);
            this.panel_Top.Controls.Add(this.lbl_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(241, 25);
            this.panel_Top.TabIndex = 4;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseUp);
            // 
            // lbl_Close
            // 
            this.lbl_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_Close.Location = new System.Drawing.Point(206, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(35, 25);
            this.lbl_Close.TabIndex = 0;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            // 
            // panel_Explain
            // 
            this.panel_Explain.Controls.Add(this.lbl_Import_Data_Input);
            this.panel_Explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Explain.Location = new System.Drawing.Point(0, 25);
            this.panel_Explain.Name = "panel_Explain";
            this.panel_Explain.Size = new System.Drawing.Size(241, 94);
            this.panel_Explain.TabIndex = 11;
            // 
            // lbl_Import_Data_Input
            // 
            this.lbl_Import_Data_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Import_Data_Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Import_Data_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(127)))), ((int)(((byte)(59)))));
            this.lbl_Import_Data_Input.Location = new System.Drawing.Point(0, 0);
            this.lbl_Import_Data_Input.Name = "lbl_Import_Data_Input";
            this.lbl_Import_Data_Input.Size = new System.Drawing.Size(241, 94);
            this.lbl_Import_Data_Input.TabIndex = 0;
            this.lbl_Import_Data_Input.Text = "Import File Data";
            this.lbl_Import_Data_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Import_Data_Input.Click += new System.EventHandler(this.lbl_Import_Data_Input_Click);
            // 
            // lbl_DocBottom
            // 
            this.lbl_DocBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_DocBottom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_DocBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(75)))));
            this.lbl_DocBottom.Location = new System.Drawing.Point(171, 0);
            this.lbl_DocBottom.Name = "lbl_DocBottom";
            this.lbl_DocBottom.Size = new System.Drawing.Size(35, 25);
            this.lbl_DocBottom.TabIndex = 1;
            this.lbl_DocBottom.Text = "↓";
            this.lbl_DocBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_DocBottom.Click += new System.EventHandler(this.lbl_DocBottom_Click);
            // 
            // Form_Import_DB
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 119);
            this.Controls.Add(this.panel_Explain);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Import_DB";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.Form_Import_DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.panel_Top.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_Explain;
        private System.Windows.Forms.Label lbl_Import_Data_Input;
        private System.Windows.Forms.Label lbl_DocBottom;
    }
}

