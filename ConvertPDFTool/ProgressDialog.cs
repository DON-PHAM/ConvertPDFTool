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
    public partial class ProgressDialog : Form
    {
        private BackgroundWorker bw;
        public ProgressDialog()
        {
            InitializeComponent();
        }
        private void ProgressDialog_Load(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkCompleted;
            bw.ProgressChanged += bw_ProgressChanged;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            Application.DoEvents();
        }

        private void bw_RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Hoan thanh");
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // neu chon nut ket thuc thi ngung
                if (bw.CancellationPending) break;
                // bao cao tien do
                bw.ReportProgress(i, i);
            }
        }

        public void Run()
        {
            bw.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }
    }
}
