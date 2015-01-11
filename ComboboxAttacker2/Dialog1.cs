using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboboxAttacker2
{
    public partial class Dialog1 : Form
    {
        public Dialog1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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


        private void Dialog1_Load(object sender, EventArgs e)
        {
            this.headers1.Text = Globals.headers3;
            this.postdata1.Text= Globals.post3;
            this.urldata1.Text=Globals.url3;
            this.Cookies.Text = Globals.cookies3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encoded1.Text = Encode(this.original1.Text);
        }

        private void postdata1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Globals.userclicked3 = "cancel";
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void OK1_Click_1(object sender, EventArgs e)
        {
            Globals.post3 = this.postdata1.Text;
            Globals.url3 = this.urldata1.Text;
            Globals.headers3 = this.headers1.Text;
            Globals.cookies3 = this.Cookies.Text;
            
            Globals.userclicked3 = "OK";
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
