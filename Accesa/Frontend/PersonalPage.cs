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
        string Name;
        int id,tokens;
        String[] hosted = { }, active = { };
        public PersonalPage(int id, string Name, int tokens)
        {
            this.id = id;
            this.Name = Name;
            this.tokens = tokens;
            InitializeComponent();
        }

        private void otherCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Challenge(int.Parse(active[otherCh.SelectedIndex].Split(';')[0]), id);
        }

        

        private void hostedCh_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //make participants table to have name and title as id's for simplicity
            new AdminChallenge(int.Parse(hosted[hostedCh.SelectedIndex].Split(';')[0]),id);
        }

        private void PersonalPage_Load(object sender, EventArgs e)
        {
            
            //populare listboxuri cu titlu si total tokenuri ramase
            //functii in backend care returneaza un array cu elementele din tabel separate prin punct si virgula
            int i;
            
            for (i = 0; i < hosted.Length; i++)
            {
                hostedCh.Items.Add(hosted[i].Split(';')[1] + hosted[i].Split(';')[2]);
            }

            for (i = 0; i < active.Length; i++)
            {
                otherCh.Items.Add(active[i].Split(';')[1] + active[i].Split(';')[2]);
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            new Add(id, tokens);
            this.Hide();
        }
    }
}
