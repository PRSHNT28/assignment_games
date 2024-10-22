using System.Windows.Forms;

namespace tic_tac_2
{
    public partial class Form1 : Form
    {
        private user t;
        public Form1()
        {

            InitializeComponent();
            t = new user();
            t.Visible = true;
            this.Controls.Add(t);
        }
    }
}
