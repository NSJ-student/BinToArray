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

        public BinToArray()
        {
            InitializeComponent();

            open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Bin Files(*.bin)|*.bin";
            save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files(*.txt)|*.txt";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == open_dialog.ShowDialog())
            {
                tbLoadPath.Text = open_dialog.FileName;

                FileStream file = File.OpenRead(open_dialog.FileName);
                BinaryReader reader = new BinaryReader(file);
                
                string temp = "";
                int read = 0;
                int pos = 0;

                while(reader.BaseStream.Length - reader.BaseStream.Position >= 4)
                {
                    read = reader.ReadInt32();
                    temp += "0x" + read.ToString("X") + ", ";
                    pos++;
                    if(pos == 4)
                    {
                        pos = 0;
                        temp += "\n";
                    }
                }
                rtbArrayText.Text = temp;

                reader.Close();
                file.Close();
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
