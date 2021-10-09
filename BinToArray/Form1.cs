using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BinToArray
{
    public partial class BinToArray : Form
    {
        OpenFileDialog open_dialog;
        SaveFileDialog save_dialog;
        BackgroundWorker LoadWorker;

        public BinToArray()
        {
            InitializeComponent();

            progressLoad.Visible = false;
            progressLoad.Location = tbLoadPath.Location;
            progressLoad.Size = tbLoadPath.Size;

            open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Bin Files(*.bin)|*.bin";
            save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files(*.txt)|*.txt";

            LoadWorker = new BackgroundWorker();
            LoadWorker.WorkerReportsProgress = true;
            LoadWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MakeComponentsComplete);
            LoadWorker.DoWork += new DoWorkEventHandler(MakeComponents);
            LoadWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);
        }

        private void UpdateProgressBar(object obj, ProgressChangedEventArgs arg)
        {
            progressLoad.Value = arg.ProgressPercentage;
        }

        private void MakeComponents(object obj, DoWorkEventArgs arg)
        {
            string FilePath = (string)arg.Argument;

            FileStream file = File.OpenRead(open_dialog.FileName);
            BinaryReader reader = new BinaryReader(file);

            int lenth = Convert.ToInt32(file.Length);
            StringBuilder builder = new StringBuilder((int)4* lenth);
            int read = 0;
            int pos = 0;

            while (reader.BaseStream.Length - reader.BaseStream.Position >= 4)
            {
                read = reader.ReadInt32();
                builder.Append("0x" + read.ToString("X") + ", ");
                pos++;
                if (pos == 4)
                {
                    pos = 0;
                    builder.Append("\n");
                    LoadWorker.ReportProgress((int)(reader.BaseStream.Position * 100 / reader.BaseStream.Length));
                }
            }

            reader.Close();
            file.Close();

            arg.Result = builder.ToString();
        }

        private void MakeComponentsComplete(object obj, RunWorkerCompletedEventArgs arg)
        {
            rtbArrayText.Text = (string)arg.Result;
            MessageBox.Show("Conversion Complete!");

            btnLoad.Enabled = true;
            btnSave.Enabled = true;
            progressLoad.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == open_dialog.ShowDialog())
            {
                tbLoadPath.Text = open_dialog.FileName;

                progressLoad.Visible = true;
                btnLoad.Enabled = false;
                btnSave.Enabled = false;

                LoadWorker.RunWorkerAsync(open_dialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                tbSavePath.Text = save_dialog.FileName;
                FileStream file = File.Create(save_dialog.FileName);
                StreamWriter writer = new StreamWriter(file);

                writer.Write(rtbArrayText.Text);

                writer.Close();
                file.Close();
            }
        }
    }
}
