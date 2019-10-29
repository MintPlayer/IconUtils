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

namespace temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<byte> data = null;
        private async void OpenFile(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();

                const int buf_size = 65536;
                var buffer = new byte[buf_size]; var bytes_read = 0;
                data = new List<byte>();
                using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    while (bytes_read < fs.Length)
                    {
                        var read = await fs.ReadAsync(buffer, 0, buf_size);
                        data.AddRange(buffer);
                        bytes_read += read;
                    }
                }

                for (int i = 0; i < data.Count; i+=8)
                {
                    var lvi = new ListViewItem(i.ToString());
                    for (int j = i; j < i + 8; j++)
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, data[j].ToString()));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void NewWindow(object sender, EventArgs e)
        {
            var window = new Form1();
            window.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ReferenceEquals(this, Program.MainForm))
            {
                if (MessageBox.Show(this, "This is the mainform. Closing this form will close the entire application. Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
