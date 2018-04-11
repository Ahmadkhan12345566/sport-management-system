using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_start.BusinessLayer;

namespace project_start.PresentationtationLayer
{
    public partial class LoginForm : Form
    {
        
        public UserInfo _userInfo;
        public MainForm ParentiFormReference
        { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            _userInfo = new UserInfo();
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(usernametextBox1.Text.Trim())
                || string.IsNullOrEmpty(PasswordtextBox1.Text.Trim()))
            {
                MessageBox.Show("Username or password is missing..", "Error");
                return false;
            }

            return true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                UserInfo user = new UserInfo();
                try
                {
                user.Username = usernametextBox1.Text.Trim();
                user.Password = PasswordtextBox1.Text.Trim();

                bool allowUser = LoginLlogic.ValidateUser(user);

                if (allowUser)
                {
                    // Open mainForm 
                    MainForm mForm = new MainForm();

                    // store object's address
                    mForm.ParentFormReference = this;

                    mForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
 }
        }
    }
}