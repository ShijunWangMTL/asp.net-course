using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session1_project
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListItem item1 = new ListItem("Male", "0");
                RbtnSex.Items.Add(item1);
                RbtnSex.Items.Add(new ListItem("Female", "1"));
                //RbtnSex.Items.Add("Male");

                DdlCourse.Items.Add("Data Structure");
                DdlCourse.Items.Add("Java");
                DdlCourse.Items.Add("C#");
                DdlCourse.Items.Add("PHP");
                DdlCourse.Items.Add("Database");
            }


            //ListItem listItem = new ListItem();
            //listItem.Attributes.Add("class", "rbtn");
            //RbtnSex.Items.Add(listItem);
            //RbtnCoverage.Items.Add(listItem);
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sex = RbtnSex.SelectedValue;
            string course = DdlCourse.SelectedValue;
            string coverage = RbtnCoverage.SelectedValue;
            string suggestion = TxtSuggestion.Value;

            if (sex == "Male")
            {
                name = "Mr. " + name;
            } else
            {
                name = "Ms. " + name;
            }
            txtName.Text = "";
            LblSubmitted.Text = "Thanks " + name + " for your feedback!";
            RbtnSex.SelectedIndex = -1;
            DdlCourse.SelectedIndex = -1;
            RbtnCoverage.SelectedIndex = -1;
            TxtSuggestion.Value = "";
        }

    }
}