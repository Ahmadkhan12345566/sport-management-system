using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_start.PresentationtationLayer
{
    public partial class Addbadmentionteam : Form
    {
        public Menu ParentttFormReference
        { get; set; }
        
        public Addbadmentionteam()
        {
            InitializeComponent();
        }

        private void Addbadmentionteam_Load(object sender, EventArgs e)
        {

        }
        bool isBack = false;
        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            
            ParentttFormReference.Show();
            isBack = true;
            this.Close();
        }

        private void Donebutton1_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbutton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
