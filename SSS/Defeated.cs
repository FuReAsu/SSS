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
    public partial class Defeated : Form
    {
        int counter = 0;
        string PlayerName = File.ReadAllText(@"..\..\..\DATA\PlayerName.txt");
        public Defeated()
        {
            InitializeComponent();
            txt_TheEnd.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            if (counter == 0)
            {
                DialogueBox.Text = PlayerName + " > “Ughh… uhh…..”";
            }
            else if (counter == 1)
            {
                DialogueBox.Text = "You collapse to the ground like a rag doll having no more strength to fight \r\n";
            }
            else if (counter == 2)
            {
                DialogueBox.Text = "Gresill > Hmph, so weak and frail. I guess this vessel won’t do anything for me…";
            }
            else if (counter == 3)
            {
                DialoguePanel.Hide();
                txt_TheEnd.Show();
            }
            counter++;

        }

        private void end_panel_MouseClick(object sender, MouseEventArgs e)
        {
            string TryAgain = "1";
            File.WriteAllText(@"..\..\..\DATA\TryAgain.txt", TryAgain);
            Start ST = new Start();
            this.Hide();
            ST.ShowDialog();
            this.Close();
        }
    }
}
