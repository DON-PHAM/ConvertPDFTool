﻿
namespace ConvertPDFTool
{
    partial class frmConvertPDF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChooseFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnChooseFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaveFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConvert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.lstView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Depth = 0;
            this.txtChooseFile.Hint = "";
            this.txtChooseFile.Location = new System.Drawing.Point(87, 82);
            this.txtChooseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.PasswordChar = '\0';
            this.txtChooseFile.SelectedText = "";
            this.txtChooseFile.SelectionLength = 0;
            this.txtChooseFile.SelectionStart = 0;
            this.txtChooseFile.Size = new System.Drawing.Size(577, 23);
            this.txtChooseFile.TabIndex = 0;
            this.txtChooseFile.UseSystemPasswordChar = false;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Depth = 0;
            this.btnChooseFile.Location = new System.Drawing.Point(589, 82);
            this.btnChooseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Primary = true;
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Brower";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(6, 140);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Nơi lưu ";
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Depth = 0;
            this.txtSaveFile.Hint = "";
            this.txtSaveFile.Location = new System.Drawing.Point(87, 140);
            this.txtSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.PasswordChar = '\0';
            this.txtSaveFile.SelectedText = "";
            this.txtSaveFile.SelectionLength = 0;
            this.txtSaveFile.SelectionStart = 0;
            this.txtSaveFile.Size = new System.Drawing.Size(577, 23);
            this.txtSaveFile.TabIndex = 3;
            this.txtSaveFile.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(589, 136);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Brower";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Depth = 0;
            this.btnConvert.Location = new System.Drawing.Point(514, 183);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Primary = true;
            this.btnConvert.Size = new System.Drawing.Size(150, 34);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Bắt đầu Cut";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Chọn PDF";
            // 
            // processBar
            // 
            this.processBar.Location = new System.Drawing.Point(514, 233);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(151, 18);
            this.processBar.TabIndex = 7;
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 15;
            this.lstView.Items.AddRange(new object[] {
            " "});
            this.lstView.Location = new System.Drawing.Point(19, 183);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(489, 304);
            this.lstView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(97, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cắt PDF thành từng trang nhỏ";
            // 
            // frmConvertPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtChooseFile);
            this.Name = "frmConvertPDF";
            this.Text = "Convert PDF Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConvertPDF_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtChooseFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnChooseFile;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaveFile;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnConvert;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ProgressBar processBar;
        private System.Windows.Forms.Label lbProcessBar;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Label label1;
    }
}

