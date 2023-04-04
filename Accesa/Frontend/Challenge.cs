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
        int ChallengeId, PlayerId;
        public Challenge(int ChallengeId,int PlayerId)
        {
            this.ChallengeId = ChallengeId;
            this.PlayerId = PlayerId;
            InitializeComponent();
        }

        private void Challenge_Load(object sender, EventArgs e)
        {
            //get info from challenges
            string title=" ", description=" ";
            titleTb.Text = title;
            descriptionTb.Text = description;
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            //update method to add to participants
            //update method to remove from budget of challenge
        }
    }
}
