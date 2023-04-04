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
            //conditie corect din database
            //tokens si id din database
            //message box cu eroare daca nu e bine
            //in backend return -1 sau ceva daca null si un array or something with id,Name si tokens daca nu
            new PersonalPage(id, Name, tokens);
        }
    }
}
