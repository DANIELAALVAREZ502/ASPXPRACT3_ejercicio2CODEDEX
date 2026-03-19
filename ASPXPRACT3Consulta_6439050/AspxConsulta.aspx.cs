using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3Consulta_6439050
{
    public partial class AspxConsulta : System.Web.UI.Page
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
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {

            Response.Redirect("ASPXConsultaparte2.aspx" +
        "?ddlCategory=" + ddlCategory.SelectedValue +
        "&ddlSupplier=" + ddlSupplier.SelectedValue +
        "&strProduct=" + txtProduct.Text +
        "&strDescription=" + txtDescription.Text +
        "&strImage=" + txtImage.Text +
        "&decPrice=" + txtPrice.Text +
        "&bytNumberInStock=" + txtNumberInStock.Text +
        "&bytNumberOnOrder=" + txtNumberOnOrder.Text +
        "&bytReorderLevel=" + txtReorderLevel.Text);
        }
    }
}