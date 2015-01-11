using System;
using System.Collections.Generic;
using System.ComponentModel;
using SHDocVw;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace ComboboxAttacker2
{


    public partial class Form1 : Form, DWebBrowserEvents
    {


        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetCookie(string url, string name, string data);

        private System.Runtime.InteropServices.UCOMIConnectionPoint icp;
        private int cookie = -1;

        int oldwidth;
        int oldheight;

        public Form1()
        {

            skip1 = false;
            skip2 = false;
            InitializeComponent();

            System.Runtime.InteropServices.UCOMIConnectionPointContainer icpc = (System.Runtime.InteropServices.UCOMIConnectionPointContainer)axWebBrowser1.GetOcx(); // ADDed

            Guid g = typeof(DWebBrowserEvents).GUID;
            icpc.FindConnectionPoint(ref g, out icp);
            icp.Advise(this, out cookie);
		
           
        }

        void navigate1(string s)
        {
            object flags = 0;
            object s1 = s;
            object flags1 = String.Empty;
            object targetFrame = String.Empty;
            object postData = String.Empty;
            object headers = String.Empty;
            this.axWebBrowser1.Navigate( s, ref flags1, ref targetFrame, ref postData, ref headers);



        }



        string url21;
        int flags21;
        string targetframe21;
        string postdata21;
        string headers21;
        bool call21;
        bool skip1;
        bool skip2;
        string cookie22;

        void axWebBrowser1_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            cookie22 = ((mshtml.IHTMLDocument2)axWebBrowser1.Document).cookie;
            Globals.cookies3 = cookie22;
            
        }

        string beforeq(string s)
        {
            bool b = false;
            string sa = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "?") { b = true; }
                if (b == false)
                {
                    if (s[i].ToString() != "?")
                    {
                        sa += s[i].ToString();
                    }
                }
            }
            return sa;
        }

        string beforelastslash(string s2)
        {
            string s = s2;
            s = beforeq(s);
            bool b = false;
            int i = -1;
            for (int i2 = s.Length - 1; i2 >= 0; i2--)
            {
                if (b == false)
                {
                    if (s[i2].ToString() == "/")
                    {
                        b = true;
                        i = i2;
                    }
                }
            }

            if (i == -1) { i = s.Length-1; }
            string sa = "";
            for (int i3 = 0; i3 <= i; i3++)
            {
                sa += s[i3].ToString();
            }
            return sa;
        }

        string beforeequals(string s)
        {
            bool b = false;
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i].ToString() == "=") && (b == false))
                {
                    b = true;
                }
                else
                {
                    if (b == false)
                    {
                        s1 += s[i].ToString();
                    }
                }
            }

            return s1;
        }


        string afterequals(string s)
        {
            bool b = false;
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i].ToString() == "=") && (b == false))
                {
                    b = true;
                }
                else
                {
                    if (b == true)
                    {
                        s1 += s[i].ToString();
                    }
                }
            }

            return s1;
        }

        void navigate20(string url20, int flags20, string targetframe20, string postdata20, string headers20)
        {
            object flags = flags20;
            object s1 = url20;
            object flags1 = flags20;
            object targetFrame= targetframe20;
            object postdata20b;

            postdata20b = (object)(StrToByteArray(postdata20));

            object headers = headers20;
            skip1 = true;

            if (Globals.cookies3 == null) { Globals.cookies3 = ""; }
            
            if (Globals.cookies3!="")
            {
                
                string[] cookies = Globals.cookies3.Split(';');
                string cook1;
                

                foreach (string cook in cookies)
                {
                    if (Globals.oldurl != "")
                    {
                        if (beforelastslash(Globals.oldurl) == beforelastslash(url20))
                        {
                            cook1 = cook.Trim();
                            InternetSetCookie(beforelastslash(Globals.oldurl), beforeequals(cook1), afterequals(cook1));
                            
                        }
                    }

                }
            }


            Globals.oldurl = url20;
            this.axWebBrowser1.Navigate(url20, ref flags1, ref targetFrame, ref postdata20b, ref headers);
            axWebBrowser1.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(axWebBrowser1_DocumentComplete);
            
            



        }

        bool oldfocused;

      

        private void url1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handlegoclick();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (url1.Focused != null)
            {
                oldfocused = url1.Focused;
            }
            else
            {
                oldfocused = false;
            }
            this.call21 = false;

            oldwidth = -1;
            oldheight = -1;
            this.Text = "Combobox Attacker";

        }

        public byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }



        public static string Encode(string str)
        {

            var charClass = String.Format("0-9a-zA-Z{0}", Regex.Escape("-_.!~*'()"));
            return Regex.Replace(str,
                String.Format("[^{0}]", charClass),
                new MatchEvaluator(EncodeEvaluator));
        }



        public static string EncodeEvaluator(Match match)
        {
            return (match.Value == " ") ? "+" : String.Format("%{0:X2}", Convert.ToInt32(match.Value[0]));
        }

        public static string DecodeEvaluator(Match match)
        {
            return Convert.ToChar(int.Parse(match.Value.Substring(1), System.Globalization.NumberStyles.HexNumber)).ToString();
        }

        public static string Decode(string str)
        {
            return Regex.Replace(str.Replace('+', ' '), "%[0-9a-zA-Z][0-9a-zA-Z]", new MatchEvaluator(DecodeEvaluator));
        }

        public void BeforeNavigate(string URL, int Flags, string TargetFrameName,
           ref object PostData, string Headers, ref bool Cancel)
        {
            skip2 = false;
            if (skip1 == true) { skip2 = true; skip1 = false; }


            if ((PostData!=null) || ((URL.IndexOf("?")!=-1)))
           {
               if (skip2 != true)
               {
                
                   System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
                   string s1="";
                   if (PostData != null)
                   {
                       s1 = UTF8.GetString((byte[])(PostData));
                   }
                   Globals.url3 = URL;
                   Globals.post3 = s1;
                   Globals.headers3 = Headers;
                   if (Globals.cookies3 == null) { Globals.cookies3 = ""; }
                   Globals.userclicked3 = "";
                   Dialog1 dialog1b = new Dialog1();
                   dialog1b.ShowDialog(this);

                   byte[] b;
               
                   if (Globals.userclicked3 == "cancel") { Cancel = true; Globals.userclicked3 = ""; }
                   else
                   {
                       PostData = ((object)(StrToByteArray(Globals.post3)));
                       string s1b = UTF8.GetString((byte[])(PostData));
                     
                     

                       Globals.userclicked3 = "";

                       url21 = Globals.url3;
                       postdata21 = s1b;
                       targetframe21 = TargetFrameName;
                       flags21 = Flags;
                       headers21 = Globals.headers3;

                       Cancel = true;
                       call21 = true;
                   }
               }
            }
        }

        public void PropertyChange(string Property) { }

        public void NavigateComplete(string URL) { this.url1.Text = URL; }

        public void WindowActivate() { }

        public void FrameBeforeNavigate(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Cancel) { }

        public void NewWindow(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Processed) { }

        public void FrameNewWindow(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Processed) { }

        public void TitleChange(string Text) { }

        public void DownloadBegin() { }

        public void DownloadComplete() { }

        public void WindowMove() { }

        public void WindowResize() { }

        public void Quit(ref bool Cancel) { }

        public void ProgressChange(int Progress, int ProgressMax) { }

        public void StatusTextChange(string Text) { }

        public void CommandStateChange(int Command, bool Enable) { }

        public void FrameNavigateComplete(string URL) { }

        private void axWebBrowser1_Enter(object sender, EventArgs e)
        {

        }


        void handleresize()
        {
            this.axWebBrowser1.Width=this.Width-60;
            this.axWebBrowser1.Height=this.Height-120;
            url1.Width = this.Width - 140;
            go1.Left = this.Width - 110;
            this.Left = this.Width - 100;
            Exit1b.Left = this.Width - 120;
            Exit1b.Top = this.Height - 70;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (url1.Focused != oldfocused)
            {
                oldfocused = url1.Focused;
                if (this.url1.Focused == false)
                {
                    handlegoclick();
                }
            }

            if ((this.Width!=oldwidth) || (this.Height!=oldheight))
            {
                oldheight=this.Height;
                oldwidth=this.Width;
                handleresize();
            }

            if (call21==true)
            {
                call21 = false;

                navigate20(url21, flags21, targetframe21, postdata21, headers21);
            }
        }

        void handlegoclick()
        {
            navigate1(this.url1.Text);
        }

        private void go1_Click(object sender, EventArgs e)
        {
            handlegoclick();
        }

        private void Exit1b_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        
        }

        private void url1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
