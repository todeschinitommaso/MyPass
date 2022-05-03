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
using System.Drawing.Drawing2D;

namespace MyPass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //BUTTON STYLE

            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.FlatAppearance.BorderSize = 0;

            backbutton1.FlatStyle = FlatStyle.Flat;
            backbutton1.FlatAppearance.BorderSize = 0;

            addpass.FlatStyle = FlatStyle.Flat;
            addpass.FlatAppearance.BorderSize = 0;

            timer1.Interval = 2000;
            //
        }

        public string filepath = $@".\data\{Shared.passname}\pass"; //Passwords File Path .txt

        public int distance = 1;

        //FILE COUNT

        public void LabelCreation(int filecount)
        {
            
        }

        public void EmailCharger()
        {
            
        }
        
        private void login_Click(object sender, EventArgs e)
        {

        }


        private void homebutton_Click(object sender, EventArgs e)
        {
           homepanel.Show();
           settingspanel.Hide(); 
           passpanel.Hide();
           
        }

        private void managebutton_Click(object sender, EventArgs e)
        {
            homepanel.Hide();
            settingspanel.Hide();
            passpanel.Show();
        }


        private void passpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void exitbutton_Click(object sender, EventArgs e)
        {          
            this.Hide();
            Mypass primo=new Mypass(); 
            primo.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        


        //LIST BOX 
        private void Form2_Load(object sender, EventArgs e) //all'avvio del form
        {
            List<string> dirs = new List<string>(Directory.EnumerateFiles(filepath, "*.txt", SearchOption.AllDirectories));
            ListBoxLoad(dirs);
            UserSettingsLoad();
        }

        public void ListBoxLoad(List<string> dirs)
        {

            foreach (string dir in dirs)
            {
                string passname = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int passcount = passname.Count();
                passname = passname.Remove(passcount - 4);
                PassList.Items.Add(passname);

            }
            passpanel.Controls.Add(PassList);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared.passclick = PassList.SelectedItem.ToString();

            Form4 quarto = new Form4();
            quarto.ShowDialog();
        }

        private void addpass_Click_1(object sender, EventArgs e)
        {
            Form3 terzo = new Form3();
            terzo.ShowDialog();
        }


        private void backbutton_Click(object sender, EventArgs e)
        {
            settingspanel.Hide();
            passpanel.Hide();
            homepanel.Visible = true;
            homepanel.Show();
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            settingspanel.Hide();
            passpanel.Hide();
            homepanel.Show();
        }

        private void passwordpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UserSettingsLoad() //IMPOSTAZIONI UTENTE
        {
            userlabel.Text = Shared.passname;
            filepath = $@".\data\{Shared.passname}\userdetails.txt";
            StreamReader streamreader = new StreamReader(filepath);
            string pass = streamreader.ReadLine();
            emaillabel.Text = streamreader.ReadLine();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PassList.Items.Clear();
            filepath = $@".\data\{Shared.passname}\pass";
            List<string> dirs = new List<string>(Directory.EnumerateFiles(filepath, "*.txt", SearchOption.AllDirectories));
            ListBoxLoad(dirs);
        }

        private void websitepannel_Click(object sender, EventArgs e)
        {
            var url = "http://todeschini.altervista.org/MyPass";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            System.Diagnostics.Process.Start(psi);
        }

        private void settpanel_Click(object sender, EventArgs e)
        {
            homepanel.Hide();
            passpanel.Hide();
            settingspanel.Show();
        }

        private void passwordpanel_Click(object sender, EventArgs e)
        {
            homepanel.Hide();
            settingspanel.Show();
            passpanel.Show();
        }

        private void logoutpanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mypass primo = new Mypass();
            primo.ShowDialog();
            this.Close();
        }

    }
}
