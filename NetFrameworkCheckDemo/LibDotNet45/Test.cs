using System;
using System.Windows.Forms;

namespace LibDotNet45
{
    public class Test
    {

        public static string getstring(string input)
        {
            return input + "，我已经经收到，现在通知你一下";
        }

        public void readint(int qty)
        {
            MessageBox.Show("当前数字为" + qty);
        }

        public int getint()
        {
            return 10;
        }

        public string resstring(string input,float input2)
        {
            return "这是非静态的方法:" + input + "  参数2:" + input2;
        }
    }
}
