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
    public partial class frmConvertPDFtoPNG : Form
    {
        List<string> listFiles = new List<string>();
        public frmConvertPDFtoPNG()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            lstView.Items.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            foreach(string item in Directory.GetFiles(txtSaveFile.Text))
            {
                lstImage.Images.Add(Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFiles.Add(fi.FullName);
                lstView.Items.Add(fi.Name, lstImage.Images.Count - 1);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            { 
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSaveFile.Text = fbd.SelectedPath;
                }    
                
            }
           
        }
    }
}
