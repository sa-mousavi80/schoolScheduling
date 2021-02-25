namespace schoolScheduling
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lessonTab = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.lessonTimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lessonNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lessonListCombo = new System.Windows.Forms.ComboBox();
            this.teacherTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lessonTeachTabCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.teacherAddButton = new System.Windows.Forms.Button();
            this.teacherDelButton = new System.Windows.Forms.Button();
            this.برنامهریزیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.lessonTab.SuspendLayout();
            this.teacherTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lessonTab);
            this.tabControl1.Controls.Add(this.teacherTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // lessonTab
            // 
            this.lessonTab.Controls.Add(this.addButton);
            this.lessonTab.Controls.Add(this.deleteButton);
            this.lessonTab.Controls.Add(this.updateButton);
            this.lessonTab.Controls.Add(this.lessonTimeTextBox);
            this.lessonTab.Controls.Add(this.label3);
            this.lessonTab.Controls.Add(this.lessonNameTextBox);
            this.lessonTab.Controls.Add(this.label2);
            this.lessonTab.Controls.Add(this.label1);
            this.lessonTab.Controls.Add(this.lessonListCombo);
            this.lessonTab.Location = new System.Drawing.Point(4, 22);
            this.lessonTab.Name = "lessonTab";
            this.lessonTab.Padding = new System.Windows.Forms.Padding(3);
            this.lessonTab.Size = new System.Drawing.Size(355, 254);
            this.lessonTab.TabIndex = 0;
            this.lessonTab.Text = "درس ها";
            this.lessonTab.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(204, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 26);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "درج";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(125, 146);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 26);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(46, 146);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(73, 26);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "بروزرسانی";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // lessonTimeTextBox
            // 
            this.lessonTimeTextBox.Location = new System.Drawing.Point(42, 101);
            this.lessonTimeTextBox.Name = "lessonTimeTextBox";
            this.lessonTimeTextBox.Size = new System.Drawing.Size(195, 20);
            this.lessonTimeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "دفعات ارائه";
            // 
            // lessonNameTextBox
            // 
            this.lessonNameTextBox.Location = new System.Drawing.Point(42, 67);
            this.lessonNameTextBox.Name = "lessonNameTextBox";
            this.lessonNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.lessonNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "فهرست درس ها";
            // 
            // lessonListCombo
            // 
            this.lessonListCombo.FormattingEnabled = true;
            this.lessonListCombo.Location = new System.Drawing.Point(42, 21);
            this.lessonListCombo.Name = "lessonListCombo";
            this.lessonListCombo.Size = new System.Drawing.Size(195, 21);
            this.lessonListCombo.TabIndex = 0;
            this.lessonListCombo.SelectedValueChanged += new System.EventHandler(this.lessonListCombo_SelectedValueChanged);
            // 
            // teacherTab
            // 
            this.teacherTab.Controls.Add(this.teacherDelButton);
            this.teacherTab.Controls.Add(this.teacherAddButton);
            this.teacherTab.Controls.Add(this.checkBox20);
            this.teacherTab.Controls.Add(this.checkBox19);
            this.teacherTab.Controls.Add(this.checkBox18);
            this.teacherTab.Controls.Add(this.checkBox17);
            this.teacherTab.Controls.Add(this.checkBox16);
            this.teacherTab.Controls.Add(this.checkBox15);
            this.teacherTab.Controls.Add(this.checkBox14);
            this.teacherTab.Controls.Add(this.checkBox13);
            this.teacherTab.Controls.Add(this.checkBox12);
            this.teacherTab.Controls.Add(this.checkBox11);
            this.teacherTab.Controls.Add(this.checkBox10);
            this.teacherTab.Controls.Add(this.checkBox9);
            this.teacherTab.Controls.Add(this.checkBox8);
            this.teacherTab.Controls.Add(this.checkBox7);
            this.teacherTab.Controls.Add(this.checkBox6);
            this.teacherTab.Controls.Add(this.checkBox5);
            this.teacherTab.Controls.Add(this.checkBox4);
            this.teacherTab.Controls.Add(this.checkBox3);
            this.teacherTab.Controls.Add(this.checkBox2);
            this.teacherTab.Controls.Add(this.checkBox1);
            this.teacherTab.Controls.Add(this.label11);
            this.teacherTab.Controls.Add(this.label10);
            this.teacherTab.Controls.Add(this.label9);
            this.teacherTab.Controls.Add(this.label8);
            this.teacherTab.Controls.Add(this.label7);
            this.teacherTab.Controls.Add(this.label6);
            this.teacherTab.Controls.Add(this.lessonTeachTabCombo);
            this.teacherTab.Controls.Add(this.label5);
            this.teacherTab.Controls.Add(this.teacherTextBox);
            this.teacherTab.Controls.Add(this.label4);
            this.teacherTab.Controls.Add(this.teacherCombo);
            this.teacherTab.Location = new System.Drawing.Point(4, 22);
            this.teacherTab.Name = "teacherTab";
            this.teacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.teacherTab.Size = new System.Drawing.Size(355, 254);
            this.teacherTab.TabIndex = 1;
            this.teacherTab.Text = "معلم";
            this.teacherTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem,
            this.برنامهریزیToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(363, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // teacherCombo
            // 
            this.teacherCombo.FormattingEnabled = true;
            this.teacherCombo.Location = new System.Drawing.Point(8, 17);
            this.teacherCombo.Name = "teacherCombo";
            this.teacherCombo.Size = new System.Drawing.Size(252, 21);
            this.teacherCombo.TabIndex = 0;
            this.teacherCombo.SelectedIndexChanged += new System.EventHandler(this.teacherCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "فهرست معلمین";
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Location = new System.Drawing.Point(113, 44);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(147, 20);
            this.teacherTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "نام معلم";
            // 
            // lessonTeachTabCombo
            // 
            this.lessonTeachTabCombo.FormattingEnabled = true;
            this.lessonTeachTabCombo.Location = new System.Drawing.Point(114, 72);
            this.lessonTeachTabCombo.Name = "lessonTeachTabCombo";
            this.lessonTeachTabCombo.Size = new System.Drawing.Size(145, 21);
            this.lessonTeachTabCombo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "نام درس";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "شنبه";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "یکشنبه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "دوشنبه";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "سه شنبه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "چهارشنبه";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(257, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(236, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(215, 105);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(194, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(257, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(236, 125);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(215, 125);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(194, 125);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 18;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(257, 150);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 19;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(236, 150);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 20;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(215, 150);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 21;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(194, 150);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 22;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(257, 174);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 23;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(236, 174);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 24;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(215, 174);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 25;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(194, 174);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 26;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(257, 201);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(15, 14);
            this.checkBox17.TabIndex = 27;
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(236, 201);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(15, 14);
            this.checkBox18.TabIndex = 28;
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(215, 201);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(15, 14);
            this.checkBox19.TabIndex = 29;
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(194, 201);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(15, 14);
            this.checkBox20.TabIndex = 30;
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // teacherAddButton
            // 
            this.teacherAddButton.Location = new System.Drawing.Point(41, 112);
            this.teacherAddButton.Name = "teacherAddButton";
            this.teacherAddButton.Size = new System.Drawing.Size(92, 27);
            this.teacherAddButton.TabIndex = 31;
            this.teacherAddButton.Text = "درج";
            this.teacherAddButton.UseVisualStyleBackColor = true;
            this.teacherAddButton.Click += new System.EventHandler(this.teacherAddButton_Click);
            // 
            // teacherDelButton
            // 
            this.teacherDelButton.Location = new System.Drawing.Point(41, 145);
            this.teacherDelButton.Name = "teacherDelButton";
            this.teacherDelButton.Size = new System.Drawing.Size(92, 27);
            this.teacherDelButton.TabIndex = 32;
            this.teacherDelButton.Text = "حذف";
            this.teacherDelButton.UseVisualStyleBackColor = true;
            this.teacherDelButton.Click += new System.EventHandler(this.teacherDelButton_Click);
            // 
            // برنامهریزیToolStripMenuItem
            // 
            this.برنامهریزیToolStripMenuItem.Name = "برنامهریزیToolStripMenuItem";
            this.برنامهریزیToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.برنامهریزیToolStripMenuItem.Text = "برنامه ریزی";
            this.برنامهریزیToolStripMenuItem.Click += new System.EventHandler(this.برنامهریزیToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه کلاس";
            this.tabControl1.ResumeLayout(false);
            this.lessonTab.ResumeLayout(false);
            this.lessonTab.PerformLayout();
            this.teacherTab.ResumeLayout(false);
            this.teacherTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lessonTab;
        private System.Windows.Forms.TabPage teacherTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.TextBox lessonNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lessonListCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox lessonTimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lessonTeachTabCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox teacherCombo;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button teacherDelButton;
        private System.Windows.Forms.Button teacherAddButton;
        private System.Windows.Forms.ToolStripMenuItem برنامهریزیToolStripMenuItem;
    }
}

