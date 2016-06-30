using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<Act> list = new List<Act>() { new Act { id = 11, title = "后台登录" }, 
            new Act { id = 12, title = "密码修改" } };
        Response.Write(js.Serialize(list));
    }
    public class Act
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}