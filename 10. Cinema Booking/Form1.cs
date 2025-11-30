using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Cinema_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            Movie myMovie = new Ticket(textBoxMovie.Text, textBoxGenre.Text, textBoxSeat.Text, numericUpDownPrice.Value);

            MessageBox.Show(myMovie.ShowDetails(), "Movie Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
