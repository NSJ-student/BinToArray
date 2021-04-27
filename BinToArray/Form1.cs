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
        WorkArg userArg;

        public BinToArray()
        {
            InitializeComponent();

            progressLoad.Visible = false;
            progressLoad.Location = tbLoadPath.Location;
            progressLoad.Size = tbLoadPath.Size;

            userArg = new WorkArg();

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
            WorkArg args = (WorkArg)arg.Argument;
            string FilePath = (string)args.fileName;

            FileStream file = File.OpenRead(FilePath);
            BinaryReader reader = new BinaryReader(file);

            string temp = "";
            uint read = 0;
            int pos = 0;
            int byteCnt = (args.showBit / 8);

            while (reader.BaseStream.Length - reader.BaseStream.Position >= byteCnt)
            {
                if(args.showBit == 8)
                {
                    read = reader.ReadByte();
                }
                else if(args.showBit == 16)
                {
                    read = reader.ReadUInt16();
                }
                else if(args.showBit == 32)
                {
                    read = reader.ReadUInt32();
                }

                if(args.isDec)
                {
                    if (args.showBit == 8)
                    {
                        temp += String.Format("{0,3}, ", read);
                    }
                    else if (args.showBit == 16)
                    {
                        temp += String.Format("{0,5}, ", read);
                    }
                    else if (args.showBit == 32)
                    {
                        temp += String.Format("{0,10}, ", read);
                    }
                }
                else
                {
                    if (args.showBit == 8)
                    {
                        temp += "0x" + read.ToString("X2") + ", ";
                    }
                    else if (args.showBit == 16)
                    {
                        temp += "0x" + read.ToString("X4") + ", ";
                    }
                    else if (args.showBit == 32)
                    {
                        temp += "0x" + read.ToString("X8") + ", ";
                    }
                }

                pos++;
                if (pos == args.colCount)
                {
                    pos = 0;
                    temp += "\n";
                    LoadWorker.ReportProgress((int)(reader.BaseStream.Position * 100 / reader.BaseStream.Length));
                }
            }

            reader.Close();
            file.Close();

            arg.Result = temp;
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

                if(!userArg.setProperty(open_dialog.FileName, get_isDec(), get_showBit(), (int)numColCount.Value))
                {
                    return;
                }

                LoadWorker.RunWorkerAsync(userArg);
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

        private bool get_isDec()
        {
            if(rbDec8bit.Checked || rbDec16bit.Checked || rbDec32bit.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int get_showBit()
        {
            if (rbDec8bit.Checked || rbHex8bit.Checked)
            {
                return 8;
            }
            else if(rbDec16bit.Checked || rbHex16bit.Checked)
            {
                return 16;
            }
            else if(rbDec32bit.Checked || rbHex32bit.Checked)
            {
                return 32;
            }
            else
            {
                return 0;
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            if(tbLoadPath.Text == "")
            {
                return;
            }

            progressLoad.Visible = true;
            btnLoad.Enabled = false;
            btnSave.Enabled = false;

            if (!userArg.setProperty(tbLoadPath.Text, get_isDec(), get_showBit(), (int)numColCount.Value))
            {
                return;
            }

            LoadWorker.RunWorkerAsync(userArg);
        }
    }

    public class WorkArg
    {
        string _fileName;
        bool _isDec;
        int _showBit;
        int _colCount;

        public WorkArg()
        {
            _isDec = false;
            _showBit = 8;
            _colCount = 8;
        }
        public string fileName
        {
            get { return _fileName; }
        }
        public bool isDec
        {
            get { return _isDec; }
        }
        public int showBit
        {
            get { return _showBit; }
        }
        public int colCount
        {
            get { return _colCount; }
        }
        public bool setProperty(string name, bool dec, int bit, int column)
        {
            _fileName = name;
            _isDec = dec;
            _colCount = column;
            if ((bit == 8) || (bit == 16) || (bit == 32))
            {
                _showBit = bit;
                return true;
            }
            else
            {
                _showBit = 0;
                return false;
            }
        }
    }

}
