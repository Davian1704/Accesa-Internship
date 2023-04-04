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
    public partial class PersonalPage : Form
    {
        Frontend.ServiceReference1.WebService1SoapClient service = new Frontend.ServiceReference1.WebService1SoapClient();
        string UserName;
        int id,tokens;
        String[] hosted , active;
        public PersonalPage(int id, string UserName, int tokens)
        {
            this.id = id;
            this.UserName = UserName;
            this.tokens = tokens;
            InitializeComponent();
        }

        private void otherCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Challenge chal = new Challenge(int.Parse(active[otherCh.SelectedIndex].Split(';')[0]),active[otherCh.SelectedIndex].Split(';')[2], id);
            chal.ShowDialog();

        }

        private void PersonalPage_Load(object sender, EventArgs e)
        {
            int i;
            tokensVal.Text = tokens.ToString();
            usernameL.Text = UserName;
            hosted = service.getHostedChallenges(id).Split(',');
            if (hosted[0].Split(';').Length > 1)
            {

                for (i = 0; i < hosted.Length; i++)
                {
                    hostedCh.Items.Add(hosted[i].Split(';')[2]);
                }
            }
            Console.WriteLine(id);
            active = service.getActiveChallenges(id).Split(',');
            if (active[0].Split(';').Length > 1)
            {

                
                for (i = 0; i < active.Length; i++)
                {
                    otherCh.Items.Add(active[i].Split(';')[2]);
                }
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            Add add = new Add(id, tokens);
            add.ShowDialog();
            hostedCh.Items.Clear();
            hosted = service.getHostedChallenges(id).Split(',');
            int i;
            if (hosted[0].Split(';').Length > 1)
            {

                for (i = 0; i < hosted.Length; i++)
                {
                    hostedCh.Items.Add(hosted[i].Split(';')[2]);
                }
            }
        }
    }
}
