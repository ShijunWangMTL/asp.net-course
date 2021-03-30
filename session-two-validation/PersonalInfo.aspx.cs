using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_two_validation
{
    public partial class PersonalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstname = txtFname.Text;
            string lastname = txtLname.Text;
            string strNum = txtStrNum.Text;
            string str = txtStr.Text;
            string postal = txtPstlCode.Text;
            string phone = txtPhone.Text;

            lblResult.Text = "You submitted the information below: ";
            lblName.Text = "Full Name:";
            lblNameResult.Text = firstname + " " + lastname;
            lblAddr.Text = "Address:";
            lblAddrResult.Text = strNum + " " + str + ", " + postal;
            lblPh.Text = "Phone Number:";
            lblPhResult.Text = phone;

            lblFname.Text = "";
            lblLname.Text = "";
            lblStrNum.Text = "";
            lblStr.Text = "";
            lblPhone.Text = "";

        }
    }
}