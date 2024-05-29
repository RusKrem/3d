using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3d
{
    public partial class AddForm : Form
    {
        public AddForm(string text)
        {
            InitializeComponent();
            this.label1.Text = text;
        }

        private void buttonAddFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
