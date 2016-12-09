using System;
using System.Windows.Forms;

namespace BuffaloBurgers_WForm
{
    public partial class MainForm : Form
    {
        int spacer = 0;
        int Count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BeginOrder_Click(object sender, EventArgs e)
        {
            Count++;
            CustomerOrderForm orderForm = new CustomerOrderForm(Count);
            orderForm.Show();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            spacer++;
            if (spacer > 15) spacer = 0;
            string output = "Touch Screen to Begin";

            for (int x = 0; x < spacer; x++)
            {
                output = " " + output;
            }
                WelcomeBeginLbl.Text = output;
        }
    }
}
