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
    public partial class Add : Form
    {
        Frontend.ServiceReference1.WebService1SoapClient service = new Frontend.ServiceReference1.WebService1SoapClient();
        int CreatorId;
        int maxTokens;
        public Add(int Creatorid,int maxTokens)
        {
            this.CreatorId = Creatorid;
            this.maxTokens = maxTokens;
            InitializeComponent();
           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            string title, description;
            int tokens;
            description = descriptionTb.Text;
            tokens = int.Parse(tokenTb.Text);
            if (tokens > maxTokens && tokens>0)
                MessageBox.Show("Can not exceed the owned amount of tokens and can not be a negative or 0 value");
            else
            {
                Console.WriteLine(CreatorId);
                service.addChallenge(service.getMaxChallengeId()+2, CreatorId, description, tokens);
                service.updateUserTokens(CreatorId, maxTokens - tokens);

            }
            
        }

        private void Add_Load(object sender, EventArgs e)
        {
            label1.Text = maxTokens.ToString();
        }
    }
}
