using Aspose.Pdf;
using Aspose.Pdf.Devices;
using ConvertPDFTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertPDFTool
{
    public partial class frmConvertPDFtoPNG : Form
    {
        private Document document;
        private BackgroundWorker bw;
        List<string> listFiles = new List<string>();
        public frmConvertPDFtoPNG()
        {
            InitializeComponent();
            txtFilePDF.Enabled = false;
            txtSaveFile.Enabled = false;
        }

        private void frmConvertPDFtoPNG_Load(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            bw.DoWork += bw_DoWork;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerCompleted += bw_RunworkerCompleted;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            lstView.Items.Clear();
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

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFilePDF.Text = openFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSaveFile.Text = fbd.SelectedPath;
                }

            }
        }
        private void bw_RunworkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Chuyển đổi thành công", "Thông báo");
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processBar.Maximum = document.Pages.Count;
            processBar.Value = e.ProgressPercentage;

            //foreach (string item in Directory.GetFiles(txtSaveFile.Text))
            //{
            //    lstImage.Images.Add(Icon.ExtractAssociatedIcon(item));
            //    FileInfo fi = new FileInfo(item);
            //    listFiles.Add(fi.FullName);
            //    lstView.Items.Add(fi.Name, lstImage.Images.Count - 1);
            //}
            Application.DoEvents();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Path.GetExtension(txtFilePDF.Text).ToLower() != ".pdf")
                return;
            //Đăng ký bản quyền
            new Aspose.Pdf.License().SetLicense(Helper.License.LStream);
            Resolution resolution = new Resolution(300);
            PngDevice pnDevice = new PngDevice(resolution);
            document = new Document(txtFilePDF.Text);
            var pathFile = txtSaveFile.Text;
            var name = Path.GetFileNameWithoutExtension(txtFilePDF.Text);
            ProgressDialog frm = new ProgressDialog();
            
            for (int pageCount = 1; pageCount <= document.Pages.Count; pageCount++)
            {
                if (bw.CancellationPending)
                    break;
                var path = $"{pathFile}/{name}_{pageCount}.png";
                using (FileStream imageStream = new FileStream(path, FileMode.Create))
                {
                    // Convert a particular page and save the image to stream
                    pnDevice.Process(document.Pages[pageCount], imageStream);
                    (sender as BackgroundWorker).ReportProgress(pageCount);
                    // Close stream
                    imageStream.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }
    }
}
