
namespace ConvertPDFTool
{
    partial class frmConvertPDFtoPNG
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
            this.txtFilePDF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnChooseFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaveFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lstImage = new System.Windows.Forms.ImageList(this.components);
            this.lstView = new System.Windows.Forms.ListView();
            this.btnConvert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtFilePDF
            // 
            this.txtFilePDF.Depth = 0;
            this.txtFilePDF.Hint = "";
            this.txtFilePDF.Location = new System.Drawing.Point(58, 12);
            this.txtFilePDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFilePDF.Name = "txtFilePDF";
            this.txtFilePDF.PasswordChar = '\0';
            this.txtFilePDF.SelectedText = "";
            this.txtFilePDF.SelectionLength = 0;
            this.txtFilePDF.SelectionStart = 0;
            this.txtFilePDF.Size = new System.Drawing.Size(665, 23);
            this.txtFilePDF.TabIndex = 0;
            this.txtFilePDF.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Chọn file";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Depth = 0;
            this.btnChooseFile.Location = new System.Drawing.Point(713, 12);
            this.btnChooseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Primary = true;
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Brower";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 60);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Vị trí lưu";
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Depth = 0;
            this.txtSaveFile.Hint = "";
            this.txtSaveFile.Location = new System.Drawing.Point(87, 60);
            this.txtSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.PasswordChar = '\0';
            this.txtSaveFile.SelectedText = "";
            this.txtSaveFile.SelectionLength = 0;
            this.txtSaveFile.SelectionStart = 0;
            this.txtSaveFile.Size = new System.Drawing.Size(636, 23);
            this.txtSaveFile.TabIndex = 4;
            this.txtSaveFile.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(713, 60);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Brower";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lstImage
            // 
            this.lstImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.lstImage.ImageSize = new System.Drawing.Size(16, 16);
            this.lstImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstView
            // 
            this.lstView.HideSelection = false;
            this.lstView.LargeImageList = this.lstImage;
            this.lstView.Location = new System.Drawing.Point(15, 113);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(653, 300);
            this.lstView.TabIndex = 6;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Depth = 0;
            this.btnConvert.Location = new System.Drawing.Point(685, 114);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Primary = true;
            this.btnConvert.Size = new System.Drawing.Size(103, 35);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // processBar
            // 
            this.processBar.Location = new System.Drawing.Point(688, 154);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(100, 23);
            this.processBar.TabIndex = 8;
            // 
            // frmConvertPDFtoPNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtFilePDF);
            this.Name = "frmConvertPDFtoPNG";
            this.Text = "frmConvertPDFtoPNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtFilePDF;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnChooseFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaveFile;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ImageList lstImage;
        private System.Windows.Forms.ListView lstView;
        private MaterialSkin.Controls.MaterialRaisedButton btnConvert;
        private System.Windows.Forms.ProgressBar processBar;
    }
}