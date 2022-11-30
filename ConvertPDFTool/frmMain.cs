using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertPDFTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSplitPDF_Click(object sender, EventArgs e)
        {
            using (var frm = new frmConvertPDF())
            {
                frm.ShowDialog();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertPDFtoPNG_Click(object sender, EventArgs e)
        {
            using (var frm = new frmConvertPDFtoPNG())
            {
                frm.ShowDialog();
            }
        }

        private void btnMergePDF_Click(object sender, EventArgs e)
        {
            using (var frm = new frmMergePDF())
            {
                frm.ShowDialog();
            }
        }

        private void btnOCRPDF_Click(object sender, EventArgs e)
        {
            using (var frm = new OCRPDF())
            {
                frm.ShowDialog();
            }
        }

        private void btnConvertPDFtoJPG_Click(object sender, EventArgs e)
        {
            using (var frm = new frmConvertPDFtoJPG())
            {
                frm.ShowDialog();
            }
        }

        private void btnZipPDF_Click(object sender, EventArgs e)
        {
            using (var frm = new frmZipPDF())
            {
                frm.ShowDialog();
            }
        }

        private void btnConvertIMGtoPDF_Click(object sender, EventArgs e)
        {
            using (var frm = new frmConvertIMGtoPDF())
            {
                frm.ShowDialog();
            }
        }
    }
}
