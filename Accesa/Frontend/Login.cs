using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Login : Form
    {
        Frontend.ServiceReference1.WebService1SoapClient service = new Frontend.ServiceReference1.WebService1SoapClient();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=0,tokens=0;
            string Name, Password;
            Name = userTB.Text;
            Password = passTB.Text;
            string result = service.getUserbyCredentials(Name, Password);
            id = int.Parse(result.Split(';')[0]);
            tokens = int.Parse(result.Split(';')[2]);
            PersonalPage page = new PersonalPage(id, Name, tokens);
            this.Hide();
            page.ShowDialog();
            this.Close();
        }
    }
}
