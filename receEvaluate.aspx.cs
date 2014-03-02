using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class receEvaluate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FileInfo f = new FileInfo(Server.MapPath("./evaluate.txt"));

        using (StreamWriter sw = f.CreateText())
        {
            sw.Write("userno:" + Request["userno"] + "\r\n");
            sw.Write("evaluate:" + Request["evaluate"] + "\r\n");
            sw.Write("clientno:" + Request["clientno"] + "\r\n");
            sw.Write("clientname:" + Request["clientname"] + "\r\n");
            sw.Write("img:" + Request["img"] + "\r\n");
            sw.Close();
        }


    }
}