using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MyPass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        public string addurl;
        public string addemail;
        public string addpassname;
        public string adduser;
        public string adddesc;
        public string addpass;

        //PASS GENERATION VAR
        public Random random = new Random();
        public bool num = false;
        public bool let = false;
        public bool sym = false;
        public int passlenght = 8;
        public string numbers = "1234567890";
        public string letters = "ABCDEFGHIJKLMOPWRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public string symbols = "!*#$%&'()+,-./:;<>=?@[]^_{}|§";
        public string pass;

        public void DataSavesAdd(string url, string email, string passname, string user, string desc, string pass)
        {
            string filepath = $@".\data\{Shared.passname}\pass\{passname}.txt";
            StreamWriter streamwriter = new StreamWriter(filepath);
            streamwriter.WriteLine(url);
            streamwriter.WriteLine(email);
            streamwriter.WriteLine(user);
            streamwriter.WriteLine(desc);
            streamwriter.WriteLine(pass);
            streamwriter.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {

            if (mailbox.Text != string.Empty && namebox.Text != string.Empty && passbox.Text != string.Empty)
            {
                addurl = urlbox.Text;
                addemail = mailbox.Text;
                addpassname = namebox.Text;
                adduser = userbox.Text;
                adddesc = descbox.Text;
                addpass = passbox.Text;

                DataSavesAdd(addurl, addemail, addpassname, adduser, adddesc, addpass);

                MessageBox.Show("Password saved correctly");
                this.Close();
            }

            else
            {
                MessageBox.Show("Error, fill all the required box");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string filepath = $@".\data\{Shared.passname}\pass\{Shared.passclick}.txt";
            if (File.Exists(filepath))
            {
                StreamReader streamreader = new StreamReader(filepath);
                namebox.Text = Shared.passclick;
                urlbox.Text = streamreader.ReadLine();
                mailbox.Text = streamreader.ReadLine();
                userbox.Text = streamreader.ReadLine();
                descbox.Text = streamreader.ReadLine();
                passbox.Text = streamreader.ReadLine();
                streamreader.Close();
                Shared.passclick = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //NUMBERS
        {
            num = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //LETTERS
        {
            let = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //SYMBOLS
        {
            sym = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        //PASSWORD GENERATOR
        private void genbutton_Click(object sender, EventArgs e) 
        {
            if (passbox.Text != "")
            {
                genbutton.Enabled = false; //one click only
            }
            else
            {
                pass = null;
                passbox.Text = null;
                passlenght = plenght.Value;

                //PASSWORD NUMBERS ONLY
                if (num == true && let == false && sym == false)
                {
                    pass = NumberPass(passlenght);
                }

                //PASSWORD LETTERS ONLY
                if (num == false && let == true && sym == false)
                {
                    pass = LetterPass(passlenght);
                }

                //PASSWORD NUMBERS AND LETTERS
                if (num == true && let == true && sym == false)
                {
                    pass = NumLetPass(passlenght);
                }

                //PASSWORD LETTERS AND SYMBOLS
                if (num == false && let == true && sym == true)
                {
                    pass = LetSymPass(passlenght);
                }

                //PASSWORD NUMBERS, LETTERS AND SYMBOLS
                if (num == true && let == true && sym == true)
                {
                    pass = FullPass(passlenght);
                }

                //ERROR IMPOSSIBLE PASSWORD
                if (num == false && let == false && sym == true || num == true && let == false && sym == true)
                {
                    MessageBox.Show("Error, impossible pasw");
                }

                //ERROR SELECT AN OPTION
                if (num == false && let == false && sym == false)
                {
                    MessageBox.Show("Error, select an optipn");
                }

                passbox.Text = pass;
            }
        }

        //PASSWORD NUMBERS ONLY
        public string NumberPass(int passlenght) 
        {
            for (int a = 0; passlenght > 0; passlenght--)
            {
                a = random.Next(10);
                pass = pass + numbers.ElementAt(a);
            }
            return pass;
        }

        //PASSWORD LETTERS ONLY
        public string LetterPass(int passlenght)
        {
            for (int a = 0; passlenght > 0; passlenght--)
            {
                a = random.Next(52);
                pass = pass + letters.ElementAt(a);
            }
            return pass;
        }

        //PASSWORD NUMBERS AND LETTERS
        public string NumLetPass(int passlenght)
        {
            string caratteri = numbers + letters;

            for(int a = 0; passlenght > 0; passlenght--)
            {
                a = random.Next(62);
                pass = pass + caratteri.ElementAt(a);
            }
            return pass;
        }

        //PASSWORD LETTERS AND SYMBOLS
        public string LetSymPass(int passlenght)
        {
            string caratteri = symbols + letters;

            for (int a = 0; passlenght > 0; passlenght--)
            {
                a = random.Next(81);
                pass = pass + caratteri.ElementAt(a);
            }
            return pass;
        }

        //PASSWORD NUMBERS, LETTERS AND SYMBOLS
        public string FullPass(int passlenght)
        {
            string caratteri = symbols + letters + numbers;

            for (int a = 0; passlenght > 0; passlenght--)
            {
                a = random.Next(91);
                pass = pass + caratteri.ElementAt(a);
            }
            return pass;
        }

        private void plenght_ValueChanged(object sender, EventArgs e)
        {
            lenghtpass.Text = plenght.Value.ToString();
        }

        private void lenghtpass_Click(object sender, EventArgs e)
        {

        }
    }
}
