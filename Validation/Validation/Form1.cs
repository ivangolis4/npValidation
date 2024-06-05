using System.Text.RegularExpressions;

namespace Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RBREGISTER_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (string.IsNullOrEmpty(TBFIRSTNAE.Text))
            {
                lbfirstname.Text = "Provide Firstname";
                valid = false;
            }
            if (string.IsNullOrEmpty(TBLASTNAME.Text))
            {
                lblastname.Text = "Provide Last Name";
                valid = false;
            }
            if (string.IsNullOrEmpty(TBUSERNAME.Text))
            {
                lbusername.Text = "Provide Username";
                valid = false;
            }
            if (!string.IsNullOrEmpty(TBEMAIL.Text))
            {
                if (!re.IsMatch(TBEMAIL.Text))
                {
                    lbemail.Text = "Invalid email";
                    valid = false;
                }
                
            }
            else
            {
                lbemail.Text = "Provide an email";
                valid = false;
            }
            if (string.IsNullOrEmpty(TBPASSWORD.Text))
            {
                lbpassword.Text = "Provide a password";
                valid = false;
            }
            if (string.IsNullOrEmpty(TBCPASSWORD.Text))
            {
                lbconfirmpassword.Text = "Confirm password";
                valid = false;
            }
            if (TBPASSWORD.Text != TBCPASSWORD.Text)
            {
                lbconfirmpassword.Text = "Password should be the smae";
                valid = false;
            }

            if (!RBMALE.Checked && !RBFEMALE.Checked)
            {
                lbgender.Text = "choose gender";
                valid = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TBFIRSTNAE_TextChanged(object sender, EventArgs e)
        {
            lbfirstname.Text = "";
        }

        private void TBLASTNAME_TextChanged(object sender, EventArgs e)
        {
            lblastname.Text = "";
        }

        private void TBUSERNAME_TextChanged(object sender, EventArgs e)
        {
            lbusername.Text = "";
        }

        private void TBEMAIL_TextChanged(object sender, EventArgs e)
        {
            lbemail.Text = "";
        }

        private void TBPASSWORD_TextChanged(object sender, EventArgs e)
        {
            lbpassword.Text = "";
        }

        private void TBCPASSWORD_TextChanged(object sender, EventArgs e)
        {
            lbconfirmpassword.Text = "";
        }

        private void RBMALE_CheckedChanged(object sender, EventArgs e)
        {
            lbgender.Text = "";
        }

        private void RBFEMALE_CheckedChanged(object sender, EventArgs e)
        {
            lbgender.Text = "";
        }
    }
}
