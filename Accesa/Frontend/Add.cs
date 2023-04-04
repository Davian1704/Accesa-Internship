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
        int CreatorId;
        public Add(int Creatorid,int maxTokens)
        {
            this.CreatorId = CreatorId;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //2 updates
            //un create pe tabela de challenges
            string title, description;
            int tokens;
            title = titleTb.Text;
            description = descriptionTb.Text;
            tokens = int.Parse(tokenTb.Text);
            //un update pentru a modifica cate token-uri mai are user-ul
            //ori un update la PersonalPage sa schimbe nr de tokenuri ori un re-open cu totul
        }

    }
}
