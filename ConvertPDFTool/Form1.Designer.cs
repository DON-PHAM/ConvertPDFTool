
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
            this.SuspendLayout();
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Depth = 0;
            this.txtChooseFile.Hint = "";
            this.txtChooseFile.Location = new System.Drawing.Point(80, 25);
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
            this.btnChooseFile.Location = new System.Drawing.Point(582, 25);
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
            this.lbName.Location = new System.Drawing.Point(12, 83);
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
            this.txtSaveFile.Location = new System.Drawing.Point(80, 83);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(582, 79);
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
            this.btnConvert.Location = new System.Drawing.Point(507, 126);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Primary = true;
            this.btnConvert.Size = new System.Drawing.Size(150, 34);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-1, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Chọn PDF";
            // 
            // frmConvertPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtChooseFile);
            this.Name = "frmConvertPDF";
            this.Text = "Convert PDF Tool";
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
    }
}

