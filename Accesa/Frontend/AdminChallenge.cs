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
    public partial class AdminChallenge : Form
    {   int ChallengeId, CreatorId;
        public AdminChallenge(int ChallengeId, int CreatorId)
        {   //only for information
            this.ChallengeId = ChallengeId;
            this.CreatorId = CreatorId;
            InitializeComponent();
        }
    }
}
