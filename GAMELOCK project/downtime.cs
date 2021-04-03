using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAMELOCK_project.Properties;

namespace GAMELOCK_project
{
    public partial class downtime : Form
    {
        public downtime()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void mondayaddtime_Click(object sender, EventArgs e)
        {
           
            string defaultselection = "yes";
            string mondayselected = Settings.Default["mondayselected"].ToString();
            string tuesdayselected = Settings.Default["tuesdayselected"].ToString();
            string wednesdayselected = Settings.Default["wednesdayselected"].ToString();
            string thursdayselected = Settings.Default["thursdayselected"].ToString();
            string fridayselected = Settings.Default["fridayselected"].ToString();
            string saturdayselected = Settings.Default["saturdayselected"].ToString();
            string sundayselected = Settings.Default["sundayselected"].ToString();
            string everydayselected = Settings.Default["everydayselected"].ToString();
            string weekdayselected = Settings.Default["weekdayselected"].ToString();
            string weekendselected = Settings.Default["weekendselected"].ToString();

            bool isweekendselected = string.Equals(defaultselection, weekendselected);
            bool isweekdayselected = string.Equals(defaultselection, weekdayselected);
            bool iseverydayselected = string.Equals(defaultselection, everydayselected);
            bool ismondayselected = string.Equals(defaultselection, mondayselected);
            bool istuesdayselected = string.Equals(defaultselection, tuesdayselected);
            bool iswednesdayselected = string.Equals(defaultselection, wednesdayselected);
            bool isthursdayselected = string.Equals(defaultselection, thursdayselected);
            bool isfridayselected = string.Equals(defaultselection, fridayselected);
            bool issaturdayselected = string.Equals(defaultselection, saturdayselected);
            bool issundayselected = string.Equals(defaultselection, sundayselected);

            if (ismondayselected == true)
            {
                string defaultvariable = "null";
                string mondayisdefaultadd = Settings.Default["mondaystarttime"].ToString();
                string mondayisdefaultend = Settings.Default["mondayendtime"].ToString();
                string mondayisdefaultadd1 = Settings.Default["mondaystarttime1"].ToString();
                string mondayisdefaultend1 = Settings.Default["mondayendtime1"].ToString();
                string mondayisdefaultadd2 = Settings.Default["mondaystarttime2"].ToString();
                string mondayisdefaultend2 = Settings.Default["mondayendtime2"].ToString();

                bool mondaydefaultstart = string.Equals(defaultvariable, mondayisdefaultadd);
                bool mondaydefaultend = string.Equals(defaultvariable, mondayisdefaultend);
                bool mondaydefaultstart1 = string.Equals(defaultvariable, mondayisdefaultadd1);
                bool mondaydefaultend1 = string.Equals(defaultvariable, mondayisdefaultend1);
                bool mondaydefaultstart2 = string.Equals(defaultvariable, mondayisdefaultadd2);
                bool mondaydefaultend2 = string.Equals(defaultvariable, mondayisdefaultend2);

                if (mondaydefaultstart == true && mondaydefaultend == true)
                {
                    Settings.Default["mondaystarttime"] = starttime.Text;
                    Settings.Default["mondayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (mondaydefaultstart1 == true && mondaydefaultend1 == true)
                {
                    Settings.Default["mondaystarttime1"] = starttime.Text;
                    Settings.Default["mondayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (mondaydefaultstart2 == true && mondaydefaultend2 == true)
                {
                    Settings.Default["mondaystarttime2"] = starttime.Text;
                    Settings.Default["mondayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }

            }
            else if (istuesdayselected == true)
            {
                string defaultvariable = "null";
                string tuesdayisdefaultadd = Settings.Default["tuesdaystarttime"].ToString();
                string tuesdayisdefaultend = Settings.Default["tuesdayendtime"].ToString();
                string tuesdayisdefaultadd1 = Settings.Default["tuesdaystarttime1"].ToString();
                string tuesdayisdefaultend1 = Settings.Default["tuesdayendtime1"].ToString();
                string tuesdayisdefaultadd2 = Settings.Default["tuesdaystarttime2"].ToString();
                string tuesdayisdefaultend2 = Settings.Default["tuesdayendtime2"].ToString();

                bool tuesdaydefaultstart = string.Equals(defaultvariable, tuesdayisdefaultadd);
                bool tuesdaydefaultend = string.Equals(defaultvariable, tuesdayisdefaultend);
                bool tuesdaydefaultstart1 = string.Equals(defaultvariable, tuesdayisdefaultadd1);
                bool tuesdaydefaultend1 = string.Equals(defaultvariable, tuesdayisdefaultend1);
                bool tuesdaydefaultstart2 = string.Equals(defaultvariable, tuesdayisdefaultadd2);
                bool tuesdaydefaultend2 = string.Equals(defaultvariable, tuesdayisdefaultend2);

                if(tuesdaydefaultstart == true && tuesdaydefaultend == true)
                {
                    Settings.Default["tuesdaystarttime"] = starttime.Text;
                    Settings.Default["tuesdayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (tuesdaydefaultstart1 == true && tuesdaydefaultend1 == true)
                {
                    Settings.Default["tuesdaystarttime1"] = starttime.Text;
                    Settings.Default["tuesdayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (tuesdaydefaultstart2 == true && tuesdaydefaultend2 == true)
                {
                    Settings.Default["tuesdaystarttime2"] = starttime.Text;
                    Settings.Default["tuesdayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }

            }
            else if (iswednesdayselected == true)
            {
                string defaultvariable = "null";
                string wednesdayisdefaultadd = Settings.Default["wednesdaystarttime"].ToString();
                string wednesdayisdefaultend = Settings.Default["wednesdayendtime"].ToString();
                string wednesdayisdefaultadd1 = Settings.Default["wednesdaystarttime1"].ToString();
                string wednesdayisdefaultend1 = Settings.Default["wednesdayendtime1"].ToString();
                string wednesdayisdefaultadd2 = Settings.Default["wednesdaystarttime2"].ToString();
                string wednesdayisdefaultend2 = Settings.Default["wednesdayendtime2"].ToString();

                bool wednesdaydefaultstart = string.Equals(defaultvariable, wednesdayisdefaultadd);
                bool wednesdaydefaultend = string.Equals(defaultvariable, wednesdayisdefaultend);
                bool wednesdaydefaultstart1 = string.Equals(defaultvariable, wednesdayisdefaultadd1);
                bool wednesdaydefaultend1 = string.Equals(defaultvariable, wednesdayisdefaultend1);
                bool wednesdaydefaultstart2 = string.Equals(defaultvariable, wednesdayisdefaultadd2);
                bool wednesdaydefaultend2 = string.Equals(defaultvariable, wednesdayisdefaultend2);
                
                if(wednesdaydefaultstart == true && wednesdaydefaultend == true)
                {
                    Settings.Default["wednesdaystarttime"] = starttime.Text;
                    Settings.Default["wednesdayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (wednesdaydefaultstart1 == true && wednesdaydefaultend1)
                {
                    Settings.Default["wednesdaystarttime1"] = starttime.Text;
                    Settings.Default["wednesdayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (wednesdaydefaultstart2 == true && wednesdaydefaultend2)
                {
                    Settings.Default["wednesdaystarttime2"] = starttime.Text;
                    Settings.Default["wednesdayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }
            }
            else if (isthursdayselected == true)
            {
                string defaultvariable = "null";
                string thursdayisdefaultadd = Settings.Default["thursdaystarttime"].ToString();
                string thursdayisdefaultend = Settings.Default["thursdayendtime"].ToString();
                string thursdayisdefaultadd1 = Settings.Default["thursdaystarttime1"].ToString();
                string thursdayisdefaultend1 = Settings.Default["thursdayendtime1"].ToString();
                string thursdayisdefaultadd2 = Settings.Default["thursdaystarttime2"].ToString();
                string thursdayisdefaultend2 = Settings.Default["thursdayendtime2"].ToString();

                bool thursdaydefaultstart = string.Equals(defaultvariable, thursdayisdefaultadd);
                bool thursdaydefaultend = string.Equals(defaultvariable, thursdayisdefaultend);
                bool thursdaydefaultstart1 = string.Equals(defaultvariable, thursdayisdefaultadd1);
                bool thursdaydefaultend1 = string.Equals(defaultvariable, thursdayisdefaultend1);
                bool thursdaydefaultstart2 = string.Equals(defaultvariable, thursdayisdefaultadd2);
                bool thursdaydefaultend2 = string.Equals(defaultvariable, thursdayisdefaultend2);

                if (thursdaydefaultstart == true && thursdaydefaultend == true)
                {
                    Settings.Default["thursdaystarttime"] = starttime.Text;
                    Settings.Default["thursdayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (thursdaydefaultstart1 == true && thursdaydefaultend1 == true)
                {
                    Settings.Default["thursdaystarttime1"] = starttime.Text;
                    Settings.Default["thursdayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (thursdaydefaultstart2 == true && thursdaydefaultend2 == true)
                {
                    Settings.Default["thursdaystarttime2"] = starttime.Text;
                    Settings.Default["thursdayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }
            }
            else if (isfridayselected == true)
            {
                string defaultvariable = "null";
                string fridayisdefaultadd = Settings.Default["fridaystarttime"].ToString();
                string fridayisdefaultend = Settings.Default["fridayendtime"].ToString();
                string fridayisdefaultadd1 = Settings.Default["fridaystarttime1"].ToString();
                string fridayisdefaultend1 = Settings.Default["fridayendtime1"].ToString();
                string fridayisdefaultadd2 = Settings.Default["fridaystarttime2"].ToString();
                string fridayisdefaultend2 = Settings.Default["fridayendtime2"].ToString();

                bool fridaydefaultstart = string.Equals(defaultvariable, fridayisdefaultadd);
                bool fridaydefaultend = string.Equals(defaultvariable, fridayisdefaultend);
                bool fridaydefaultstart1 = string.Equals(defaultvariable, fridayisdefaultadd1);
                bool fridaydefaultend1 = string.Equals(defaultvariable, fridayisdefaultend1);
                bool fridaydefaultstart2 = string.Equals(defaultvariable, fridayisdefaultadd2);
                bool fridaydefaultend2 = string.Equals(defaultvariable, fridayisdefaultend2);

                if (fridaydefaultstart == true && fridaydefaultend == true)
                {
                    Settings.Default["fridaystarttime"] = starttime.Text;
                    Settings.Default["fridayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (fridaydefaultstart1 == true && fridaydefaultend1 == true)
                {
                    Settings.Default["fridaystarttime1"] = starttime.Text;
                    Settings.Default["fridayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (fridaydefaultstart2 == true && fridaydefaultend2 == true)
                {
                    Settings.Default["fridaystarttime2"] = starttime.Text;
                    Settings.Default["fridayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }
            }
            else if (issaturdayselected == true)
            {
                string defaultvariable = "null";
                string saturdayisdefaultadd = Settings.Default["saturdaystarttime"].ToString();
                string saturdayisdefaultend = Settings.Default["saturdayendtime"].ToString();
                string saturdayisdefaultadd1 = Settings.Default["saturdaystarttime1"].ToString();
                string saturdayisdefaultend1 = Settings.Default["saturdayendtime1"].ToString();
                string saturdayisdefaultadd2 = Settings.Default["saturdaystarttime2"].ToString();
                string saturdayisdefaultend2 = Settings.Default["saturdayendtime2"].ToString();

                bool saturdaydefaultstart = string.Equals(defaultvariable, saturdayisdefaultadd);
                bool saturdaydefaultend = string.Equals(defaultvariable, saturdayisdefaultend);
                bool saturdaydefaultstart1 = string.Equals(defaultvariable, saturdayisdefaultadd1);
                bool saturdaydefaultend1 = string.Equals(defaultvariable, saturdayisdefaultend1);
                bool saturdaydefaultstart2 = string.Equals(defaultvariable, saturdayisdefaultadd2);
                bool saturdaydefaultend2 = string.Equals(defaultvariable, saturdayisdefaultend2);

                if (saturdaydefaultstart == true && saturdaydefaultend == true)
                {
                    Settings.Default["saturdaystarttime"] = starttime.Text;
                    Settings.Default["saturdayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (saturdaydefaultstart1 == true && saturdaydefaultend1)
                {
                    Settings.Default["saturdaystarttime1"] = starttime.Text;
                    Settings.Default["saturdayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (saturdaydefaultstart2 == true && saturdaydefaultend2 == true)
                {
                    Settings.Default["saturdaystarttime2"] = starttime.Text;
                    Settings.Default["saturdayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }
            }   
            else if (issundayselected == true)
            {
                string defaultvariable = "null";
                string sundayisdefaultadd = Settings.Default["sundaystarttime"].ToString();
                string sundayisdefaultend = Settings.Default["sundayendtime"].ToString();
                string sundayisdefaultadd1 = Settings.Default["sundaystarttime1"].ToString();
                string sundayisdefaultend1 = Settings.Default["sundayendtime1"].ToString();
                string sundayisdefaultadd2 = Settings.Default["sundaystarttime2"].ToString();
                string sundayisdefaultend2 = Settings.Default["sundayendtime2"].ToString();

                bool sundaydefaultstart = string.Equals(defaultvariable, sundayisdefaultadd);
                bool sundaydefaultend = string.Equals(defaultvariable, sundayisdefaultend);
                bool sundaydefaultstart1 = string.Equals(defaultvariable, sundayisdefaultadd1);
                bool sundaydefaultend1 = string.Equals(defaultvariable, sundayisdefaultend1);
                bool sundaydefaultstart2 = string.Equals(defaultvariable, sundayisdefaultadd2);
                bool sundaydefaultend2 = string.Equals(defaultvariable, sundayisdefaultend2);

                if (sundaydefaultstart == true && sundaydefaultend)
                {
                    Settings.Default["sundaystarttime"] = starttime.Text;
                    Settings.Default["sundayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (sundaydefaultstart1 == true && sundaydefaultend1 == true)
                {
                    Settings.Default["sundaystarttime1"] = starttime.Text;
                    Settings.Default["sundayendtime1"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (sundaydefaultstart2 == true && sundaydefaultend2 == true)
                {
                    Settings.Default["sundaystarttime2"] = starttime.Text;
                    Settings.Default["sundayendtime2"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
                    Settings.Default.Save();
                }

            }
            else if (iseverydayselected == true)
            {
                // monday slot free?
                string defaultvariable = "null";
                string mondayisdefaultadd = Settings.Default["mondaystarttime"].ToString();
                string mondayisdefaultend = Settings.Default["mondayendtime"].ToString();
                string mondayisdefaultadd1 = Settings.Default["mondaystarttime1"].ToString();
                string mondayisdefaultend1 = Settings.Default["mondayendtime1"].ToString();
                string mondayisdefaultadd2 = Settings.Default["mondaystarttime2"].ToString();
                string mondayisdefaultend2 = Settings.Default["mondayendtime2"].ToString();

                bool mondaydefaultstart = string.Equals(defaultvariable, mondayisdefaultadd);
                bool mondaydefaultend = string.Equals(defaultvariable, mondayisdefaultend);
                bool mondaydefaultstart1 = string.Equals(defaultvariable, mondayisdefaultadd1);
                bool mondaydefaultend1 = string.Equals(defaultvariable, mondayisdefaultend1);
                bool mondaydefaultstart2 = string.Equals(defaultvariable, mondayisdefaultadd2);
                bool mondaydefaultend2 = string.Equals(defaultvariable, mondayisdefaultend2);

                // tuesday slot free?
                string tuesdayisdefaultadd = Settings.Default["tuesdaystarttime"].ToString();
                string tuesdayisdefaultend = Settings.Default["tuesdayendtime"].ToString();
                string tuesdayisdefaultadd1 = Settings.Default["tuesdaystarttime1"].ToString();
                string tuesdayisdefaultend1 = Settings.Default["tuesdayendtime1"].ToString();
                string tuesdayisdefaultadd2 = Settings.Default["tuesdaystarttime2"].ToString();
                string tuesdayisdefaultend2 = Settings.Default["tuesdayendtime2"].ToString();

                bool tuesdaydefaultstart = string.Equals(defaultvariable, tuesdayisdefaultadd);
                bool tuesdaydefaultend = string.Equals(defaultvariable, tuesdayisdefaultend);
                bool tuesdaydefaultstart1 = string.Equals(defaultvariable, tuesdayisdefaultadd1);
                bool tuesdaydefaultend1 = string.Equals(defaultvariable, tuesdayisdefaultend1);
                bool tuesdaydefaultstart2 = string.Equals(defaultvariable, tuesdayisdefaultadd2);
                bool tuesdaydefaultend2 = string.Equals(defaultvariable, tuesdayisdefaultend2);

                // wednesday slot free?
                string wednesdayisdefaultadd = Settings.Default["wednesdaystarttime"].ToString();
                string wednesdayisdefaultend = Settings.Default["wednesdayendtime"].ToString();
                string wednesdayisdefaultadd1 = Settings.Default["wednesdaystarttime1"].ToString();
                string wednesdayisdefaultend1 = Settings.Default["wednesdayendtime1"].ToString();
                string wednesdayisdefaultadd2 = Settings.Default["wednesdaystarttime2"].ToString();
                string wednesdayisdefaultend2 = Settings.Default["wednesdayendtime2"].ToString();

                bool wednesdaydefaultstart = string.Equals(defaultvariable, wednesdayisdefaultadd);
                bool wednesdaydefaultend = string.Equals(defaultvariable, wednesdayisdefaultend);
                bool wednesdaydefaultstart1 = string.Equals(defaultvariable, wednesdayisdefaultadd1);
                bool wednesdaydefaultend1 = string.Equals(defaultvariable, wednesdayisdefaultend1);
                bool wednesdaydefaultstart2 = string.Equals(defaultvariable, wednesdayisdefaultadd2);
                bool wednesdaydefaultend2 = string.Equals(defaultvariable, wednesdayisdefaultend2);

                // thursday slot free?
                string thursdayisdefaultadd = Settings.Default["thursdaystarttime"].ToString();
                string thursdayisdefaultend = Settings.Default["thursdayendtime"].ToString();
                string thursdayisdefaultadd1 = Settings.Default["thursdaystarttime1"].ToString();
                string thursdayisdefaultend1 = Settings.Default["thursdayendtime1"].ToString();
                string thursdayisdefaultadd2 = Settings.Default["thursdaystarttime2"].ToString();
                string thursdayisdefaultend2 = Settings.Default["thursdayendtime2"].ToString();

                bool thursdaydefaultstart = string.Equals(defaultvariable, thursdayisdefaultadd);
                bool thursdaydefaultend = string.Equals(defaultvariable, thursdayisdefaultend);
                bool thursdaydefaultstart1 = string.Equals(defaultvariable, thursdayisdefaultadd1);
                bool thursdaydefaultend1 = string.Equals(defaultvariable, thursdayisdefaultend1);
                bool thursdaydefaultstart2 = string.Equals(defaultvariable, thursdayisdefaultadd2);
                bool thursdaydefaultend2 = string.Equals(defaultvariable, thursdayisdefaultend2);

                // friday slot free?
                string fridayisdefaultadd = Settings.Default["fridaystarttime"].ToString();
                string fridayisdefaultend = Settings.Default["fridayendtime"].ToString();
                string fridayisdefaultadd1 = Settings.Default["fridaystarttime1"].ToString();
                string fridayisdefaultend1 = Settings.Default["fridayendtime1"].ToString();
                string fridayisdefaultadd2 = Settings.Default["fridaystarttime2"].ToString();
                string fridayisdefaultend2 = Settings.Default["fridayendtime2"].ToString();

                bool fridaydefaultstart = string.Equals(defaultvariable, fridayisdefaultadd);
                bool fridaydefaultend = string.Equals(defaultvariable, fridayisdefaultend);
                bool fridaydefaultstart1 = string.Equals(defaultvariable, fridayisdefaultadd1);
                bool fridaydefaultend1 = string.Equals(defaultvariable, fridayisdefaultend1);
                bool fridaydefaultstart2 = string.Equals(defaultvariable, fridayisdefaultadd2);
                bool fridaydefaultend2 = string.Equals(defaultvariable, fridayisdefaultend2);

                // saturday slot free?
                string saturdayisdefaultadd = Settings.Default["saturdaystarttime"].ToString();
                string saturdayisdefaultend = Settings.Default["saturdayendtime"].ToString();
                string saturdayisdefaultadd1 = Settings.Default["saturdaystarttime1"].ToString();
                string saturdayisdefaultend1 = Settings.Default["saturdayendtime1"].ToString();
                string saturdayisdefaultadd2 = Settings.Default["saturdaystarttime2"].ToString();
                string saturdayisdefaultend2 = Settings.Default["saturdayendtime2"].ToString();

                bool saturdaydefaultstart = string.Equals(defaultvariable, saturdayisdefaultadd);
                bool saturdaydefaultend = string.Equals(defaultvariable, saturdayisdefaultend);
                bool saturdaydefaultstart1 = string.Equals(defaultvariable, saturdayisdefaultadd1);
                bool saturdaydefaultend1 = string.Equals(defaultvariable, saturdayisdefaultend1);
                bool saturdaydefaultstart2 = string.Equals(defaultvariable, saturdayisdefaultadd2);
                bool saturdaydefaultend2 = string.Equals(defaultvariable, saturdayisdefaultend2);

                // sunday slot free?
                string sundayisdefaultadd = Settings.Default["sundaystarttime"].ToString();
                string sundayisdefaultend = Settings.Default["sundayendtime"].ToString();
                string sundayisdefaultadd1 = Settings.Default["sundaystarttime1"].ToString();
                string sundayisdefaultend1 = Settings.Default["sundayendtime1"].ToString();
                string sundayisdefaultadd2 = Settings.Default["sundaystarttime2"].ToString();
                string sundayisdefaultend2 = Settings.Default["sundayendtime2"].ToString();

                bool sundaydefaultstart = string.Equals(defaultvariable, sundayisdefaultadd);
                bool sundaydefaultend = string.Equals(defaultvariable, sundayisdefaultend);
                bool sundaydefaultstart1 = string.Equals(defaultvariable, sundayisdefaultadd1);
                bool sundaydefaultend1 = string.Equals(defaultvariable, sundayisdefaultend1);
                bool sundaydefaultstart2 = string.Equals(defaultvariable, sundayisdefaultadd2);
                bool sundaydefaultend2 = string.Equals(defaultvariable, sundayisdefaultend2);

                if (mondaydefaultstart == true && mondaydefaultend == true && tuesdaydefaultstart == true && tuesdaydefaultend == true && wednesdaydefaultstart == true && wednesdaydefaultend == true && thursdaydefaultstart == true && thursdaydefaultend == true && fridaydefaultstart == true && fridaydefaultend == true && saturdaydefaultstart == true && saturdaydefaultend == true && sundaydefaultstart == true && sundaydefaultend == true)
                {
                    // monday
                    Settings.Default["mondaystarttime"] = starttime.Text;
                    Settings.Default["mondayendtime"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime"] = starttime.Text;
                    Settings.Default["tuesdayendtime"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime"] = starttime.Text;
                    Settings.Default["wednesdayendtime"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime"] = starttime.Text;
                    Settings.Default["thursdayendtime"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime"] = starttime.Text;
                    Settings.Default["fridayendtime"] = endtime.Text;
                    // saturday
                    Settings.Default["saturdaystarttime"] = starttime.Text;
                    Settings.Default["saturdayendtime"] = endtime.Text;
                    // sunday
                    Settings.Default["sundaystarttime"] = starttime.Text;
                    Settings.Default["sundayendtime"] = endtime.Text;
                    // save the settings
                    Settings.Default.Save();
                    // show a confirmation message
                    MessageBox.Show("You have added a new time for every day! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else if (mondaydefaultstart1 == true && mondaydefaultend1 == true && tuesdaydefaultstart1 == true && tuesdaydefaultend1 == true && wednesdaydefaultstart1 == true && wednesdaydefaultend1 == true && thursdaydefaultstart1 == true && thursdaydefaultend1 == true && fridaydefaultstart1 == true && fridaydefaultend1 == true && saturdaydefaultstart1 == true && saturdaydefaultend1 == true && sundaydefaultstart1 == true && sundaydefaultend1 == true)
                {
                    // monday
                    Settings.Default["mondaystarttime1"] = starttime.Text;
                    Settings.Default["mondayendtime1"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime1"] = starttime.Text;
                    Settings.Default["tuesdayendtime1"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime1"] = starttime.Text;
                    Settings.Default["wednesdayendtime1"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime1"] = starttime.Text;
                    Settings.Default["thursdayendtime1"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime1"] = starttime.Text;
                    Settings.Default["fridayendtime1"] = endtime.Text;
                    // saturday
                    Settings.Default["saturdaystarttime1"] = starttime.Text;
                    Settings.Default["saturdayendtime1"] = endtime.Text;
                    // sunday
                    Settings.Default["sundaystarttime1"] = starttime.Text;
                    Settings.Default["sundayendtime1"] = endtime.Text;
                    // save the settings
                    Settings.Default.Save();
                    // show a confirmation message
                    MessageBox.Show("You have added a new time for the second slot of every day! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else if (mondaydefaultstart2 == true && mondaydefaultend2 == true && tuesdaydefaultstart2 == true && tuesdaydefaultend2 == true && wednesdaydefaultstart2 == true && wednesdaydefaultend2 == true && thursdaydefaultstart2 == true && thursdaydefaultend2 == true && fridaydefaultstart2 == true && fridaydefaultend2 == true && saturdaydefaultstart2 == true && saturdaydefaultend2 == true && sundaydefaultstart2 == true && sundaydefaultend2 == true)
                {
                    // monday
                    Settings.Default["mondaystarttime2"] = starttime.Text;
                    Settings.Default["mondayendtime2"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime2"] = starttime.Text;
                    Settings.Default["tuesdayendtime2"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime2"] = starttime.Text;
                    Settings.Default["wednesdayendtime2"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime2"] = starttime.Text;
                    Settings.Default["thursdayendtime2"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime2"] = starttime.Text;
                    Settings.Default["fridayendtime2"] = endtime.Text;
                    // saturday
                    Settings.Default["saturdaystarttime2"] = starttime.Text;
                    Settings.Default["saturdayendtime2"] = endtime.Text;
                    // sunday
                    Settings.Default["sundaystarttime2"] = starttime.Text;
                    Settings.Default["sundayendtime2"] = endtime.Text;
                    // save the settings
                    Settings.Default.Save();
                    // show a confirmation message
                    MessageBox.Show("You have added a new time for the third slot of every day! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else
                {
                    MessageBox.Show("There are no free slots to have this time everyday, please clear some slots to add a time for everyday. if you think this is a code error contact the creator from the 'help the creator' button on the dashboard");
                }
            }
            else if (isweekdayselected == true)
            {
                // monday slot free?
                string defaultvariable = "null";
                string mondayisdefaultadd = Settings.Default["mondaystarttime"].ToString();
                string mondayisdefaultend = Settings.Default["mondayendtime"].ToString();
                string mondayisdefaultadd1 = Settings.Default["mondaystarttime1"].ToString();
                string mondayisdefaultend1 = Settings.Default["mondayendtime1"].ToString();
                string mondayisdefaultadd2 = Settings.Default["mondaystarttime2"].ToString();
                string mondayisdefaultend2 = Settings.Default["mondayendtime2"].ToString();

                bool mondaydefaultstart = string.Equals(defaultvariable, mondayisdefaultadd);
                bool mondaydefaultend = string.Equals(defaultvariable, mondayisdefaultend);
                bool mondaydefaultstart1 = string.Equals(defaultvariable, mondayisdefaultadd1);
                bool mondaydefaultend1 = string.Equals(defaultvariable, mondayisdefaultend1);
                bool mondaydefaultstart2 = string.Equals(defaultvariable, mondayisdefaultadd2);
                bool mondaydefaultend2 = string.Equals(defaultvariable, mondayisdefaultend2);

                // tuesday slot free?
                string tuesdayisdefaultadd = Settings.Default["tuesdaystarttime"].ToString();
                string tuesdayisdefaultend = Settings.Default["tuesdayendtime"].ToString();
                string tuesdayisdefaultadd1 = Settings.Default["tuesdaystarttime1"].ToString();
                string tuesdayisdefaultend1 = Settings.Default["tuesdayendtime1"].ToString();
                string tuesdayisdefaultadd2 = Settings.Default["tuesdaystarttime2"].ToString();
                string tuesdayisdefaultend2 = Settings.Default["tuesdayendtime2"].ToString();

                bool tuesdaydefaultstart = string.Equals(defaultvariable, tuesdayisdefaultadd);
                bool tuesdaydefaultend = string.Equals(defaultvariable, tuesdayisdefaultend);
                bool tuesdaydefaultstart1 = string.Equals(defaultvariable, tuesdayisdefaultadd1);
                bool tuesdaydefaultend1 = string.Equals(defaultvariable, tuesdayisdefaultend1);
                bool tuesdaydefaultstart2 = string.Equals(defaultvariable, tuesdayisdefaultadd2);
                bool tuesdaydefaultend2 = string.Equals(defaultvariable, tuesdayisdefaultend2);

                // wednesday slot free?
                string wednesdayisdefaultadd = Settings.Default["wednesdaystarttime"].ToString();
                string wednesdayisdefaultend = Settings.Default["wednesdayendtime"].ToString();
                string wednesdayisdefaultadd1 = Settings.Default["wednesdaystarttime1"].ToString();
                string wednesdayisdefaultend1 = Settings.Default["wednesdayendtime1"].ToString();
                string wednesdayisdefaultadd2 = Settings.Default["wednesdaystarttime2"].ToString();
                string wednesdayisdefaultend2 = Settings.Default["wednesdayendtime2"].ToString();

                bool wednesdaydefaultstart = string.Equals(defaultvariable, wednesdayisdefaultadd);
                bool wednesdaydefaultend = string.Equals(defaultvariable, wednesdayisdefaultend);
                bool wednesdaydefaultstart1 = string.Equals(defaultvariable, wednesdayisdefaultadd1);
                bool wednesdaydefaultend1 = string.Equals(defaultvariable, wednesdayisdefaultend1);
                bool wednesdaydefaultstart2 = string.Equals(defaultvariable, wednesdayisdefaultadd2);
                bool wednesdaydefaultend2 = string.Equals(defaultvariable, wednesdayisdefaultend2);

                // thursday slot free?
                string thursdayisdefaultadd = Settings.Default["thursdaystarttime"].ToString();
                string thursdayisdefaultend = Settings.Default["thursdayendtime"].ToString();
                string thursdayisdefaultadd1 = Settings.Default["thursdaystarttime1"].ToString();
                string thursdayisdefaultend1 = Settings.Default["thursdayendtime1"].ToString();
                string thursdayisdefaultadd2 = Settings.Default["thursdaystarttime2"].ToString();
                string thursdayisdefaultend2 = Settings.Default["thursdayendtime2"].ToString();

                bool thursdaydefaultstart = string.Equals(defaultvariable, thursdayisdefaultadd);
                bool thursdaydefaultend = string.Equals(defaultvariable, thursdayisdefaultend);
                bool thursdaydefaultstart1 = string.Equals(defaultvariable, thursdayisdefaultadd1);
                bool thursdaydefaultend1 = string.Equals(defaultvariable, thursdayisdefaultend1);
                bool thursdaydefaultstart2 = string.Equals(defaultvariable, thursdayisdefaultadd2);
                bool thursdaydefaultend2 = string.Equals(defaultvariable, thursdayisdefaultend2);

                // friday slot free?
                string fridayisdefaultadd = Settings.Default["fridaystarttime"].ToString();
                string fridayisdefaultend = Settings.Default["fridayendtime"].ToString();
                string fridayisdefaultadd1 = Settings.Default["fridaystarttime1"].ToString();
                string fridayisdefaultend1 = Settings.Default["fridayendtime1"].ToString();
                string fridayisdefaultadd2 = Settings.Default["fridaystarttime2"].ToString();
                string fridayisdefaultend2 = Settings.Default["fridayendtime2"].ToString();

                bool fridaydefaultstart = string.Equals(defaultvariable, fridayisdefaultadd);
                bool fridaydefaultend = string.Equals(defaultvariable, fridayisdefaultend);
                bool fridaydefaultstart1 = string.Equals(defaultvariable, fridayisdefaultadd1);
                bool fridaydefaultend1 = string.Equals(defaultvariable, fridayisdefaultend1);
                bool fridaydefaultstart2 = string.Equals(defaultvariable, fridayisdefaultadd2);
                bool fridaydefaultend2 = string.Equals(defaultvariable, fridayisdefaultend2);

                if (mondaydefaultstart == true && mondaydefaultend == true && tuesdaydefaultstart == true && tuesdaydefaultend == true && wednesdaydefaultstart == true && wednesdaydefaultend == true && thursdaydefaultstart == true && thursdaydefaultend == true && fridaydefaultstart == true && fridaydefaultend == true)
                {
                    // monday
                    Settings.Default["mondaystarttime"] = starttime.Text;
                    Settings.Default["mondayendtime"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime"] = starttime.Text;
                    Settings.Default["tuesdayendtime"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime"] = starttime.Text;
                    Settings.Default["wednesdayendtime"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime"] = starttime.Text;
                    Settings.Default["thursdayendtime"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime"] = starttime.Text;
                    Settings.Default["fridayendtime"] = endtime.Text;

                    Settings.Default.Save();

                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");

                }
                else if (mondaydefaultstart1 == true && mondaydefaultend1 == true && tuesdaydefaultstart1 == true && tuesdaydefaultend1 == true && wednesdaydefaultstart1 == true && wednesdaydefaultend1 == true && thursdaydefaultstart1 == true && thursdaydefaultend1 == true && fridaydefaultstart1 == true && fridaydefaultend1 == true)
                {

                    // monday
                    Settings.Default["mondaystarttime1"] = starttime.Text;
                    Settings.Default["mondayendtime1"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime1"] = starttime.Text;
                    Settings.Default["tuesdayendtime1"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime1"] = starttime.Text;
                    Settings.Default["wednesdayendtime1"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime1"] = starttime.Text;
                    Settings.Default["thursdayendtime1"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime1"] = starttime.Text;
                    Settings.Default["fridayendtime1"] = endtime.Text;

                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");

                }
                else if (mondaydefaultstart2 == true && mondaydefaultend2 == true && tuesdaydefaultstart2 == true && tuesdaydefaultend2 == true && wednesdaydefaultstart2 == true && wednesdaydefaultend2 == true && thursdaydefaultstart2 == true && thursdaydefaultend2 == true && fridaydefaultstart2 == true && fridaydefaultend2 == true)
                {
                    // monday
                    Settings.Default["mondaystarttime2"] = starttime.Text;
                    Settings.Default["mondayendtime2"] = endtime.Text;
                    // tuesday
                    Settings.Default["tuesdaystarttime2"] = starttime.Text;
                    Settings.Default["tuesdayendtime2"] = endtime.Text;
                    // wednesday
                    Settings.Default["wednesdaystarttime2"] = starttime.Text;
                    Settings.Default["wednesdayendtime2"] = endtime.Text;
                    // thursday 
                    Settings.Default["thursdaystarttime2"] = starttime.Text;
                    Settings.Default["thursdayendtime2"] = endtime.Text;
                    // friday
                    Settings.Default["fridaystarttime2"] = starttime.Text;
                    Settings.Default["fridayendtime2"] = endtime.Text;

                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else
                {
                    MessageBox.Show("There are no free slots to have this time every week day, please clear some slots to add a time for every week day. if you think this is a code error contact the creator from the 'help the creator' button on the dashboard");
                }
              
            




            }
            else if (isweekendselected == true)
            {
                string defaultvariable = "null";
                // saturday slot free?
                string saturdayisdefaultadd = Settings.Default["saturdaystarttime"].ToString();
                string saturdayisdefaultend = Settings.Default["saturdayendtime"].ToString();
                string saturdayisdefaultadd1 = Settings.Default["saturdaystarttime1"].ToString();
                string saturdayisdefaultend1 = Settings.Default["saturdayendtime1"].ToString();
                string saturdayisdefaultadd2 = Settings.Default["saturdaystarttime2"].ToString();
                string saturdayisdefaultend2 = Settings.Default["saturdayendtime2"].ToString();

                bool saturdaydefaultstart = string.Equals(defaultvariable, saturdayisdefaultadd);
                bool saturdaydefaultend = string.Equals(defaultvariable, saturdayisdefaultend);
                bool saturdaydefaultstart1 = string.Equals(defaultvariable, saturdayisdefaultadd1);
                bool saturdaydefaultend1 = string.Equals(defaultvariable, saturdayisdefaultend1);
                bool saturdaydefaultstart2 = string.Equals(defaultvariable, saturdayisdefaultadd2);
                bool saturdaydefaultend2 = string.Equals(defaultvariable, saturdayisdefaultend2);

                // sunday slot free?
                string sundayisdefaultadd = Settings.Default["sundaystarttime"].ToString();
                string sundayisdefaultend = Settings.Default["sundayendtime"].ToString();
                string sundayisdefaultadd1 = Settings.Default["sundaystarttime1"].ToString();
                string sundayisdefaultend1 = Settings.Default["sundayendtime1"].ToString();
                string sundayisdefaultadd2 = Settings.Default["sundaystarttime2"].ToString();
                string sundayisdefaultend2 = Settings.Default["sundayendtime2"].ToString();

                bool sundaydefaultstart = string.Equals(defaultvariable, sundayisdefaultadd);
                bool sundaydefaultend = string.Equals(defaultvariable, sundayisdefaultend);
                bool sundaydefaultstart1 = string.Equals(defaultvariable, sundayisdefaultadd1);
                bool sundaydefaultend1 = string.Equals(defaultvariable, sundayisdefaultend1);
                bool sundaydefaultstart2 = string.Equals(defaultvariable, sundayisdefaultadd2);
                bool sundaydefaultend2 = string.Equals(defaultvariable, sundayisdefaultend2);

                if (saturdaydefaultstart == true && sundaydefaultstart == true && saturdaydefaultend == true && sundaydefaultend == true)
                {

                    Settings.Default["saturdaystarttime"] = starttime.Text;
                    Settings.Default["saturdayendtime"] = endtime.Text;
                    Settings.Default["sundaystarttime"] = starttime.Text;
                    Settings.Default["sundayendtime"] = endtime.Text;
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                    Settings.Default.Save();
                }
                else if (saturdaydefaultstart1 == true && sundaydefaultstart1 == true && saturdaydefaultend1 == true && sundaydefaultend1 == true)
                {
                    Settings.Default["saturdaystarttime1"] = starttime.Text;
                    Settings.Default["saturdayendtime1"] = endtime.Text;
                    Settings.Default["sundaystarttime1"] = starttime.Text;
                    Settings.Default["sundayendtime1"] = endtime.Text;
                    Settings.Default.Save();
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else if (saturdaydefaultstart2 == true && sundaydefaultstart2 == true && saturdaydefaultend2 == true && sundaydefaultend2 == true)
                {
                    Settings.Default["saturdaystarttime2"] = starttime.Text;
                    Settings.Default["saturdayendtime2"] = endtime.Text;
                    Settings.Default["sundaystarttime2"] = starttime.Text;
                    Settings.Default["sundayendtime2"] = endtime.Text;
                    Settings.Default.Save();
                    MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
                }
                else
                {
                    MessageBox.Show("There are no free slots to have this time every weekend, please clear some slots to add a time for every weekend. if you think this is a code error contact the creator from the 'help the creator' button on the dashboard");
                }


                
            }
            else
            {
                MessageBox.Show("The application has encountered an unknown error, please restart, if this does not fix it, contact the owner of the app");
            }
        }

        private void tuesdayaddtime_Click(object sender, EventArgs e)
        {
            //string defaultvariable = "null";
            //string tuesdayisdefaultadd = Settings.Default["tuesdaystarttime"].ToString();
            //string tuesdayisdefaultend = Settings.Default["tuesdayendtime"].ToString();
            //string tuesdayisdefaultadd1 = Settings.Default["tuesdaystarttime1"].ToString();
            //string tuesdayisdefaultend1 = Settings.Default["tuesdayendtime1"].ToString();
            //string tuesdayisdefaultadd2 = Settings.Default["tuesdaystarttime2"].ToString();
            //string tuesdayisdefaultend2 = Settings.Default["tuesdayendtime2"].ToString();

            //bool tuesdaydefaultstart = string.Equals(defaultvariable, tuesdayisdefaultadd);
            //bool tuesdaydefaultend = string.Equals(defaultvariable, tuesdayisdefaultend);
            //bool tuesdaydefaultstart1 = string.Equals(defaultvariable, tuesdayisdefaultadd1);
            //bool tuesdaydefaultend1 = string.Equals(defaultvariable, tuesdayisdefaultend1);
            //bool tuesdaydefaultstart2 = string.Equals(defaultvariable, tuesdayisdefaultadd2);
            //bool tuesdaydefaultend2 = string.Equals(defaultvariable, tuesdayisdefaultend2);

            //if (tuesdaydefaultstart == true && tuesdaydefaultend == true)
            
                //Settings.Default["tuesdaystarttime"] = tuesdaystarttime.Text;
                //Settings.Default["tuesdayendtime"] = tuesdayendtime.Text;
                //MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
            
            //else if (tuesdaydefaultstart1 = true && tuesdaydefaultend1 == true)
            
                //Settings.Default["tuesdaystarttime1"] = tuesdaystarttime.Text;
                //Settings.Default["tuesdayendtime1"] = tuesdayendtime.Text;
                //MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
            
            //else if (tuesdaydefaultstart2 == true && tuesdaydefaultend2 == true)
            
                //Settings.Default["tuesdaystarttime2"] = tuesdaystarttime.Text;
                //Settings.Default["tuesdayendtime2"] = tuesdayendtime.Text;
                //MessageBox.Show("You have added a new time! view your changes in 'schedule' on the home page or in 'edit times' on this page");
            
            //else
            
                //MessageBox.Show("You have set too many times, please go to 'edit times' and delete one to make room");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new edittimes();
            f.Show();
        }

        private void wednesdayaddtime_Click(object sender, EventArgs e)
        {
  

        }

        private void downtime_Load(object sender, EventArgs e)
        {

        }

        private void mondaystarttime_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thursdayaddtime_Click(object sender, EventArgs e)
        {
         

        }

        private void fridayaddtime_Click(object sender, EventArgs e)
        {
      
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mondayendtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "yes";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void selectedthursday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["thursdayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void selectedtuesday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["tuesdayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void selectedwednesday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["wednesdayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["fridayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();

        }

        private void label27_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["saturdayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;

            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["mondayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["tuesdayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["wednesdayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["thursdayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button6.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["fridayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button7.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["saturdayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button8.ForeColor = Color.Lime;
            button9.ForeColor = Color.White;
            Settings.Default["everydayselected"] = "no";
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button9.ForeColor = Color.Lime;
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["everydayselected"] = "yes";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();
        }

        private void weekday_Click(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            weekday.ForeColor = Color.Lime;
            weekend.ForeColor = Color.White;
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["weekdayselected"] = "yes";
            Settings.Default["weekendselected"] = "no";
            Settings.Default.Save();



        }

        private void weekend_Click(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            weekday.ForeColor = Color.White;
            weekend.ForeColor = Color.Lime;

            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";
            Settings.Default["everydayselected"] = "no";
            Settings.Default["weekdayselected"] = "no";
            Settings.Default["weekendselected"] = "yes";

            Settings.Default.Save();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
