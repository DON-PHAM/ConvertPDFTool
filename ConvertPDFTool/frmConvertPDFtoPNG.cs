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
        private bool isProcessRunning = false;
        List<string> listFiles = new List<string>();
        public frmConvertPDFtoPNG()
        {
            InitializeComponent();
            lbPercent.Text = "";
            txtFilePDF.Enabled = false;
            txtSaveFile.Enabled = false;
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

            if (Path.GetExtension(txtFilePDF.Text).ToLower() != ".pdf")
                return;
            if (isProcessRunning)
                return;
            ProgressDialog progressBar = new ProgressDialog();

            Thread th = new Thread(new ThreadStart(() =>
            {
                isProcessRunning = true;
                //Đăng ký bản quyền
                new Aspose.Pdf.License().SetLicense(Helper.License.LStream);
                Resolution resolution = new Resolution(300);
                PngDevice pnDevice = new PngDevice(resolution);
                Document document = new Document(txtFilePDF.Text);
                var pathFile = txtSaveFile.Text;
                var name = Path.GetFileNameWithoutExtension(txtFilePDF.Text);

                //processBar.Minimum = 0;
                //processBar.Maximum = document.Pages.Count;
                for (int pageCount = 1; pageCount <= document.Pages.Count; pageCount++)
                {
                    var path = $"{pathFile}/{name}_{pageCount}.png";
                    using (FileStream imageStream = new FileStream(path, FileMode.Create))
                    {
                        // Convert a particular page and save the image to stream
                        pnDevice.Process(document.Pages[pageCount], imageStream);
                        //processBar.Value = pageCount;
                        // Close stream
                        imageStream.Close();
                        lstImage.Images.Add(Icon.ExtractAssociatedIcon(path));
                        FileInfo fi = new FileInfo(path);
                        listFiles.Add(fi.FullName);
                        //lstView.Items.Add(fi.Name, lstImage.Images.Count - 1);

                    }
                    Thread.Sleep(2);
                    if(pageCount < 100) {
                        progressBar.UpdateProgress(pageCount);
                    }
                    
                }
                isProcessRunning = false;
            }));
            th.Start();
            progressBar.ShowDialog();
            progressBar.Close();
            MessageBox.Show("Chuyển đổi thành công", "Thông báo");
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

        private void loading()
        {
            for (int i = 0; i < 100; i++)
            {
                if (processBar.InvokeRequired)
                    processBar.Invoke(new Action(loading));
                else
                    processBar.Value = i;
            }
        }
    }
}
