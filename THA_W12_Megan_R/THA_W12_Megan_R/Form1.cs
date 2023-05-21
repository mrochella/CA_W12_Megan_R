using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W12_Megan_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADD add;
        UPDATE update;
        DELETE delete;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PeachPuff;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.papapanel.Controls.Clear();
            add = new ADD();
            add.TopLevel = false;
            add.Dock = DockStyle.Fill;
            this.papapanel.Controls.Add(add);
            add.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.papapanel.Controls.Clear();
            update = new UPDATE();
            update.TopLevel = false;
            update.Dock = DockStyle.Fill;
            this.papapanel.Controls.Add(update);
            update.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.papapanel.Controls.Clear();
            delete = new DELETE();
            delete.TopLevel = false;
            delete.Dock = DockStyle.Fill;
            this.papapanel.Controls.Add(delete);
            delete.Show();
        }
    }
}
