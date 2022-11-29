using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertPDFTool
{
    public partial class frmConvertPDF : Form
    {
        public frmConvertPDF()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Chọn File",
                DefaultExt = "pdf",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "pdf Files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtChooseFile.Text = openFile.FileName;
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using(var folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    txtSaveFile.Text = folder.SelectedPath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(txtChooseFile.Text).ToLower() != ".pdf")
                return;
            new Aspose.Pdf.License().SetLicense(Helper.License.LStream);

            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(txtChooseFile.Text);
            int pageCount = 1;
            foreach (Page pdfPage in pdfDocument.Pages)
            {
                Document newDocument = new Document();
                newDocument.Pages.Add(pdfPage);
                newDocument.Save(txtSaveFile.Text + "/" + "page_" + pageCount + ".pdf");
                pageCount++;
            }

        }
    }
}
