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

namespace MyPass
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            PassDataLoad();
        }

        public void PassDataLoad()
        {
            string filepath = $@".\data\{Shared.passname}\pass\{Shared.passclick}.txt";
            StreamReader streamreader = new StreamReader(filepath);
            passname.Text = Shared.passclick;
            url.Text = streamreader.ReadLine();
            email.Text = streamreader.ReadLine();
            username.Text = streamreader.ReadLine();
            desc.Text = streamreader.ReadLine();
            password.Text = streamreader.ReadLine();
            streamreader.Close();
        }


        private void deleteconfirm_Click(object sender, EventArgs e)
        {
            string filepath = $@".\data\{Shared.passname}\pass\{Shared.passclick}.txt";
            File.Delete(filepath);
            if(File.Exists(filepath))
            {
                MessageBox.Show("Password delete error");
            }
            else
            {
                MessageBox.Show("Password succesfully deleted");
            }
            this.Close();
        }

        private void deletebutton_Click_1(object sender, EventArgs e)
        {
            viewpanel.Hide();
            deletetext.Show();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 terzo = new Form3();
            terzo.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            deletepanel.Hide();
            viewpanel.Show();
        }
    }
}
