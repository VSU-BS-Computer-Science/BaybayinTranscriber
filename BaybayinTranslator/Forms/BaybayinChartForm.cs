using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace BaybayinTranslator.Forms
{
    public partial class BaybayinChartForm : Form
    {
        public BaybayinChartForm()
        {
            InitializeComponent();

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("BaybayinTranslator.images.baybayin2.bmp");
            pictureBox1.Image = new Bitmap(myStream);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
