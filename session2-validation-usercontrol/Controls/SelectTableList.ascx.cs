using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_two_validation
{
    public partial class SelectTableList : System.Web.UI.UserControl
    {
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        //using WebControl to pass items to listsource
        //public string InitialItems
        //{
        //    get { return lblTitle.Text; }
        //    set
        //    {
        //        string[] items = value.Split(',');
        //        listSource.Items.Clear();
        //        foreach(String item in items)
        //        {
        //            listSource.Items.Add(new ListItem(item));
        //        }
        //    }
        //}

        //not using WebControl
        List<ListItem> fruits = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            setFruitList();

            if (!IsPostBack)
            {
                foreach (ListItem item in fruits)
                {
                    listSource.Items.Add(item);
                }
            }
        }

        private void setFruitList()
        {
            fruits.Add(new ListItem("Apple", "0"));
            fruits.Add(new ListItem("Banana", "1"));
            fruits.Add(new ListItem("Kiwi", "2"));
            fruits.Add(new ListItem("Lime", "3"));
            fruits.Add(new ListItem("Mango", "4"));
            fruits.Add(new ListItem("Orange", "5"));
        }

        protected void btnAllright_Click(object sender, EventArgs e)
        {
            // to listDestination
            foreach (ListItem item in listSource.Items)
            {
                if (!listDestination.Items.Contains(item))
                {
                    listDestination.Items.Add(item);
                }
            }
            listSource.Items.Clear();
            listSource.SelectedIndex = -1;
            listDestination.SelectedIndex = -1;
        }

        protected void btnSelectedRight_Click(object sender, EventArgs e)
        {
            if (listSource.SelectedIndex != -1)
            {
                //for (int i = listSource.Items.Count - 1; i >= 0; i--)
                //{
                //    if (listSource.Items[i].Selected == true)
                //    {
                //        if (!listDestination.Items.Contains(listSource.Items[i]))
                //        {
                //            listDestination.Items.Add(listSource.Items[i]);
                //            //listSource.Items.Remove(listDestination.Items[i]);
                //        }
                //    }
                //}

                foreach (ListItem item in listSource.Items)
                {
                    if (item.Selected == true)
                    {
                        if (!listDestination.Items.Contains(item))
                        {
                            listDestination.Items.Add(item);
                            listSource.Items.Remove(item);
                        }
                    }
                }
            }
            else
            {
                btnSelectedRight.Attributes.Add("onclick", "return confirm('No item selected');");
                //Response.Write("<script>alert('No item selected')</script>");
            }
            listSource.SelectedIndex = -1;
            listDestination.SelectedIndex = -1;
        }

        protected void btnSelectedLeft_Click(object sender, EventArgs e)
        {
            if (listDestination.SelectedIndex != -1)
            {
                //cannot use foreach loop, error: InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
                for (int i = listDestination.Items.Count - 1; i >= 0; i--)
                {
                    if (listDestination.Items[i].Selected == true)
                    {
                        listDestination.Items.Remove(listDestination.Items[i]);
                        listSource.Items.Add(listDestination.Items[i]);
                    }
                }
            }
            else
            {
                btnSelectedLeft.Attributes.Add("onclick", "return confirm('No item selected');");
            }
            listSource.SelectedIndex = -1;
            listDestination.SelectedIndex = -1;
        }

        protected void btnAllLeft_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in listDestination.Items)
            {
                if (!listSource.Items.Contains(item))
                {
                    listSource.Items.Add(item);
                }
            }

            listDestination.Items.Clear();
            listSource.SelectedIndex = -1;
            listDestination.SelectedIndex = -1;
        }
    }
}