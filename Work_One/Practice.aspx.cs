using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Work_One.Models;

namespace Work_One
{
    public partial class Practice : System.Web.UI.Page
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadRadioButton();
                LoadRbtnArray();
                LoadRbtnHashTable();
                LoadrbtnXML();
            }
            this.lblMsg.Text = "Welcome to mahedee.net";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.lblMsg.Text = "This is for button event";
        }

        private void LoadRbtnArray()
        {
            ArrayList lst = new ArrayList(); lst.Add("Barisal"); lst.Add("Noakhali"); lst.Add("Comilla"); lst.Add("Chandpur"); rbtnArrayList.DataSource = lst; rbtnArrayList.DataBind();
        }
        private void LoadRbtnHashTable()
        {
            Hashtable htbl = new Hashtable(); htbl.Add("1", "CSE"); htbl.Add("2", "EEE"); htbl.Add("3", "ETE"); htbl.Add("4", "ICT"); rbtnHashTable.DataSource = htbl; rbtnHashTable.DataValueField = "Key";
            rbtnHashTable.DataTextField = "Value"; rbtnHashTable.DataBind();
        }

        private void LoadRadioButton()
        {
            var products = db.Products.ToList();
            this.rbtnDynamic.DataSource = products;
            rbtnDynamic.DataValueField = "ProductID";
            rbtnDynamic.DataTextField = "ProductName";
            rbtnDynamic.DataBind();
            //  this.rbtnDynamic.Items.Add(new ListItem("One", "1")); this.rbtnDynamic.Items.Add(new ListItem("Two", "2")); this.rbtnDynamic.Items.Add(new ListItem("Three", "3")); this.rbtnDynamic.Items.Add(new ListItem("Four", "4")); this.rbtnDynamic.Items.Add(new ListItem("Five", "5"));
        }

        private void LoadrbtnXML()
        {
            var countries = new DataSet();
            countries.ReadXml(MapPath("country.xml"));
            this.rbtnXml.DataSource = countries;
            rbtnXml.DataValueField = "value";
            rbtnXml.DataTextField = "text";
            rbtnXml.DataBind();
        }
        private void Clear()
        {
            this.lblMsg.Text = "";
            this.txtFullName.Text = "";
        }
    }
}