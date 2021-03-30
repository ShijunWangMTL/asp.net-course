using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session1_project
{
    public partial class PersonalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblWelcom.Text = "Welcome to our site.";
            }
            
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            lblWelcom.Text = "";
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            lblResult.Text = string.Format("The personal info {0}, {1}", firstName, lastName);
            lblResult.BackColor = System.Drawing.Color.Beige;

            BtnSubmit.Text = "Submitted";
            tbl.Style["background-color"] = "beige";

            //change color of reset button,
            //Reset.
        }
    }
}