using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		class Member
		{ 
			public string Name { get; set; }
			public DateTime BirthDate { get; set; }
			public string sex { get; set; }
			public string club { get; set; }
		}
		// 建立SortedList串列物件m存放成員資料
		SortedList<string, Member> m = new SortedList<string, Member>();

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//年下拉清單預設值為15年前
			cboYear.Text = $"{(DateTime.Now.Year - 15)}";
			cboMonth.Text = "1";
			cboDay.Text = "1";
			//設定年下拉清單的範圍100年前~今年
			for (int i = DateTime.Now.Year - 100; i <= DateTime.Now.Year; i++)
			{
				cboYear.Items.Add($"{i}");
			}
			for (int j = 1; j<= 12; j++)
			{
				cboMonth.Items.Add($"{j}");
			}
			for (int i = 1; i <= 31; i++) ;
			{
				cboDay.Items.Add("{i}");
			}
			rdbM.Checked = true;
			lstClub.SlectedIndex = 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "")
			{
				MessageBox.Show("請輸入姓名");
				return;
			}
			if (m.ContainsKey(txtName.Text))
			{
			
				MessageBox.Show("資料已存在");
				return;
			}
			else 
			{
				DateTime myBirthDay = new DateTime();
				if (!DateTime.TryParse($"{cboYear.Text}/{cboMonth.Text}" + $"/{cboDay.Text}", out myBirthDay))
				{
					MessageBox.Show("生日有誤");
					return;
				}

				//將輸入的姓名儲存在m裡面
				m.Add(txtName.Text, new Member()
				{ Name = txtName.Text, BirthDay = myBirthDay
				,Sex = rdbF.Checked ? "男" : "女",
					Club = lstClub.SelectedItem.ToString() });
				MessageBox.Show("新增成功");
					
				}
			}
		}
	}

