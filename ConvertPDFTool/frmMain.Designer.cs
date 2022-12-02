
namespace ConvertPDFTool
{
    partial class frmMain
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertPDFtoPNG = new System.Windows.Forms.Button();
            this.btnSplitPDF = new System.Windows.Forms.Button();
            this.btnMergePDF = new System.Windows.Forms.Button();
            this.btnConvertIMGtoPDF = new System.Windows.Forms.Button();
            this.btnOCRPDF = new System.Windows.Forms.Button();
            this.btnZipPDF = new System.Windows.Forms.Button();
            this.btnConvertPDFtoJPG = new System.Windows.Forms.Button();
            this.materialContextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClose});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // mnClose
            // 
            this.mnClose.Name = "mnClose";
            this.mnClose.Size = new System.Drawing.Size(104, 22);
            this.mnClose.Text = "Thoát";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "copyright © DONPV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin vui lòng lựa chọn công cụ hữu ích với bạn";
            // 
            // btnConvertPDFtoPNG
            // 
            this.btnConvertPDFtoPNG.Location = new System.Drawing.Point(23, 94);
            this.btnConvertPDFtoPNG.Name = "btnConvertPDFtoPNG";
            this.btnConvertPDFtoPNG.Size = new System.Drawing.Size(183, 77);
            this.btnConvertPDFtoPNG.TabIndex = 3;
            this.btnConvertPDFtoPNG.Text = "Chuyển PDF sang PNG";
            this.btnConvertPDFtoPNG.UseVisualStyleBackColor = true;
            this.btnConvertPDFtoPNG.Click += new System.EventHandler(this.btnConvertPDFtoPNG_Click);
            // 
            // btnSplitPDF
            // 
            this.btnSplitPDF.Location = new System.Drawing.Point(282, 94);
            this.btnSplitPDF.Name = "btnSplitPDF";
            this.btnSplitPDF.Size = new System.Drawing.Size(183, 77);
            this.btnSplitPDF.TabIndex = 4;
            this.btnSplitPDF.Text = "Tách nhỏ File PDF";
            this.btnSplitPDF.UseVisualStyleBackColor = true;
            this.btnSplitPDF.Click += new System.EventHandler(this.btnSplitPDF_Click);
            // 
            // btnMergePDF
            // 
            this.btnMergePDF.Location = new System.Drawing.Point(557, 94);
            this.btnMergePDF.Name = "btnMergePDF";
            this.btnMergePDF.Size = new System.Drawing.Size(183, 77);
            this.btnMergePDF.TabIndex = 5;
            this.btnMergePDF.Text = "Ghép File PDF";
            this.btnMergePDF.UseVisualStyleBackColor = true;
            this.btnMergePDF.Click += new System.EventHandler(this.btnMergePDF_Click);
            // 
            // btnConvertIMGtoPDF
            // 
            this.btnConvertIMGtoPDF.Location = new System.Drawing.Point(23, 248);
            this.btnConvertIMGtoPDF.Name = "btnConvertIMGtoPDF";
            this.btnConvertIMGtoPDF.Size = new System.Drawing.Size(183, 77);
            this.btnConvertIMGtoPDF.TabIndex = 6;
            this.btnConvertIMGtoPDF.Text = "Chuyển ảnh sang PDF";
            this.btnConvertIMGtoPDF.UseVisualStyleBackColor = true;
            this.btnConvertIMGtoPDF.Click += new System.EventHandler(this.btnConvertIMGtoPDF_Click);
            // 
            // btnOCRPDF
            // 
            this.btnOCRPDF.Location = new System.Drawing.Point(282, 248);
            this.btnOCRPDF.Name = "btnOCRPDF";
            this.btnOCRPDF.Size = new System.Drawing.Size(183, 77);
            this.btnOCRPDF.TabIndex = 7;
            this.btnOCRPDF.Text = "OCR PDF";
            this.btnOCRPDF.UseVisualStyleBackColor = true;
            this.btnOCRPDF.Click += new System.EventHandler(this.btnOCRPDF_Click);
            // 
            // btnZipPDF
            // 
            this.btnZipPDF.Location = new System.Drawing.Point(557, 248);
            this.btnZipPDF.Name = "btnZipPDF";
            this.btnZipPDF.Size = new System.Drawing.Size(183, 77);
            this.btnZipPDF.TabIndex = 8;
            this.btnZipPDF.Text = "Nén file PDF";
            this.btnZipPDF.UseVisualStyleBackColor = true;
            this.btnZipPDF.Click += new System.EventHandler(this.btnZipPDF_Click);
            // 
            // btnConvertPDFtoJPG
            // 
            this.btnConvertPDFtoJPG.Location = new System.Drawing.Point(282, 377);
            this.btnConvertPDFtoJPG.Name = "btnConvertPDFtoJPG";
            this.btnConvertPDFtoJPG.Size = new System.Drawing.Size(183, 77);
            this.btnConvertPDFtoJPG.TabIndex = 9;
            this.btnConvertPDFtoJPG.Text = "Chuyển PDF sang JPG";
            this.btnConvertPDFtoJPG.UseVisualStyleBackColor = true;
            this.btnConvertPDFtoJPG.Click += new System.EventHandler(this.btnConvertPDFtoJPG_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnConvertPDFtoJPG);
            this.Controls.Add(this.btnZipPDF);
            this.Controls.Add(this.btnOCRPDF);
            this.Controls.Add(this.btnConvertIMGtoPDF);
            this.Controls.Add(this.btnMergePDF);
            this.Controls.Add(this.btnSplitPDF);
            this.Controls.Add(this.btnConvertPDFtoPNG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "Tổng hợp công cụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertPDFtoPNG;
        private System.Windows.Forms.Button btnSplitPDF;
        private System.Windows.Forms.Button btnMergePDF;
        private System.Windows.Forms.Button btnConvertIMGtoPDF;
        private System.Windows.Forms.Button btnOCRPDF;
        private System.Windows.Forms.Button btnZipPDF;
        private System.Windows.Forms.Button btnConvertPDFtoJPG;
    }
}