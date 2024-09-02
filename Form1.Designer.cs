namespace WindowsFormsApp3
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboMonth = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboDay = new System.Windows.Forms.ComboBox();
			this.rdbM = new System.Windows.Forms.RadioButton();
			this.rdbF = new System.Windows.Forms.RadioButton();
			this.lstClub = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label1.Location = new System.Drawing.Point(83, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "生日";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label2.Location = new System.Drawing.Point(83, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "姓名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label3.Location = new System.Drawing.Point(78, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = " 性別";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label4.Location = new System.Drawing.Point(83, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "社團";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(137, 79);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(165, 22);
			this.txtName.TabIndex = 3;
			// 
			// cboYear
			// 
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Location = new System.Drawing.Point(137, 142);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(91, 20);
			this.cboYear.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label5.Location = new System.Drawing.Point(234, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "年";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label6.Location = new System.Drawing.Point(366, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 24);
			this.label6.TabIndex = 7;
			this.label6.Text = "月";
			// 
			// cboMonth
			// 
			this.cboMonth.FormattingEnabled = true;
			this.cboMonth.Location = new System.Drawing.Point(269, 142);
			this.cboMonth.Name = "cboMonth";
			this.cboMonth.Size = new System.Drawing.Size(91, 20);
			this.cboMonth.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label7.Location = new System.Drawing.Point(498, 142);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 24);
			this.label7.TabIndex = 9;
			this.label7.Text = "日";
			// 
			// cboDay
			// 
			this.cboDay.FormattingEnabled = true;
			this.cboDay.Location = new System.Drawing.Point(401, 142);
			this.cboDay.Name = "cboDay";
			this.cboDay.Size = new System.Drawing.Size(91, 20);
			this.cboDay.TabIndex = 8;
			// 
			// rdbM
			// 
			this.rdbM.AutoSize = true;
			this.rdbM.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.rdbM.Location = new System.Drawing.Point(137, 212);
			this.rdbM.Name = "rdbM";
			this.rdbM.Size = new System.Drawing.Size(47, 28);
			this.rdbM.TabIndex = 10;
			this.rdbM.TabStop = true;
			this.rdbM.Text = "男";
			this.rdbM.UseVisualStyleBackColor = true;
			this.rdbM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rdbF
			// 
			this.rdbF.AutoSize = true;
			this.rdbF.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.rdbF.Location = new System.Drawing.Point(190, 212);
			this.rdbF.Name = "rdbF";
			this.rdbF.Size = new System.Drawing.Size(47, 28);
			this.rdbF.TabIndex = 11;
			this.rdbF.TabStop = true;
			this.rdbF.Text = "女";
			this.rdbF.UseVisualStyleBackColor = true;
			this.rdbF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// lstClub
			// 
			this.lstClub.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.lstClub.FormattingEnabled = true;
			this.lstClub.ItemHeight = 24;
			this.lstClub.Items.AddRange(new object[] {
            "管樂社",
            "康輔社",
            "電影社",
            "音樂社",
            "其他"});
			this.lstClub.Location = new System.Drawing.Point(143, 287);
			this.lstClub.Name = "lstClub";
			this.lstClub.Size = new System.Drawing.Size(235, 124);
			this.lstClub.TabIndex = 12;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(417, 344);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "新增";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(417, 388);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 14;
			this.btnEnd.Text = "結束";
			this.btnEnd.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lstClub);
			this.Controls.Add(this.rdbF);
			this.Controls.Add(this.rdbM);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cboDay);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboMonth);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboYear);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Fom1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboMonth;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboDay;
		private System.Windows.Forms.RadioButton rdbM;
		private System.Windows.Forms.RadioButton rdbF;
		private System.Windows.Forms.ListBox lstClub;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEnd;
	}
}

