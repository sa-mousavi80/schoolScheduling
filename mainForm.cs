using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolScheduling
{
    public partial class mainForm : Form
    {
        private struct LessonData
        {
            public String name;
            public int timeInWeek;
            public void setTimeInWeek(int i)
            {
                timeInWeek = i;
            }
            public void initialize()
            {
                name = "";
                timeInWeek = 0;
            }
        }
        private List<LessonData> lessonList;
        private struct TeacherData
        {
            public String name;
            public String lesson;
            public bool[] schedule;
            public void initialize()
            {
                name = "";
                lesson = "";
                schedule = new bool[20];
            }
        }
        private List<TeacherData> teacherList;
        private void fillLessonCombo()
        {
            lessonListCombo.Items.Clear();
            lessonListCombo.SelectedIndex = -1;
            lessonListCombo.SelectedText = "";
            lessonListCombo.Text = "";
            lessonTeachTabCombo.Items.Clear();
            lessonTeachTabCombo.SelectedIndex = -1;
            lessonTeachTabCombo.SelectedText = "";
            lessonTeachTabCombo.Text = "";

            for (int i = 0; i < lessonList.Count; i++)
            {
                lessonListCombo.Items.Add(lessonList[i].name);
                lessonTeachTabCombo.Items.Add(lessonList[i].name);
            }
        }
        public mainForm()
        {
            InitializeComponent();
            lessonList = new List<LessonData>();
            teacherList = new List<TeacherData>();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            foreach(LessonData item in lessonList)
            {
                if (item.name == lessonNameTextBox.Text.TrimStart().TrimEnd())
                {
                    MessageBox.Show("Name is duplicated");
                    lessonNameTextBox.Focus();
                    return;
                }
            }
            LessonData lesson = new LessonData();
            lesson.initialize();
            lesson.name = lessonNameTextBox.Text.TrimStart().TrimEnd();
            int timeInWeek = 0;
            try
            {
                timeInWeek = Convert.ToInt32(lessonTimeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Bad Number");
                lessonTimeTextBox.Focus();
                return;
            }
            if (timeInWeek > 0)
            {
                lesson.timeInWeek = timeInWeek;
                lessonList.Add(lesson);
                fillLessonCombo();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (lessonNameTextBox.Text.TrimStart().TrimEnd() == "")
                return;

            foreach (LessonData item in lessonList)
            {
                if (item.name == lessonNameTextBox.Text.TrimStart().TrimEnd())
                {
                    int teacherCount = teacherCombo.Items.Count;

                    for(int i = teacherCount - 1; i >= 0; i--)
                    {
                        if (teacherList[i].lesson == item.name)
                            teacherList.RemoveAt(i);
                    }
                    lessonList.Remove(item);
                    fillLessonCombo();
                    fillTeacherCombo();
                    return;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (lessonNameTextBox.Text.TrimStart().TrimEnd() == "")
                return;
            int index = 0;

            foreach (LessonData item in lessonList)
            {
                if (item.name == lessonNameTextBox.Text.TrimStart().TrimEnd())
                {
                    int i = 0;
                    try
                    {
                        i = Convert.ToInt32(lessonTimeTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Bad Number");
                        lessonTimeTextBox.Focus();
                        return;
                    }
                    if (i > 0)
                    {
                        lessonList[index].setTimeInWeek(i);
                        fillLessonCombo();
                        return;
                    }
                }
                index++;
            }
        }

        private void lessonListCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            lessonNameTextBox.Text = lessonList[lessonListCombo.SelectedIndex].name;
            lessonTimeTextBox.Text = Convert.ToString(lessonList[lessonListCombo.SelectedIndex].timeInWeek);
        }
        private void fillTeacherCombo()
        {
            teacherCombo.Items.Clear();
            teacherCombo.SelectedIndex = -1;
            teacherCombo.SelectedText = "";
            teacherCombo.Text = "";

            foreach (TeacherData item in teacherList)
            {
                teacherCombo.Items.Add(item.name + "(" + item.lesson + ")");
            }
            return;
        }

        private void teacherAddButton_Click(object sender, EventArgs e)
        {
            if (teacherTextBox.Text.TrimStart().TrimEnd() == "")
            {
                teacherTextBox.Focus();
                return;
            }
            if (lessonTeachTabCombo.SelectedIndex < 0)
            {
                lessonTeachTabCombo.Focus();
                return;
            }
            TeacherData teacher = new TeacherData();
            teacher.initialize();
            teacher.name = teacherTextBox.Text.TrimStart().TrimEnd();
            teacher.lesson = lessonList[lessonTeachTabCombo.SelectedIndex].name;

            foreach(TeacherData item in teacherList)
            {
                if (item.name == teacher.name && item.lesson == teacher.lesson)
                {
                    MessageBox.Show("Data is duplicated.");
                    return;
                }
            }
            teacher.schedule[0] = checkBox1.Checked;
            teacher.schedule[1] = checkBox2.Checked;
            teacher.schedule[2] = checkBox3.Checked;
            teacher.schedule[3] = checkBox4.Checked;
            teacher.schedule[4] = checkBox5.Checked;
            teacher.schedule[5] = checkBox6.Checked;
            teacher.schedule[6] = checkBox7.Checked;
            teacher.schedule[7] = checkBox8.Checked;
            teacher.schedule[8] = checkBox9.Checked;
            teacher.schedule[9] = checkBox10.Checked;
            teacher.schedule[10] = checkBox11.Checked;
            teacher.schedule[11] = checkBox12.Checked;
            teacher.schedule[12] = checkBox13.Checked;
            teacher.schedule[13] = checkBox14.Checked;
            teacher.schedule[14] = checkBox15.Checked;
            teacher.schedule[15] = checkBox16.Checked;
            teacher.schedule[16] = checkBox17.Checked;
            teacher.schedule[17] = checkBox18.Checked;
            teacher.schedule[18] = checkBox19.Checked;
            teacher.schedule[19] = checkBox20.Checked;
            teacherList.Add(teacher);
            fillTeacherCombo();
        }

        private void teacherCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherTextBox.Text = teacherList[teacherCombo.SelectedIndex].name;
            int index = 0;

            foreach (TeacherData item in teacherList)
            {
                if (item.lesson == teacherList[teacherCombo.SelectedIndex].lesson)
                {
                    lessonTeachTabCombo.SelectedIndex = index;
                    break;
                }
                index++;
            }
            checkBox1.Checked = teacherList[teacherCombo.SelectedIndex].schedule[0];
            checkBox2.Checked = teacherList[teacherCombo.SelectedIndex].schedule[1];
            checkBox3.Checked = teacherList[teacherCombo.SelectedIndex].schedule[2];
            checkBox4.Checked = teacherList[teacherCombo.SelectedIndex].schedule[3];
            checkBox5.Checked = teacherList[teacherCombo.SelectedIndex].schedule[4];
            checkBox6.Checked = teacherList[teacherCombo.SelectedIndex].schedule[5];
            checkBox7.Checked = teacherList[teacherCombo.SelectedIndex].schedule[6];
            checkBox8.Checked = teacherList[teacherCombo.SelectedIndex].schedule[7];
            checkBox9.Checked = teacherList[teacherCombo.SelectedIndex].schedule[8];
            checkBox10.Checked = teacherList[teacherCombo.SelectedIndex].schedule[9];
            checkBox11.Checked = teacherList[teacherCombo.SelectedIndex].schedule[10];
            checkBox12.Checked = teacherList[teacherCombo.SelectedIndex].schedule[11];
            checkBox13.Checked = teacherList[teacherCombo.SelectedIndex].schedule[12];
            checkBox14.Checked = teacherList[teacherCombo.SelectedIndex].schedule[13];
            checkBox15.Checked = teacherList[teacherCombo.SelectedIndex].schedule[14];
            checkBox16.Checked = teacherList[teacherCombo.SelectedIndex].schedule[15];
            checkBox17.Checked = teacherList[teacherCombo.SelectedIndex].schedule[16];
            checkBox18.Checked = teacherList[teacherCombo.SelectedIndex].schedule[17];
            checkBox19.Checked = teacherList[teacherCombo.SelectedIndex].schedule[18];
            checkBox20.Checked = teacherList[teacherCombo.SelectedIndex].schedule[19];

        }

        private void teacherDelButton_Click(object sender, EventArgs e)
        {
            if (teacherCombo.SelectedIndex < 0)
                return;
            teacherList.RemoveAt(teacherCombo.SelectedIndex);
            fillTeacherCombo();
            teacherTextBox.Text = "";
            lessonTeachTabCombo.SelectedText = "";
            lessonTeachTabCombo.SelectedIndex = -1;
            lessonTeachTabCombo.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
        }

        private void برنامهریزیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] weeklyProgram;
            weeklyProgram = new String[20];

            for (int i = 0; i < 20; i++)
                weeklyProgram[i] = "";

            foreach(TeacherData item in teacherList)
            {

                for(int j = 0; j < 20; j++)
                {
                    if (item.schedule[j])
                        weeklyProgram[j] += item.name + "(" + item.lesson + ")" + ",";
                }
            }
            Form1 form = new Form1();
            form.setProgram(weeklyProgram);
            form.ShowDialog();
        }
    }
}
