using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Victory : Form
    {
        int counter = 0;
        string PlayerName = File.ReadAllText(@"..\..\..\DATA\PlayerName.txt");
        public Victory()
        {
            InitializeComponent();
            txt_TheEnd.Hide();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                DialogueBox.Text = " VICTORY!!! You have defeated the slime";
            }
            else if (counter == 1)
            {
                DialogueBox.Text = "Gresill > Not bad mortal, for a weakling like you, not bad\r\n";
            }
            else if (counter == 2)
            {
                DialogueBox.Text = "Gresill > Maybe, we’ll see…\r\n";
            }
            else if (counter == 3)
            {
                txt_Victory.Hide();
                DialoguePanel.Hide();
                txt_TheEnd.Show();

            }
            counter++;
        }

        private void end_panel_MouseClick(object sender, MouseEventArgs e)
        {
            string TryAgain = "1";
            File.WriteAllText(@"..\..\..\DATA\TryAgain.txt", TryAgain);
            Start ST = new();
            this.Hide();
            ST.ShowDialog();
            this.Close();
        }


    }
}
