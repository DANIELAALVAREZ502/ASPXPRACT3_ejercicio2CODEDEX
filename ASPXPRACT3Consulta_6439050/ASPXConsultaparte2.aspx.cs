using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3Consulta_6439050
{
    public partial class ASPXConsultaparte2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.Items.Add("Footwear - Women's");
                ddlCategory.Items.Add("Footwear - Men's");
                ddlCategory.Items.Add("Accessories");

                ddlSupplier.Items.Add("Nike");
                ddlSupplier.Items.Add("Adidas");
                ddlSupplier.Items.Add("Puma");
            }
            
            if (Request.QueryString["strProduct"] != null)
            {                
                ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
                ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
                lblProduct.Text = Request.QueryString["strProduct"];
                txtDescription.Text = Request.QueryString["strDescription"];
                lblImage.Text = Request.QueryString["strImage"];
                lblReorderLevel.Text = Request.QueryString["bytReorderLevel"];
               
                decimal decPrice = Convert.ToDecimal(Request.QueryString["decPrice"]);
                byte bytNumberInStock = Convert.ToByte(Request.QueryString["bytNumberInStock"]);
                byte bytNumberOnOrder = Convert.ToByte(Request.QueryString["bytNumberOnOrder"]);
               
                lblPrice.Text = decPrice.ToString("c");
               
                lblNumberInStock.Text = bytNumberInStock.ToString();
                lblNumberOnOrder.Text = bytNumberOnOrder.ToString();
              
                decimal decValueInStock = decPrice * bytNumberInStock;
                decimal decValueOnOrder = decPrice * bytNumberOnOrder;
             
                lblValueInStock.Text = decValueInStock.ToString("c");
                lblValueOnOrder.Text = decValueOnOrder.ToString("c");
            }
        
        }
    }
}