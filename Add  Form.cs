
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
