using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			File.AppendAllText("a.txt", $"{textBox1.Text},{textBox2.Text}\r\n");
			label3.Text = $"{textBox1.Text}會員註冊成功";

			List<string> myList = File.ReadAllLines("a.txt").ToList();
			foreach (string who in myList)
			{
				List<string> myList2 = who.Split(',').ToList();
				List2(myList2[0], myList2[1]);
			}
		}

		void List2(string a, string b)
		{
			textBox4.Text += $"帳號: {a}\r\n密碼: {b}\r\n";
		}
	}
}