using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Battle : Form
    {
        int counter = 0;
        string PlayerNameTxt = File.ReadAllText(@"..\..\..\DATA\PlayerName.txt");

        public Battle()
        {
            InitializeComponent();
            bool check = File.Exists(@"..\..\..\DATA\PlayerHP.txt");
            if (check == false)
            {
                File.Create(@"..\..\..\DATA\PlayerHP.txt");
            }
            bool check2 = File.Exists(@"..\..\..\DATA\EnemyHP.txt");
            if (check2 == false)
            {
                File.Create(@"..\..\..\DATA\EnemyHP.txt");
            }
            bool check3 = File.Exists(@"..\..\..\DATA\PlayerMP.txt");
            if (check3 == false)
            {
                File.Create(@"..\..\..\DATA\PlayerMP.txt");
            }
            string PlayerHP = "100";
            File.WriteAllText(@"..\..\..\DATA\PlayerHP.txt", PlayerHP);
            string EnemyHP = "150";
            File.WriteAllText(@"..\..\..\DATA\EnemyHP.txt", EnemyHP);
            string PlayerMP = "80";
            File.WriteAllText(@"..\..\..\DATA\PlayerMP.txt", PlayerMP);

            ActionBtnPanel.Hide();
            DialogueBox.Text = "A Wild Slime has Appeared";
            SlimeHP.Text = "HP <" + EnemyHP + "/150>";
            PlayerNameDisplay.Text = PlayerNameTxt;
            PlayerHPDisplay.Text = "HP<" + PlayerHP + "/100>";
            PlayerMPDisplay.Text = "MP<" + PlayerMP + "/80>";
        }
        private void btn_atk_Click(object sender, EventArgs e)
        {
            int dmg = btn_Atk_Function(0);

            string EnemyHP = File.ReadAllText(@"..\..\..\DATA\EnemyHP.txt");
            DialogueBox.Text = PlayerNameTxt + " dealt " + dmg + " Damage";
            if (dmg == 20 || dmg == 22 || dmg == 24 || dmg == 26 || dmg == 28 || dmg == 30)
            {
                DialogueBox.Text += " CRITICAL HIT";
            }
            SlimeHP.Text = "HP <" + EnemyHP + "/150>";
            ActionBtnPanel.Enabled = false;
            btn_next2.Enabled = true;
        }

        private void btn_heal_Click(object sender, EventArgs e)
        {
            int PlayerMP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerMP.txt"));
            int PlayerHP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerHP.txt"));
            PlayerHP += 25;
            PlayerMP -= 35;
            string PlayerHPNEW = PlayerHP.ToString();
            string PlayerMPNEW = PlayerMP.ToString();
            PlayerHPDisplay.Text = "HP <" + PlayerHPNEW + "/100>";
            File.WriteAllText(@"..\..\..\DATA\PlayerHP.txt", PlayerHPNEW);
            PlayerMPDisplay.Text = "MP <" + PlayerMPNEW + "/80>";
            File.WriteAllText(@"..\..\..\DATA\PlayerMP.txt", PlayerMPNEW);
            DialogueBox.Text = PlayerNameTxt + " used Healing";
            ActionBtnPanel.Enabled = false;
            btn_next2.Enabled = true;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            Random r = new();
            int chance = r.Next(0, 2);
            if (chance == 1)
            {
                Avoid A = new();
                A.Show();
                this.WindowState = FormWindowState.Minimized;

            }
            else if (chance == 0)
            {
                DialogueBox.Text = "Your Attempt to Escape has Failed";
            }
            ActionBtnPanel.Enabled = false;
            btn_next2.Enabled = true;
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            int PlayerHPM = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerHP.txt"));
            int EnemyHPM = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\EnemyHP.txt"));
            counter++;
            if (counter % 2 != 0)
            {
                btn_next2.Enabled = false;
                DialogueBox.Text = "Choose an Action";
                ActionBtnPanel.Show();
                ActionBtnPanel.Enabled = true;
                int PlayerHP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerHP.txt"));
                int PlayerMP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerMP.txt"));
                int EnemyHP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\EnemyHP.txt"));
                if (PlayerMP < 35 || PlayerHP > 75)
                {
                    btn_heal.Enabled = false;
                }
                else
                {
                    btn_heal.Enabled = true;
                }
                if (PlayerHPM == 0)
                {
                    Defeated D = new();
                    this.Hide();
                    D.ShowDialog();
                    //this.WindowState= FormWindowState.Minimized;
                    this.Close();
                }
            }
            if (counter % 2 == 0)
            {
                if (EnemyHPM == 0)
                {
                    Victory V = new();
                    this.Hide();
                    V.ShowDialog();
                    //this.WindowState = FormWindowState.Minimized;
                    this.Close();
                }
                int dmg = slime_atk_function(0);

                string PlayerHP = File.ReadAllText(@"..\..\..\DATA\PlayerHP.txt");
                DialogueBox.Text = "Slime Dealt " + dmg + " Damage";
                PlayerHPDisplay.Text = "HP<" + PlayerHP + "/100>";
                ActionBtnPanel.Enabled = false;
            }



        }

        private static int PlayerAtk(int c)
        {

            int ATK;
            int CritChance;
            int[] DmgRan = { 10, 11, 12, 13, 14, 15 };             //DMG Range For Player
            Random r = new();
            ATK = DmgRan[r.Next(0, 6)];
            CritChance = r.Next(0, 3);                             //CritChance of 33%
            if (c == 1)                                             //For Guaranteed Crit
            {
                CritChance = 1;
            }
            if (CritChance == 1)                                   //Crit DAMAGE? 200%
            {
                ATK *= 2;
            }
            return ATK;
        }
        private static int btn_Atk_Function(int c)
        {
            int SlimeHP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\EnemyHP.txt"));
            int PlayerATK = PlayerAtk(c);
            int result = SlimeHP - PlayerATK;
            if (result <= 0)
            {
                result = 0;
            }
            string EnemyHPNew = result.ToString();
            File.WriteAllText(@"..\..\..\DATA\EnemyHP.txt", EnemyHPNew);
            return PlayerATK;
        }
        private static int EnemyAtk(int h)
        {
            int ATK;
            int[] DmgRan = { 10, 11, 12, 13, 14, 15 };             //DMG Range for enemy
            Random r = new();
            ATK = DmgRan[r.Next(0, 6)];
            if (h == 1)
            {
                ATK /= 2;
            }
            return ATK;
        }
        private static int slime_atk_function(int h)
        {
            int PlayerHP = Convert.ToInt32(File.ReadAllText(@"..\..\..\DATA\PlayerHP.txt"));
            int EnemyATK = EnemyAtk(0);
            int result = PlayerHP - EnemyATK;
            if (result <= 0)
            {
                result = 0;
            }
            string PlayerHPNew = result.ToString();
            File.WriteAllText(@"..\..\..\DATA\PlayerHP.txt", PlayerHPNew);
            return EnemyATK;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox M1 = new();
            M1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
