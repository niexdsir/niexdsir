﻿namespace StudentManager
{
    partial class kaisheForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxtime = new System.Windows.Forms.CheckedListBox();
            this.comboBoxdidian = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxterm = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxclass = new System.Windows.Forms.TextBox();
            this.textBoxteacher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxtime);
            this.groupBox1.Controls.Add(this.comboBoxdidian);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxterm);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxclass);
            this.groupBox1.Controls.Add(this.textBoxteacher);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(915, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开设课程";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkedListBoxtime
            // 
            this.checkedListBoxtime.FormattingEnabled = true;
            this.checkedListBoxtime.Items.AddRange(new object[] {
            "星期一第一节",
            "星期一第二节",
            "星期一第三节",
            "星期一第四节",
            "星期二第一节",
            "星期二第二节",
            "星期二第三节",
            "星期二第四节",
            "星期三第一节",
            "星期三第二节",
            "星期三第三节",
            "星期三第四节",
            "星期四第一节",
            "星期四第二节",
            "星期四第三节",
            "星期四第四节",
            "星期五第一节",
            "星期五第二节",
            "星期五第三节",
            "星期五第四节"});
            this.checkedListBoxtime.Location = new System.Drawing.Point(142, 182);
            this.checkedListBoxtime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxtime.Name = "checkedListBoxtime";
            this.checkedListBoxtime.Size = new System.Drawing.Size(219, 244);
            this.checkedListBoxtime.TabIndex = 13;
            // 
            // comboBoxdidian
            // 
            this.comboBoxdidian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdidian.FormattingEnabled = true;
            this.comboBoxdidian.Items.AddRange(new object[] {
            "教一101",
            "教一102",
            "教一103",
            "教一104",
            "教二102",
            "教二102",
            "教二103",
            "教二104",
            "教三101",
            "教三102",
            "教三103",
            "实验楼102",
            "实验楼101",
            "实验楼102"});
            this.comboBoxdidian.Location = new System.Drawing.Point(592, 128);
            this.comboBoxdidian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxdidian.Name = "comboBoxdidian";
            this.comboBoxdidian.Size = new System.Drawing.Size(209, 23);
            this.comboBoxdidian.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "上课地点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "上课时间";
            // 
            // comboBoxterm
            // 
            this.comboBoxterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxterm.FormattingEnabled = true;
            this.comboBoxterm.Items.AddRange(new object[] {
            "2019年春季学期",
            "2019年秋季学期",
            "2020年春季学期",
            "2020年秋季学期"});
            this.comboBoxterm.Location = new System.Drawing.Point(142, 125);
            this.comboBoxterm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxterm.Name = "comboBoxterm";
            this.comboBoxterm.Size = new System.Drawing.Size(209, 23);
            this.comboBoxterm.TabIndex = 8;
            this.comboBoxterm.SelectedIndexChanged += new System.EventHandler(this.comboBoxterm_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "开设课程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxclass
            // 
            this.textBoxclass.Location = new System.Drawing.Point(592, 57);
            this.textBoxclass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxclass.Name = "textBoxclass";
            this.textBoxclass.Size = new System.Drawing.Size(209, 25);
            this.textBoxclass.TabIndex = 5;
            // 
            // textBoxteacher
            // 
            this.textBoxteacher.Location = new System.Drawing.Point(142, 57);
            this.textBoxteacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxteacher.Name = "textBoxteacher";
            this.textBoxteacher.Size = new System.Drawing.Size(209, 25);
            this.textBoxteacher.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "学期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "老师";
            // 
            // kaisheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 557);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "kaisheForm";
            this.Text = "开设课程";
            this.Load += new System.EventHandler(this.kaisheForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxterm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxclass;
        private System.Windows.Forms.TextBox textBoxteacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxtime;
        private System.Windows.Forms.ComboBox comboBoxdidian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}