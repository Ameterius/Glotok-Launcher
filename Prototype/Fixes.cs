using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Glotok
{
    public partial class Fixes : Form
    {
        public Fixes()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Fixes_Closing);
        }
        public void Fixes_Closing(object sender, FormClosingEventArgs e)
        {
            Main form2 = new Main();
            this.Hide();
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog();
            this.Close();
        }
    }
}
