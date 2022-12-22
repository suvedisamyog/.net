using System;
namespace bookformproject{
    public partial class add : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e) { }
         protected void Save_Click(object sender, EventArgs e){
            Session["name"]=name.Text;
            Session["isbn"]=isbn.Text;
            Session["writer"]=writer.Text;
            Session["publication"]=publication.Text;
            Response.Redirect("display.aspx");
        }
    }
}