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
    public partial class Challenge : Form
    {
        Frontend.ServiceReference1.WebService1SoapClient service = new Frontend.ServiceReference1.WebService1SoapClient();
        int ChallengeId, PlayerId;
        string description;
        public Challenge(int ChallengeId,string description ,int PlayerId)
        {
            this.ChallengeId = ChallengeId;
            this.PlayerId = PlayerId;
            this.description = description;
            InitializeComponent();
        }

        private void Challenge_Load(object sender, EventArgs e)
        {
            
            //get info from challenges
            descriptionTb.Text = description;
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            service.addParticipant(ChallengeId, PlayerId);
            service.updateChallengeReward(ChallengeId);
            this.Close();
        }
    }
}
