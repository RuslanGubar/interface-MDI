using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_8_часть_2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            noteForm Note = new noteForm(); 
            Note.MdiParent = this;
            Note.NewNote();
            Note.Show();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            noteForm Note = new noteForm(); 
            Note.MdiParent = this; 
            if (Note.OpenNote()) 
            {
                Note.Show(); 
            }
            else
                Note = null;
        }

        private void tsmiOrder_Click(object sender, EventArgs e)
        {

        }

        // 3 задание

        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        
    }
}
