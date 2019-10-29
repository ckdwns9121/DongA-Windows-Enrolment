namespace 동아대수강신청도우미
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textID = new System.Windows.Forms.TextBox();
            this.textPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webLoginLookup = new System.Windows.Forms.WebBrowser();
            this.Login_button = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textClass7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textPack7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textClass1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textClass6 = new System.Windows.Forms.TextBox();
            this.textPack6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textClass5 = new System.Windows.Forms.TextBox();
            this.textPack5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textClass4 = new System.Windows.Forms.TextBox();
            this.textPack4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textClass3 = new System.Windows.Forms.TextBox();
            this.textPack3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textClass2 = new System.Windows.Forms.TextBox();
            this.textPack2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPack1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPack0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textClass0 = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webPaser = new System.Windows.Forms.WebBrowser();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LoginBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(122, 38);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(160, 28);
            this.textID.TabIndex = 0;
            // 
            // textPasswd
            // 
            this.textPasswd.Location = new System.Drawing.Point(122, 72);
            this.textPasswd.Name = "textPasswd";
            this.textPasswd.Size = new System.Drawing.Size(160, 28);
            this.textPasswd.TabIndex = 1;
            this.textPasswd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "학번 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호 :";
            // 
            // webLoginLookup
            // 
            this.webLoginLookup.Location = new System.Drawing.Point(433, 28);
            this.webLoginLookup.MinimumSize = new System.Drawing.Size(20, 20);
            this.webLoginLookup.Name = "webLoginLookup";
            this.webLoginLookup.Size = new System.Drawing.Size(1260, 737);
            this.webLoginLookup.TabIndex = 6;
            this.webLoginLookup.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.Control;
            this.Login_button.Location = new System.Drawing.Point(288, 35);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(98, 70);
            this.Login_button.TabIndex = 7;
            this.Login_button.Text = "로그인";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.label1);
            this.LoginBox.Controls.Add(this.textID);
            this.LoginBox.Controls.Add(this.textPasswd);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.Login_button);
            this.LoginBox.Location = new System.Drawing.Point(12, 28);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(406, 126);
            this.LoginBox.TabIndex = 12;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "로그인정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textClass7);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textPack7);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textClass1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textClass6);
            this.groupBox2.Controls.Add(this.textPack6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textClass5);
            this.groupBox2.Controls.Add(this.textPack5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textClass4);
            this.groupBox2.Controls.Add(this.textPack4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textClass3);
            this.groupBox2.Controls.Add(this.textPack3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textClass2);
            this.groupBox2.Controls.Add(this.textPack2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textPack1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textPack0);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textClass0);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 369);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "교과목정보";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 52);
            this.button1.TabIndex = 39;
            this.button1.Text = "사용법";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 18);
            this.label18.TabIndex = 38;
            this.label18.Text = "⑧과목코드 :";
            // 
            // textClass7
            // 
            this.textClass7.Location = new System.Drawing.Point(321, 269);
            this.textClass7.Name = "textClass7";
            this.textClass7.Size = new System.Drawing.Size(65, 28);
            this.textClass7.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(279, -20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 18);
            this.label19.TabIndex = 16;
            this.label19.Text = "초기화 : Delete";
            // 
            // textPack7
            // 
            this.textPack7.Location = new System.Drawing.Point(122, 270);
            this.textPack7.Name = "textPack7";
            this.textPack7.Size = new System.Drawing.Size(116, 28);
            this.textPack7.TabIndex = 36;
            this.textPack7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack7_MouseDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 34;
            this.label16.Text = "⑦과목코드 :";
            // 
            // textClass1
            // 
            this.textClass1.Location = new System.Drawing.Point(321, 61);
            this.textClass1.Name = "textClass1";
            this.textClass1.Size = new System.Drawing.Size(65, 28);
            this.textClass1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(122, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "수강신청";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textClass6
            // 
            this.textClass6.Location = new System.Drawing.Point(321, 235);
            this.textClass6.Name = "textClass6";
            this.textClass6.Size = new System.Drawing.Size(65, 28);
            this.textClass6.TabIndex = 33;
            // 
            // textPack6
            // 
            this.textPack6.Location = new System.Drawing.Point(122, 235);
            this.textPack6.Name = "textPack6";
            this.textPack6.Size = new System.Drawing.Size(116, 28);
            this.textPack6.TabIndex = 32;
            this.textPack6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack6_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "⑥과목코드 :";
            // 
            // textClass5
            // 
            this.textClass5.Location = new System.Drawing.Point(321, 201);
            this.textClass5.Name = "textClass5";
            this.textClass5.Size = new System.Drawing.Size(65, 28);
            this.textClass5.TabIndex = 29;
            // 
            // textPack5
            // 
            this.textPack5.Location = new System.Drawing.Point(122, 201);
            this.textPack5.Name = "textPack5";
            this.textPack5.Size = new System.Drawing.Size(116, 28);
            this.textPack5.TabIndex = 28;
            this.textPack5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack5_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "⑤과목코드 :";
            // 
            // textClass4
            // 
            this.textClass4.Location = new System.Drawing.Point(321, 167);
            this.textClass4.Name = "textClass4";
            this.textClass4.Size = new System.Drawing.Size(65, 28);
            this.textClass4.TabIndex = 25;
            // 
            // textPack4
            // 
            this.textPack4.Location = new System.Drawing.Point(122, 167);
            this.textPack4.Name = "textPack4";
            this.textPack4.Size = new System.Drawing.Size(116, 28);
            this.textPack4.TabIndex = 24;
            this.textPack4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack4_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "④과목코드 :";
            // 
            // textClass3
            // 
            this.textClass3.Location = new System.Drawing.Point(321, 133);
            this.textClass3.Name = "textClass3";
            this.textClass3.Size = new System.Drawing.Size(65, 28);
            this.textClass3.TabIndex = 21;
            // 
            // textPack3
            // 
            this.textPack3.Location = new System.Drawing.Point(122, 133);
            this.textPack3.Name = "textPack3";
            this.textPack3.Size = new System.Drawing.Size(116, 28);
            this.textPack3.TabIndex = 20;
            this.textPack3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack3_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "③과목코드 :";
            // 
            // textClass2
            // 
            this.textClass2.Location = new System.Drawing.Point(321, 97);
            this.textClass2.Name = "textClass2";
            this.textClass2.Size = new System.Drawing.Size(65, 28);
            this.textClass2.TabIndex = 17;
            // 
            // textPack2
            // 
            this.textPack2.Location = new System.Drawing.Point(122, 97);
            this.textPack2.Name = "textPack2";
            this.textPack2.Size = new System.Drawing.Size(116, 28);
            this.textPack2.TabIndex = 16;
            this.textPack2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack2_MouseDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 18);
            this.label15.TabIndex = 15;
            this.label15.Text = "분반 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 18);
            this.label17.TabIndex = 15;
            this.label17.Text = "분반 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "분반 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "분반 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "분반 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "분반 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "분반 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "②과목코드 :";
            // 
            // textPack1
            // 
            this.textPack1.Location = new System.Drawing.Point(122, 61);
            this.textPack1.Name = "textPack1";
            this.textPack1.Size = new System.Drawing.Size(116, 28);
            this.textPack1.TabIndex = 12;
            this.textPack1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack1_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "①과목코드 :";
            // 
            // textPack0
            // 
            this.textPack0.Location = new System.Drawing.Point(122, 27);
            this.textPack0.Name = "textPack0";
            this.textPack0.Size = new System.Drawing.Size(116, 28);
            this.textPack0.TabIndex = 2;
            this.textPack0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPack0_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "분반 :";
            // 
            // textClass0
            // 
            this.textClass0.Location = new System.Drawing.Point(321, 27);
            this.textClass0.Name = "textClass0";
            this.textClass0.Size = new System.Drawing.Size(65, 28);
            this.textClass0.TabIndex = 11;
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textTime.ForeColor = System.Drawing.Color.Blue;
            this.textTime.Location = new System.Drawing.Point(184, 7);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(84, 18);
            this.textTime.TabIndex = 14;
            this.textTime.Text = "서버시간";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(6, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 202);
            this.listBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 262);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "강의정보 및 로그";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 18);
            this.label20.TabIndex = 19;
            this.label20.Text = "조회할 대학 선택";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 26);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "대학을 선택해주세요";
            // 
            // webPaser
            // 
            this.webPaser.Location = new System.Drawing.Point(500, 28);
            this.webPaser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPaser.Name = "webPaser";
            this.webPaser.Size = new System.Drawing.Size(20, 20);
            this.webPaser.TabIndex = 19;
            this.webPaser.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 22);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "강의시간표 조회";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 831);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.webPaser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.webLoginLookup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "동아대 수강신청 도우미";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webLoginLookup;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textClass7;
        private System.Windows.Forms.TextBox textPack7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textClass6;
        private System.Windows.Forms.TextBox textPack6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textClass5;
        private System.Windows.Forms.TextBox textPack5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textClass4;
        private System.Windows.Forms.TextBox textPack4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textClass3;
        private System.Windows.Forms.TextBox textPack3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textClass2;
        private System.Windows.Forms.TextBox textPack2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textClass1;
        private System.Windows.Forms.TextBox textPack1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textPack0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textClass0;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webPaser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label20;
    }
}

