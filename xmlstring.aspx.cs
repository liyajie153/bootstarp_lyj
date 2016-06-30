using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Reflection;
using System.Collections;
using WareDict;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

public partial class xmlstring : System.Web.UI.Page
{
    public string xmlSer() 
    {
        List<test> list = new List<test>()
        {
            new test() { name = "abc", age = "123" },
            new test() { name = "aaa", age = "444" }
        };
         
        main m1 = new main();
        m1.m = list;

        StringWriter sw = new StringWriter();
      //  XmlTextWriter xw = new XmlTextWriter();
        //创建XML命名空间
        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        ns.Add("", "");
        XmlSerializer serializer = new XmlSerializer(typeof(main));
        serializer.Serialize(sw, m1, ns);
        sw.Close();

       return sw.ToString();
    }
    public object xmlDSer(string xml)
    {
      
        XmlSerializer serializer = new XmlSerializer(typeof(main));
        MemoryStream ms2 = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        StreamReader sr = new StreamReader(ms2, Encoding.UTF8);

        main m2 = (main)serializer.Deserialize(sr);
        return m2;
    }
    public string SerializeOverride()
    {
        using (MemoryStream ms = new MemoryStream())
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Encoding = Encoding.UTF8;
            XmlWriter utf8wr = XmlWriter.Create(ms, xmlSetting);
            XmlAttributes myAttributes = new XmlAttributes();
            XmlElementAttribute myElementAttribute = new XmlElementAttribute();
            myElementAttribute.ElementName = "BookID";
            //XmlElementAttribute myElementAttribute2 = new XmlElementAttribute();
            //myElementAttribute2.ElementName = "BookAge";
            myAttributes.XmlElements.Add(myElementAttribute);
            //myAttributes.XmlElements.Add(myElementAttribute2);
            XmlAttributeOverrides myOverrides = new XmlAttributeOverrides();
            //myOverrides.Add(typeof(test), myAttributes);
           myOverrides.Add(typeof(test), "age", myAttributes);
            XmlSerializer mySerializer = new XmlSerializer(typeof(test), myOverrides);
            test t = new test();
            t.name = "李亚杰";
            t.age = "25";
            mySerializer.Serialize(utf8wr, t, ns);
            string strtmp = Encoding.UTF8.GetString(ms.ToArray());
            return strtmp;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        lblType.Text = "<a href=\"Default.aspx\">123</a>";
        SerializeOverride();
        string xmlstr = xmlSer();
        main mm = xmlDSer(xmlstr) as main;
        List<test> list = new List<test>()
        {
            new test() { name = "abc", age = "123" },
            new test() { name = "aaa", age = "444" }
        };
        string s2 = "中国人";
        main m1 = new main();
        m1.m = list;
        test t = new test() { name = "abc", age = "123" };
        XmlSerializer xml = new XmlSerializer(typeof(main));
        MemoryStream ms = new MemoryStream();
        string ss = "";
        XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
        xml.Serialize(writer, m1);
        ms.Position = 0;
        using (StreamReader reader = new StreamReader(ms, Encoding.UTF8))
        {
            ss = reader.ReadToEnd();
        }
        writer.Close();
        byte[] b = new byte[Encoding.UTF8.GetBytes(s2).Length];
        byte[] b2 = new byte[Encoding.UTF8.GetBytes(s2).Length];
        Encoding.UTF8.GetBytes(s2, 1, 1, b, 0); ;
        Encoding.UTF8.GetBytes(s2, 0, s2.Length, b2, 0);
        MemoryStream ms2 = new MemoryStream(Encoding.UTF8.GetBytes(ss));
        using (StreamReader sr = new StreamReader(ms2, Encoding.UTF8))
        {
            main m2 = (main)xml.Deserialize(sr);
        }
        // string ss = Encoding.UTF8.GetString(ms.ToArray());
        //IFormatter formatter = new BinaryFormatter();


        //test t = new test() { name = "abc", age = "123" };
        DataTable result = new DataTable();

        PropertyInfo[] propertys = t.GetType().GetProperties();
        foreach (PropertyInfo pi in propertys)
        {
            result.Columns.Add(pi.Name, pi.PropertyType);
        }
        for (int i = 0; i < list.Count; i++)
        {
            ArrayList tempList = new ArrayList();
            foreach (PropertyInfo pi in propertys)
            {
                object obj = pi.GetValue(list[i], null);
                tempList.Add(obj);
            }
            object[] array = tempList.ToArray();
            result.Rows.Add(array);
        }
        string s = "";
    }
   [XmlRoot("Ml")]
    public class main
    {
       [XmlArray("TeamMembers"),XmlArrayItem("items")]
        public List<test> m
        { get; set; }
    }
    public class test
    {
        public string name { get; set; }
      
        public string age { get; set; }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        List<test> list = new List<test>()
        {
            new test() { name = "abc", age = "123" },
            new test() { name = "aaa", age = "444" }
        };

        main m1 = new main();
        m1.m = list;
        XmlSerializer serializer = new XmlSerializer(typeof(main));
        string path = Server.MapPath("~/Scripts");
        using (FileStream file = new FileStream(path+"/Test.xml", FileMode.Create, FileAccess.ReadWrite)) 
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;
            xmlSetting.NewLineChars = "\r\n";
            xmlSetting.Encoding = Encoding.UTF8;
            xmlSetting.IndentChars = "    ";
            using (XmlWriter utf8wr = XmlWriter.Create(file, xmlSetting)) 
            {
                serializer.Serialize(utf8wr, m1);
               
                utf8wr.Close();
            }
         
        }
        string xmlStr = File.ReadAllText(path + "/Test.xml", Encoding.UTF8);
        // byte[] fileBuffer = new byte[file.Length];
        //file.Read(fileBuffer, 0, fileBuffer.Length);
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=qwe.xml");
        Response.AddHeader("Content-Length", Encoding.UTF8.GetBytes(xmlStr).Length.ToString());
        Response.WriteFile(Encoding.UTF8.GetBytes(xmlStr));
        Response.Flush();
        Response.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(main));
        string path = Server.MapPath("~/Scripts/Test.xml");
        string xml = File.ReadAllText(path, Encoding.UTF8);
        MemoryStream ms2 = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        StreamReader sr = new StreamReader(ms2, Encoding.UTF8);
        main m2 = (main)serializer.Deserialize(sr);
        byte[] fileBuffer = new byte[ms2.Length];
        ms2.Read(fileBuffer, 0, fileBuffer.Length);
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=qwe.xml");
        Response.AddHeader("Content-Length", ms2.Length.ToString());
        Response.BinaryWrite(fileBuffer);
        Response.Flush();
        Response.Close();
        }
}