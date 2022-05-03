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
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MyPass
{
    public partial class Mypass : Form
    {
        public Mypass()
        {
            InitializeComponent();

            //BUTTON STYLE

            hidebutton.FlatStyle = FlatStyle.Flat;
            hidebutton.FlatAppearance.BorderSize = 0;

            view.FlatStyle = FlatStyle.Flat;
            view.FlatAppearance.BorderSize = 0;

            viewbutton.FlatStyle = FlatStyle.Flat;
            viewbutton.FlatAppearance.BorderSize = 0;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            //
        }

        //VARIABILI

        public string passerror = "INSERT VALID PASSWORD"; //errore password
        public string emailerror = "INSERT VALID EMAIL"; //errore email
        public string usererror = "INSERT VALID USERNAME"; //errore username

        public string elog = "EMAIL"; //login email
        public string plog = "PASSWORD"; //login password
        public string ulog = "USERNAME"; //sign up username

        //SALVATAGGIO DATI SIGN UP
        public string signemail; //
        public string signpass;
        public string signuser;

        //
        public string loguser;
        public string logpass;

        public int emailcheck = 0;

        //

        //DATA FUNCTIONS
        public void DataSavesSignup(string user, string email, string pass)
        {
            string filepath = $@".\data\{user}";
            Directory.CreateDirectory(filepath);
            filepath = $@".\data\{user}\pass";
            Directory.CreateDirectory(filepath);
            filepath = $@".\data\{user}\userdetails.txt";
            StreamWriter streamwriter = new StreamWriter(filepath);
            streamwriter.WriteLine(pass);
            streamwriter.WriteLine(email);
            streamwriter.Close();

        }

        public bool DataCheckLogin(string user,string pass)
        {
            string filepath = $@".\data\{user}\userdetails.txt";
            if (File.Exists(filepath))
            {
                StreamReader streamreader = new StreamReader(filepath);
                string check = streamreader.ReadLine();
                if(pass == check)
                {
                    Shared.passname = user;
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    return false;
                }

            }

            MessageBox.Show("Wrong Username");
            return false;

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            signpanel.Show();
            loginpanel.Hide();
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != ulog && txtpass.Text != plog && txtemail.Text != usererror && txtpass.Text != passerror)
            {

                loguser = txtemail.Text;
                logpass = sha512(txtpass.Text);
                bool check = DataCheckLogin(loguser, logpass);

                if (check == true)
                {
                    this.Hide();
                    Form2 home = new Form2();
                    home.ShowDialog();
                    this.Close();
                }
            }


             if (txtemail.Text == ulog)
             {


                txtemail.Text = usererror;
                txtemail.ForeColor = Color.Red;


             }
             if (txtpass.Text == plog)
             {

                txtpass.Text = passerror;
                txtpass.ForeColor = Color.Red;
             }
            
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == ulog)
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;

            }
            else if (txtemail.Text == usererror)
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = ulog;
                txtemail.ForeColor = Color.Black;

            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == plog)
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
            else if (txtpass.Text == passerror)
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = plog;
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '•')
            {
                hidebutton.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                view.BringToFront();
                txtpass.PasswordChar = '•';
            }
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //SIGN UP
        private void button1_Click(object sender, EventArgs e) //NEXTBUTTON
        {
            if (txtemail2.Text.Contains('@'))
            {
                emailcheck++;
            }

            if (txtemail2.Text.Contains('.'))
            {
                emailcheck++;
            }

            if (txtemail2.Text != elog && emailcheck == 2 && txtpass2.Text != plog && txtuser.Text != ulog && txtemail2.Text != emailerror && txtpass2.Text != passerror && txtuser.Text != usererror)
            {
                loginpanel.Show();
                signpanel.Hide();


                signemail = txtemail2.Text;
                signpass = sha512(txtpass2.Text); 
                signuser = txtuser.Text;
                DataSavesSignup(signuser, signemail, signpass);
            }

            if (txtemail2.Text == elog || emailcheck < 2)
            {
                txtemail2.Text = emailerror;
                txtemail2.ForeColor = Color.Red;
            }
            if (txtpass2.Text == plog )
            {
                txtpass2.Text = passerror;
                txtpass2.ForeColor = Color.Red;
                txtpass2.UseSystemPasswordChar = true;
            }
            if (txtuser.Text == ulog )
            {
                txtuser.Text = usererror;
                txtuser.ForeColor = Color.Red;
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == ulog)
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
            else if (txtuser.Text == usererror)
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = ulog;
                txtuser.ForeColor = Color.Black;

            }
        }

        private void txtemail2_Enter(object sender, EventArgs e)
        {
            if (txtemail2.Text == elog)
            {
                txtemail2.Text = "";
                txtemail2.ForeColor = Color.Black;
            }
            else if (txtemail2.Text == emailerror)
            {
                txtemail2.Text = "";
                txtemail2.ForeColor = Color.Black;
            }
        }

        private void txtemail2_Leave(object sender, EventArgs e)
        {
            if (txtemail2.Text == "")
            {
                txtemail2.Text = elog;
                txtemail2.ForeColor = Color.Black;

            }
        }

        private void txtpass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass2_Enter(object sender, EventArgs e)
        {
            if (txtpass2.Text == plog)
            {
                txtpass2.Text = "";
                txtpass2.ForeColor = Color.Black;
                txtpass2.UseSystemPasswordChar = false;
            }
            else if (txtpass2.Text == passerror)
            {
                txtpass2.Text = "";
                txtpass2.ForeColor = Color.Black;
                txtpass2.UseSystemPasswordChar = false;
            }
        }

        private void txtpass2_Leave(object sender, EventArgs e)
        {
            if (txtpass2.Text == "")
            {
                txtpass2.Text = plog;
                txtpass2.ForeColor = Color.Black;
                txtpass2.UseSystemPasswordChar = true;
            }
        }

       

        

        private void Mypass_Load(object sender, EventArgs e)
        {
            txtpass.Text = "PASSWORD";

        }

        private void hide_Click_1(object sender, EventArgs e)
        {
            
            if (txtpass.PasswordChar == '\0')
            {
                viewbutton.BringToFront();
                txtpass.PasswordChar = '•';
            }
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '•')
            {
                hidebutton.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void view_Click_1(object sender, EventArgs e)
        {
            if (txtpass2.PasswordChar == '•')
            {
                button5.BringToFront();
                txtpass2.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtpass2.PasswordChar == '\0')
            {
                view.BringToFront();
                txtpass2.PasswordChar = '•';
            }
        }

        //FUNZIONE SCRITTA DA GHILARDI NICOLA
        static string sha512(string randomString) //FUNZIONE GENERA HASH CON SHA512
        {
            var crypt = new SHA512Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        private void Mypass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton.PerformClick(); //genera un evento click per il pulsante
            }

        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton.PerformClick(); //genera un evento click per il pulsante
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton.PerformClick(); //genera un evento click per il pulsante
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextbutton.PerformClick(); //genera un evento click per il pulsante
            }
        }

        private void txtemail2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextbutton.PerformClick(); //genera un evento click per il pulsante
            }
        }

        private void txtpass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextbutton.PerformClick(); //genera un evento click per il pulsante
            }
        }
    }

    public class Shared
    {
        public static string passname;
        public static string passclick;
    }
}
