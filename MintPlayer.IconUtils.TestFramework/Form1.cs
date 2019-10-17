using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintPlayer.IconUtils.TestFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenIconFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Choose an icon",
                AddExtension = false,
                Filter = "Icon files|*.ico|Executable files|*.exe",
                FilterIndex = 2
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                //var icons = MintPlayer.IconUtils.IconExtractor.Split(ofd.FileName);
                var icons = IconExtractor.Split(ofd.FileName);

                var folder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(ofd.FileName), "Split");
                if (!System.IO.Directory.Exists(folder)) System.IO.Directory.CreateDirectory(folder);
                var index = 1;
                foreach (var icon in icons)
                {
                    var filename = System.IO.Path.Combine(folder, "icon_" + (index++).ToString() + ".ico");
                    using (var fs = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                    {
                        icon.Save(fs);
                    }
                }
            }
        }
    }
}
