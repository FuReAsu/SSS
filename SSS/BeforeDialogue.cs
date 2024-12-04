using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class BeforeDialogue : Form
    {
        string PlayerName = "Player";

        int counter = 0;
        public BeforeDialogue()
        {
            InitializeComponent();
            GetPlayerNamePanel.Hide();
            bool file = File.Exists(@"..\..\..\DATA\PlayerName.txt");
            if (file == false)
            {
                File.Create(@"..\..\..\DATA\PlayerName.txt");
                File.WriteAllText(@"..\..\..\DATA\PlayerName.txt", PlayerName);
            }
            File.WriteAllText(@"..\..\..\DATA\PlayerName.txt", PlayerName);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string Dialogues = DialoguesDisplay(counter);
            DialogueBox.Text = Dialogues;
            counter++;
            if (counter == 15)
            {
                GetPlayerNamePanel.Show();
                btn_next.Enabled = false;
            }
            if (counter == 29)
            {
                Battle F3 = new();
                this.Hide();
                F3.ShowDialog();
                //this.WindowState = FormWindowState.Minimized;
                btn_next.Enabled = false;
                this.Close();
            }

        }

        private void btn_namesave_Click(object sender, EventArgs e)
        {
            string PlayerName = GetPlayerName.Text;
            File.WriteAllText(@"..\..\..\DATA\PlayerName.txt", PlayerName);
            GetPlayerNamePanel.Hide();
            btn_next.Enabled = true;
        }
        public static string DialoguesDisplay(int counter)
        {
            List<String> Dialogues = new List<String>();
            /*0*/
            Dialogues.Add("\"In the forest of “Wondering Woods” There was a young boy who was out for a rabbit hunt.");
            /*1 */
            Dialogues.Add("??? > “Sigh………………………”\n");
            /*2 */
            Dialogues.Add("You said it with a heavy breath \r\n");
            /*3 */
            Dialogues.Add("??? > “Another day, another boring hunt. I wonder what the heroes are doing right now…”\n");
            /*4 */
            Dialogues.Add("??? > Well, it’s because you aren’t doing anything about it\r\n");
            /*5 */
            Dialogues.Add("??? > “What? Wha… Who said that?!”\n");
            /*6 */
            Dialogues.Add("??? > Me, you imbecile. Did you forgot that there’s a demon living inside you?\n");
            /*7 */
            Dialogues.Add("??? > “Shut up Gresill, I did not asked you to make a pact with me in the first place”\r\n");
            /*8 */
            Dialogues.Add("Gresill > Ohh? Should I break the contract and leave you alone like that night in the forest then?\r\n");
            /*9 */
            Dialogues.Add("??? > “...”\r\n");
            /*10 */
            Dialogues.Add("??? > “I hate you”\r\n");
            /*11*/
            Dialogues.Add("Gresill > Many people did\n");
            /*12*/
            Dialogues.Add("Gresill > ...\r\n");
            /*13*/
            Dialogues.Add("Gresil > By the way, do you have a name, mortal?\r\n");
            /*14*/
            Dialogues.Add("??? > “I already told you it’s…”\r\n");
            /*15*/
            Dialogues.Add("\n{0}\n");
            /*16*/
            Dialogues.Add("Gresill > Well {0}, forgive me for not remembering a forgettable name like that\n");
            /*17*/
            Dialogues.Add("{0} > “Just shut up and let me focus on the hunt!”\r\n");
            /*18*/
            Dialogues.Add("...\n");
            /*19*/
            Dialogues.Add("After a while, You stumbled upon a slime\n");
            /*20*/
            Dialogues.Add("{0} > “Great.. Now I have to avoid this path”\n");
            /*21*/
            Dialogues.Add("Gresill > Avoid?! The great Demon of Dreams don’t know avoids! How dare you go across such a low life creature\n");
            /*22*/
            Dialogues.Add("{0} > “My body, my choice. Now shut your trap”\n");
            /*23*/
            Dialogues.Add("Gresill > C’mon mortal, this is your chance to finally take a new step in your pathetic life.\n Didn’t you say you’re getting sick of washing people’s disgusting clothes the other day?\n");
            /*24*/
            Dialogues.Add("{0} > “Don’t tempt me demon”");
            /*25*/
            Dialogues.Add("Gresill > I’m literally inside your brain mortal, you act like you don’t want to but you never admit it.\r\n");
            /*26*/
            Dialogues.Add("Gresill > Now, what will it be? Mortal…\r\n");
            /*27*/
            Dialogues.Add("{0} > “I.. I uhh…..”\n");
            Dialogues.Add("...");
            string D = Dialogues[counter];
            string name = File.ReadAllText(@"..\..\..\DATA\PlayerName.txt");
            if (counter == 15)
            {
                D = name + " > " + name;
            }
            if (counter == 16)
            {
                D = "Gresill > Well " + name + ", forgive me for not remembering a forgettable name like that";
            }
            if (counter == 17)
            {
                D = name + " > “Just shut up and let me focus on the hunt";
            }
            if (counter == 20)
            {
                D = name + " > “Great..Now I have to avoid this path";
            }
            if (counter == 22)
            {
                D = name + " > “My body, my choice.Now shut your trap”";
            }
            if (counter == 24)
            {
                D = name + " > “Don’t tempt me demon”";
            }
            if (counter == 27)
            {
                D = name + " > “I..I uhh…..”";
            }

            return D;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}


