using System;
using System.Windows.Forms;

namespace NetFrameworkCheckDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            string sysversion = "";
            string checkversion = "4.5";
            if (!DotNetApi.GetDotNetVersion(checkversion, ref sysversion))
            {
                tbMsg.AppendText("当前DotNetFramework版本" + sysversion
                    + "未达到程序要求，请下载系统要求的DotNetFramework" + checkversion + "！\r\n");
            }
            else
            {
                tbMsg.AppendText("当前DotNetFramework版本为" + sysversion + ",可以正常使用程序！\r\n");
            }
        }

        private void btntest1_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicCallLib callLib = new DynamicCallLib("LibDotNet45", "Test", "getstring");
                string resstr = callLib.StaticCallResMethod<string>(new object[] { "我来试试" });
                tbMsg.AppendText(resstr + "\r\n");
            }
            catch (Exception ex)
            {
                tbMsg.AppendText(ex.Message + "\r\n");
            }
        }

        private void btntest2_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicCallLib callLib = new DynamicCallLib("LibDotNet45", "Test", "readint");
                callLib.CallvoidMethod(new object[] { 76 });
            }
            catch (Exception ex)
            {
                tbMsg.AppendText(ex.Message + "\r\n");
            }
        }

        private void btntest3_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicCallLib callLib = new DynamicCallLib("LibDotNet45", "Test", "getint");
                int qty = callLib.CallResMethod<int>();
                tbMsg.AppendText("得到的返回数为" + qty + "\r\n");
            }
            catch (Exception ex)
            {
                tbMsg.AppendText(ex.Message + "\r\n");
            }
        }

        private void btntest4_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicCallLib callLib = new DynamicCallLib("LibDotNet45", "Test", "resstring");
                string res = callLib.CallResMethod<string>(new object[] { "今天赚了多少钱？", 25.43f });
                tbMsg.AppendText("返回消息:" + res + "\r\n");
            }
            catch (Exception ex)
            {
                tbMsg.AppendText(ex.Message + "\r\n");
            }
        }
    }
}
