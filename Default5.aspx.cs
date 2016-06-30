using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITF_MedInfo;
using Newtonsoft.Json;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //content c = new content();
        //c.s = "lyj";
        //string s1 = JsonConvert.SerializeObject(c);
        //ITF_MedInfo.APPSCUX_OE_MEDICINE_X4661090X1X2 itf = new APPSCUX_OE_MEDICINE_X4661090X1X2();
        //itf.CREATEDATE = DateTime.Now;
        //itf.CREATEDATESpecified = true;
        //itf.CSTCODE = "2001";
        //itf.CSTNAME = "GY01";
        //itf.DEALID = 12;
        //itf.DEALIDSpecified = false;
        //itf.DEPTCODE = "s01";
        //itf.DEPTNAME = "GY";
        //itf.ENDDATE = DateTime.Now.AddDays(2);
        //itf.ENDDATESpecified = false;
        //itf.ERP_SALQTY = 40;
        //itf.ERP_SALQTYSpecified = false;
        //itf.ERPGOODS = "X20S0SA";
        //itf.GNAME = "Test";
        //itf.GOODS = "TESTGoods";
        //itf.GOODS_STATUS = "g";
        //itf.HOSCODE = "142";
        //itf.ID = 1;
        //itf.IDSpecified = false;
        //itf.INBILLNO = "202020111";
        //itf.LOTNO = "cv222";
        //itf.MARK = "";
        //itf.MSUNITNO = "";
        //itf.OWNERID = 10;
        //itf.OWNERIDSpecified = false;
        //itf.PACKNUM = 100;
        //itf.PACKNUMSpecified = false;
        //itf.PRC = 500;
        //itf.PRCSpecified = false;
        //itf.PRDDATE = DateTime.Now;
        //itf.PRDDATESpecified = false;
        //itf.PRODUCER = "aaa";
        //itf.SALBILLNO = "ssssaa";
        //itf.SALDATE = DateTime.Now;
        //itf.SALDATESpecified = false;
        //itf.SALQTY = 10;
        //itf.SALQTYSpecified = false;
        //itf.SALTYPESpecified = false;
        //itf.SALTYPE = 2;
        //itf.SIGN_DATE = DateTime.Now;
        //itf.SIGN_DATESpecified = false;
        //itf.WMS_UOM = "ssswww";
        //ITF_MedInfo.InputParameters inpt = new InputParameters();
        //ITF_MedInfo.OutputParameters outs = new OutputParameters();
       
        //inpt.P_MEDICINE_MSG_TBL = new APPSCUX_OE_MEDICINE_X4661090X1X2 []{ itf };
        //ITF_MedInfo.EBS_ITF_ImportMedicineInfo_pttbindingQSService service = new EBS_ITF_ImportMedicineInfo_pttbindingQSService();

        //outs = service.EBS_ITF_ImportMedicineInfo(inpt);
        
    }

    public class content
    {
        [JsonProperty(PropertyName = "ID")]
        public string s { get; set; }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filename = "201105";
        Response.Clear();
        Response.Buffer = false;
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("content-disposition", "attachment;filename=" + filename + ".log;");
        Response.Write("1234|ABCDE\r\n");
        int i = 0;
        // 读取数据库，循环
        for (i = 0; i < 100; i++)
        {
            Response.Write("1234|ABCDE\r\n");
        }
        Response.Flush();
        Response.End();
    }
}