using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace 동아대수강신청도우미
{
    public partial class ServerTime : Form
    {

        //강의시간표 조회로 테스트
        public static string arr = "http://sugang.donga.ac.kr/SUGANG010.aspx";
        public static string arr2 = "http://sugang.donga.ac.kr/SUGANGLECTIME.aspx"; //test
        public ServerTime()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            webServerCheck.Navigate(arr); //강의시간표조회 
        }
        public int Server()
        {
            if (webServerCheck.Url.ToString() == arr)
            {
                return 1;
            }
            else if (webServerCheck.Url.ToString() == "https://sugang.donga.ac.kr/login.aspx")
            {
                return 3;
            }
            else
            {
                webServerCheck.Navigate(arr);
                return 2;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int result = Server();
            if (result==1)
            {
                 serverLogbox.Items.Add(System.DateTime.Now.ToString() + " 서버열림 ㄱㄱ!!!");
                 serverLogbox.SelectedIndex = serverLogbox.Items.Count - 1;
            }
            else if(result==2)
            {
                 serverLogbox.Items.Add(System.DateTime.Now.ToString() + " 서버닫힘");
                 serverLogbox.SelectedIndex = serverLogbox.Items.Count - 1;
            }
            else
            {
                 this.Close();
                 return;
            }
        }
    }
}


