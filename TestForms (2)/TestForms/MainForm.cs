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
    public partial class MainForm : Form
    {
        CookieContainer logincookie = new CookieContainer();
        public MainForm()
        {
            InitializeComponent();
            webLoginLookup.Navigate("http://sugang.donga.ac.kr/login.aspx");
            timer1.Start();
            timer1.Interval = 1000;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textTime.Text = System.DateTime.Now.ToString();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Delete))
            {
                TextBox[] textBoxes = { textPack0, textPack1,textPack2, textPack3, textPack4, textPack5, textPack6, textPack7,
                                        textClass0,textClass1,textClass2,textClass3,textClass4,textClass5,textClass6,textClass7};
                for (int i = 0; i < 16; i++) textBoxes[i].Text = string.Empty;
                return true;
            }
            if (keyData == (Keys.F1))
            {
                ServerTime serverForm = new ServerTime();
                serverForm.Show();
                return true;
            }
            if (keyData == (Keys.F2))
            {
                ResultForm resultForm = new ResultForm();
                resultForm.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void Search()
        {
            int count = 0;
            HtmlDocument URL = webPaser.Document;
            HtmlElement str1 = URL.GetElementById("reglisthead");
            HtmlElementCollection str2 = str1.GetElementsByTagName("td");
            List<string> myList = new List<string>();
            foreach (HtmlElement result in str2)
            {
                if (count >= 22)
                {
                    if (result.InnerText == null)
                    {
                        result.InnerText = "　";
                        myList.Add(result.InnerText);
                        count++;
                    }
                    else
                    {
                        myList.Add(result.InnerText);
                        count++;
                    }
                }
                else count++;
            }
            for (int i = 0; i < myList.Count - 21; i += 22)
            {
                ///접어두기
                listBox1.Items.Add("수강학과 : " + myList[i]);
                listBox1.Items.Add("학년 : " + myList[i + 1]);
                listBox1.Items.Add("이수구분 : " + myList[i + 2]);
                listBox1.Items.Add("과목번호 : " + myList[i + 3]);
                listBox1.Items.Add("분반 : " + myList[i + 4]);
                listBox1.Items.Add("교과목명 : " + myList[i + 5]);
                listBox1.Items.Add("학점 : " + myList[i + 7]);
                listBox1.Items.Add("담당교수 : " + myList[i + 9]);
                listBox1.Items.Add("인원제한 : " + myList[i + 17]);
                listBox1.Items.Add("수강인원 : " + myList[i + 18]);
                listBox1.Items.Add("강의시간 : " + myList[i + 20]);
                listBox1.Items.Add("------------------------------------------------");
            }
        }
        public bool HttpSugangLogin(string id, string pw) //HttpSocket 
        {
            try
            {
                string url = "https://sugang.donga.ac.kr/login.aspx";
                string __VIEWSTATE = "%2FwEPDwUJNzgzNjcxOTI4D2QWAmYPZBYEAgkPDxYCHgdWaXNpYmxlaGRkAg0PDxYCHgRUZXh0BQMgODhkZBgBBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WAQUJaWJ0bkxvZ2luyHCPtKblhMl3QkKo5cIkST%2B8aUAlGprdvHUZWxK%2FI%2BA%3D";
                string __VIEWSTATEGENERATOR = "C2EE9ABB";
                string __EVENTVALIDATION = "%2FwEdAAR3IFVVZjuvAyRPJoWOlZEiK9OpD%2F4BabzZG4Mj6Icm1Sgq%2FJ5fdAFrs2%2B61ovZadgwW%2FSA9QjRlUx7oMqQGV%2BEb4Ku26kSQtEIA3txfCb5wX%2B7WdCOvLgB7jLOEeA3L7g%3D";
                string postData = "txtStudentCd=" + id + "&txtPasswd=" + pw + "&__VIEWSTATE=" + __VIEWSTATE + "&__VIEWSTATEGENERATOR=" + __VIEWSTATEGENERATOR + "&__EVENTVALIDATION=" + __EVENTVALIDATION +
                                    "&ibtnLogin.x=0&ibtnLogin.y=0";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                byte[] sendData = Encoding.ASCII.GetBytes(postData);

                req.Method = "POST";
                req.KeepAlive = true;
                req.Referer = "https://sugang.donga.ac.kr";
                req.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = sendData.Length;
                req.CookieContainer = logincookie;

                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(sendData, 0, sendData.Length);
                    stream.Close();
                }

                HttpWebResponse webResponse = (HttpWebResponse)req.GetResponse();

                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = webResponse.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                    string strResult = streamReader.ReadToEnd();
                    if (strResult.Contains("학부 수강신청"))
                    {
                   
                        webResponse.Close();
                        streamReader.Close();
                        responseStream.Close();

                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            catch (Exception et)
            {
                MessageBox.Show("잘못된 로그인경로", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void WebbrowserLogin(string id, string pw)
        {
            webLoginLookup.Document.GetElementById("txtStudentCd").InnerText = textID.Text.ToString();
            webLoginLookup.Document.GetElementById("txtPasswd").InnerText = textPasswd.Text.ToString();
            webLoginLookup.Document.GetElementById("ibtnLogin").InvokeMember("click");

        }

        //public string ComboBoxItem2()
        //{
        //    int sel = comboBox2.SelectedIndex;
        //    String txt = comboBox2.SelectedItem as String;
        //    string msg = string.Empty;
        //    string value = string.Empty;
        //    if (sel > -1)
        //        msg = string.Format(txt);
        //    if (msg == "1학기") value = "10";
        //    else if (msg == "하계") value = "11";
        //    else if (msg == "하계2차") value = "12";
        //    else if (msg == "2학기") value = "20";
        //    else if (msg == "동계") value = "21";
        //    return value;
        //}

        public string ComboBoxItem()
        {
            int sel = comboBox1.SelectedIndex;
            String txt = comboBox1.SelectedItem as String;
            string msg = string.Empty;
            string value = string.Empty;
            if (sel > -1)
                msg = string.Format(txt);
            if (msg == "인문과학대학") value = "4100";
            else if (msg == "자연과학대학") value = "4200";
            else if (msg == "생활과학대학") value = "4250";
            else if (msg == "법과대학") value = "4300";
            else if (msg == "사회과학대학") value = "4400";
            else if (msg == "경영대학") value = "4500";
            else if (msg == "생명자원과학대학") value = "4600";
            else if (msg == "공과대학") value = "4700";
            else if (msg == "건축디자인패션대학") value = "4D00";
            else if (msg == "디자인환경대학") value = "4E00";
            else if (msg == "예술체육대학") value = "4F00";
            else if (msg == "스포츠과학대학") value = "4850";
            else if (msg == "예술대학") value = "4900";
            else if (msg == "건강과학대학") value = "4G00";
            else if (msg == "의과대학") value = "4A00";
            else if (msg == "글로벌비즈니스대학") value = "4H00";
            else if (msg == "융합교양대학") value = "4JO0";
            else if (msg == "기초교양대학") value = "4K00";
            else if (msg == "중국일본학부") value = "4I00";
            else if (msg == "석당인재학부") value = "4B00";
            else if (msg == "국제학부") value = "4000";
            else if (msg == "자기설계연계") value = "4L00";
            return value;
        }
        public void SendData(TextBox[] Subject, TextBox[] ClassNum)
        {
            //수강신청 서버가 열리는날 패킷분석 새로해야함
            if (string.IsNullOrEmpty(textPack0.Text) && string.IsNullOrEmpty(textPack1.Text) && string.IsNullOrEmpty(textPack2.Text) && string.IsNullOrEmpty(textPack3.Text) && string.IsNullOrEmpty(textPack4.Text) && string.IsNullOrEmpty(textPack5.Text) && string.IsNullOrEmpty(textPack6.Text) && string.IsNullOrEmpty(textPack7.Text))
            {
                MessageBox.Show("교과목정보를 하나라도 입력해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 0;
            listBox1.Items.Clear();
            string url = "http://sugang.donga.ac.kr/SUGANG030.aspx";
            for (i = 0; i < 8; i++)
            {
                if (string.IsNullOrEmpty(Subject[i].Text)) continue;
                string postData = "curi=" + Subject[i].Text.ToString() + "&cls=" + ClassNum[i].Text.ToString() + "&cmd=&mode=";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                byte[] sendData = Encoding.ASCII.GetBytes(postData);

                req.Method = "POST";
                req.KeepAlive = true;
                req.Referer = "https://sugang.donga.ac.kr";
                req.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = sendData.Length;
                req.CookieContainer = logincookie;

                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(sendData, 0, sendData.Length);
                    stream.Close();
                }

                HttpWebResponse webResponse = (HttpWebResponse)req.GetResponse();

                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = webResponse.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                    string strResult = streamReader.ReadToEnd();
        
                    if (strResult.Contains("신청하신 과목을 저장 하였습니다."))
                    {
                        listBox1.Items.Add(DateTime.Now.ToString("[HH:mm:ss] :코드[") + Subject[i].Text.ToString() + "] 분반[" + ClassNum[i].Text.ToString() + "]신청완료!");
                        webResponse.Close();
                        streamReader.Close();
                        responseStream.Close();
                    }
                    else if (strResult.Contains("이미 수강신청되어 있습니다."))
                    {
                        listBox1.Items.Add(DateTime.Now.ToString("[HH:mm:ss] :코드[") + Subject[i].Text.ToString() + "] 분반[" + ClassNum[i].Text.ToString() + "] 이미 신청됨.");
                        webResponse.Close();
                        streamReader.Close();
                        responseStream.Close();
                    }
                    else if (strResult.Contains("수강신청인원 초과입니다."))
                    {
                        listBox1.Items.Add(DateTime.Now.ToString("[HH:mm:ss] :코드[") + Subject[i].Text.ToString() + "] 분반[" + ClassNum[i].Text.ToString() + "] 인원초과ㅠㅠ.");
                        webResponse.Close();
                        streamReader.Close();
                        responseStream.Close();
                    }
                    else if (strResult.Contains("수강신청기간이 아닙니다."))
                    {
                        MessageBox.Show("서버가 닫혀있습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else return;
            }

            listBox1.Items.Add("------------------------------------------------");
            listBox1.Items.Add("데이터 전송중 예외가 발생했을수도 있습니다.");
            listBox1.Items.Add("신청안된 과목 있는지 꼭 확인하세요!!");
            listBox1.Items.Add("------------------------------------------------");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textID.Text) || string.IsNullOrEmpty(textPasswd.Text))
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 입력해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Login_button.Text = "Wait..";
                textID.Enabled = false;
                textPasswd.Enabled = false;
                Login_button.Enabled = false;
                bool loginStatus = HttpSugangLogin(textID.Text, textPasswd.Text);
                WebbrowserLogin(textID.Text, textPasswd.Text);
                if (loginStatus)
                {
                  //  MessageBox.Show("잘못된 로그인경로", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     MessageBox.Show("로그인 성공");
                    textPack0.Text = Properties.Settings.Default.Pack0;
                    textPack1.Text = Properties.Settings.Default.Pack1;
                    textPack2.Text = Properties.Settings.Default.Pack2;
                    textPack3.Text = Properties.Settings.Default.Pack3;
                    textPack4.Text = Properties.Settings.Default.Pack4;
                    textPack5.Text = Properties.Settings.Default.Pack5;
                    textPack6.Text = Properties.Settings.Default.Pack6;
                    textPack7.Text = Properties.Settings.Default.Pack7;
                    textClass0.Text = Properties.Settings.Default.Class0;
                    textClass1.Text = Properties.Settings.Default.Class1;
                    textClass2.Text = Properties.Settings.Default.Class2;
                    textClass3.Text = Properties.Settings.Default.Class3;
                    textClass4.Text = Properties.Settings.Default.Class4;
                    textClass5.Text = Properties.Settings.Default.Class5;
                    textClass6.Text = Properties.Settings.Default.Class6;
                    textClass7.Text = Properties.Settings.Default.Class7;
                    checkBox1.Enabled = true;
                    comboBox1.Enabled = true;
                    button2.Enabled = true;
                    Login_button.Text = "로그인";
                }
                else
                {
                    MessageBox.Show("로그인 실패", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login_button.Text = "로그인";
                    textID.Enabled = true;
                    textPasswd.Enabled = true;
                    Login_button.Enabled = true;
                }
                if (webLoginLookup.Url.ToString() == "http://sugang.donga.ac.kr/main.aspx")
                {
                    webLoginLookup.Navigate("http://sugang.donga.ac.kr/SUGANGLECTIME.aspx"); // 1은 강의시간표 조회
                    webPaser.Navigate("http://sugang.donga.ac.kr/SUGANGLECTIME.aspx"); //3은 파싱용 강의시간표 조회
                }
                else
                {
                    //로컬영역 끊겼을시,딜레이때문에 접속못했을시 재접속
                    webLoginLookup.Navigate("http://sugang.donga.ac.kr/login.aspx");
                }
            }
            catch (Exception ex) //로컬연결 제한 or 서버 소켓통신 불가시 예외처리
            {
                Login_button.Text = "로그인";
                textID.Enabled = true;
                textPasswd.Enabled = true;
                Login_button.Enabled = true;
                webLoginLookup.Navigate("http://sugang.donga.ac.kr/login.aspx");
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textSbj = { textPack0, textPack1, textPack2, textPack3, textPack4, textPack5, textPack6, textPack7 };
                TextBox[] textNum = { textClass0, textClass1, textClass2, textClass3, textClass4, textClass5, textClass6, textClass7 };
                SendData(textSbj, textNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버가 닫혀있습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            TextBox[] box = {textID,textPasswd,textPack0,textPack1,textPack2,textPack3,textPack4,textPack5,textPack6,textPack7,
                             textClass0,textClass1,textClass2,textClass3,textClass4,textClass5,textClass6,textClass7};

            Properties.Settings.Default.Id = textID.Text;
            Properties.Settings.Default.Passwd = textPasswd.Text;
            Properties.Settings.Default.Pack0 = textPack0.Text;
            Properties.Settings.Default.Pack1 = textPack1.Text;
            Properties.Settings.Default.Pack2 = textPack2.Text;
            Properties.Settings.Default.Pack3 = textPack3.Text;
            Properties.Settings.Default.Pack4 = textPack4.Text;
            Properties.Settings.Default.Pack5 = textPack5.Text;
            Properties.Settings.Default.Pack6 = textPack6.Text;
            Properties.Settings.Default.Pack7 = textPack7.Text;
            Properties.Settings.Default.Class0 = textClass0.Text;
            Properties.Settings.Default.Class1 = textClass1.Text;
            Properties.Settings.Default.Class2 = textClass2.Text;
            Properties.Settings.Default.Class3 = textClass3.Text;
            Properties.Settings.Default.Class4 = textClass4.Text;
            Properties.Settings.Default.Class5 = textClass5.Text;
            Properties.Settings.Default.Class6 = textClass6.Text;
            Properties.Settings.Default.Class7 = textClass7.Text;
            Properties.Settings.Default.Save();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] univercity = {"대학을 선택해주세요","인문과학대학","자연과학대학","생활과학대학","법과대학","사회과학대학","경영대학","생명자원과학대학",
                                   "공과대학","건축디자인패션대학","디자인환경대학","예술체육대학","스포츠과학대학","예술대학",
                                   "건강과학대학","의과대학","글로벌비즈니스대학","융합교양대학","기초교양대학","중국일본학부",
                                   "석당인재학부","국제학부","자기설계연계"};

            for (int i = 0; i < 23; i++) comboBox1.Items.Add(univercity[i]);
            textID.Text = Properties.Settings.Default.Id;
            textPasswd.Text = Properties.Settings.Default.Passwd;
        }
        /// <summary>
        /// 이벤트들
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textPack0_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack0.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack0.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void textPack1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack1.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack1.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void textPack2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack2.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack2.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void textPack3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack3.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack3.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void textPack4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack4.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack4.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void textPack5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack5.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack5.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }

        }
        private void textPack6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack6.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack6.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }

        }
        private void textPack7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textPack7.Text)) return;
                else if (comboBox1.Text.ToString() == "대학을 선택해주세요" || comboBox1.Text.ToString() == string.Empty) return;
                else
                {
                    string value = ComboBoxItem();
                    webPaser.Document.GetElementById("ddlColl").SetAttribute("value", value);
                    webPaser.Document.GetElementById("txtCuri").InnerText = textPack7.Text.ToString();
                    webPaser.Document.GetElementById("ibtnSearch").InvokeMember("click");
                    Search();
                }
            }
            catch (Exception et)
            {
                return;
            }
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) this.Size = new Size(1200, 588);
            else this.Size = new Size(320, 588);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            HowUse howUse = new HowUse();
            howUse.Show();
        }
    }
}
