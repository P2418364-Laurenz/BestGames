using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["errors"] != null)
        {
            string popupArguments = "Some errors were made: error";
            if (Request.QueryString["missingName"] != null)
            {
                popupArguments += ", missing name";
            }
            if (Request.QueryString["nameLength"] != null)
            {
                popupArguments += ", wrong name length";
            }
            if (Request.QueryString["missingEmail"] != null)
            {
                popupArguments += ", missing email";
            }
            if (Request.QueryString["emailLength"] != null)
            {
                popupArguments += ", email too long";
            }
            if (Request.QueryString["wrongEmail"] != null)
            {
                popupArguments += ", email address does not have the correct format (must be @ and .)";
            }
            if (Request.QueryString["missingPassword"] != null)
            {
                popupArguments += ", missing password";
            }
            if (Request.QueryString["passwordLength"] != null)
            {
                popupArguments += ", password must be 6-31 characters";
            }
            if (Request.QueryString["missingPasswordRepeat"] != null)
            {
                popupArguments += ", missing password repeat";
            }
            if (Request.QueryString["passwordRepeatLength"] != null)
            {
                popupArguments += ", repeat password too long";
            }
            if (Request.QueryString["passwordMismatch"] != null)
            {
                popupArguments += ", passwords do not match";
            }
            System.Web.UI.HtmlControls.HtmlGenericControl errorDiv =
            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
            errorDiv.ID = "errorDiv";
            errorDiv.Style.Add(HtmlTextWriterStyle.Color, "Red");
            errorDiv.InnerHtml = popupArguments;
            errorMsgDiv.Controls.Add(errorDiv);
        }
    }
    
    // name = not empty, 6-32 characters, only letters and space.
    protected void inputSubmit_Click(object sender, EventArgs e)
    {
        if (inputName.Text != "" && (inputName.Text.Length < 32 || inputName.Text.Length > 6) && inputEmail.Text != "" && (inputEmail.Text.Length < 64 ||
            inputEmail.Text.Length > 6) && inputPassword.Text != "" && (inputPassword.Text.Length < 32 || inputPassword.Text.Length > 6) && 
            inputPasswordRepeat.Text != "" && (inputPasswordRepeat.Text.Length < 32 || inputPasswordRepeat.Text.Length > 6) && 
            inputPassword.Text == inputPasswordRepeat.Text)
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusName = inputName.Text;
            aCustomer.cusEmail = inputEmail.Text;
            aCustomer.cusPassword = inputPassword.Text;
            Session["aCustomer"] = aCustomer;
            aCustomer.encryptPass();
            aCustomer.setUser();
            Response.Redirect("userViewer.aspx");
        } else
        {
            String arguments = "";
            if (inputName.Text == "")
            {
                arguments += "&missingName=true";
            }
            if (inputName.Text.Length > 32 || inputName.Text.Length < 6)
            {
                arguments += "&nameLength=true";
            }
            if (inputEmail.Text == "")
            {
                arguments += "&missingEmail=true";
            }
            if (inputEmail.Text.Length > 64 || inputEmail.Text.Length < 6)
            {
                arguments += "&emailLength=true";
            }
            if (!inputEmail.Text.Contains("@") || !inputEmail.Text.Contains("."))
            {
                arguments += "&wrongEmail=true";
            }
            if (inputPassword.Text == "")
            {
                arguments += "&missingPassword=true";
            }
            if (inputPassword.Text.Length > 31 || inputPassword.Text.Length < 6)
            {
                arguments += "&passwordLength=true";
            }
            if (inputPasswordRepeat.Text == "")
            {
                arguments += "&missingPasswordRepeat=true";
            }
            if (inputPasswordRepeat.Text.Length > 31 || inputPasswordRepeat.Text.Length < 6)
            {
                arguments += "&passwordRepeatLength=true";
            }
            if (inputPassword.Text != inputPasswordRepeat.Text)
            {
                arguments += "&passwordMismatch=true";
            }
            Response.Redirect("addUser.aspx?errors=true" + arguments);
        }
    }
}