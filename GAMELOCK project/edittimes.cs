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
    public partial class edittimes : Form
    {
        public edittimes()
        {
            InitializeComponent();
        }

        private void mondaystarttime_Click(object sender, EventArgs e)
        {

        }

        private void edittimes_Load(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "open";
            Settings.Default["mondaydelete1"] = "open";
            Settings.Default["mondaydelete2"] = "open";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";

            starttime.Text = Settings.Default["mondaystarttime"].ToString();
            endtime.Text = Settings.Default["mondayendtime"].ToString();

            starttime1.Text = Settings.Default["mondaystarttime1"].ToString();
            endtime1.Text = Settings.Default["mondayendtime1"].ToString();

            starttime2.Text = Settings.Default["mondaystarttime2"].ToString();
            endtime2.Text = Settings.Default["mondayendtime2"].ToString();

            Settings.Default["edittimeswindow"] = "open";
            mondayon.Visible = true;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            

        }

        private void deletemonday1time_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mondaystarttime1_Click(object sender, EventArgs e)
        {

        }

        private void deletemonday2time_Click(object sender, EventArgs e)
        {
           
        }

        private void deletemonday3time_Click(object sender, EventArgs e)
        {
           
        }

        private void deletetuesday1time_Click(object sender, EventArgs e)
        {
           
        }

        private void deletetuesday2time_Click(object sender, EventArgs e)
        {
         
        }

        private void deletetuesday3time_Click(object sender, EventArgs e)
        {
         
        }

        private void wednesdaydeletetime_Click(object sender, EventArgs e)
        {
         
        }

        private void wednesdaydeletetime1_Click(object sender, EventArgs e)
        {
           
        }

        private void wednesdaydeletetime2_Click(object sender, EventArgs e)
        {
            Settings.Default["wednesdaystarttime2"] = "null";
            Settings.Default["wednesdayendtime2"] = "null";
            Settings.Default.Save();
            //wednesdaystarttime2.Text = Settings.Default["wednesdaystarttime2"].ToString();
            //wednesdayendtime2.Text = Settings.Default["wednesdayendtime2"].ToString();
        }

        private void thursdaydeletetime_Click(object sender, EventArgs e)
        {
           
        }

        private void thursdaydeletetime1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings.Default["edittimeswindow"] = "closed";
            Settings.Default.Save();
            this.Close();

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fridaydeletetime_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "open";
            Settings.Default["mondaydelete1"] = "open";
            Settings.Default["mondaydelete2"] = "open";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["mondaystarttime"].ToString();
            endtime.Text = Settings.Default["mondayendtime"].ToString();

            starttime1.Text = Settings.Default["mondaystarttime1"].ToString();
            endtime1.Text = Settings.Default["mondayendtime1"].ToString();

            starttime2.Text = Settings.Default["mondaystarttime2"].ToString();
            starttime2.Text = Settings.Default["mondayendtime2"].ToString();


            mondayon.Visible = true;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            
        }

        private void tuesday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "open";
            Settings.Default["tuesdaydelete1"] = "open";
            Settings.Default["tuesdaydelete2"] = "open";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["tuesdaystarttime"].ToString();
            endtime.Text = Settings.Default["tuesdayendtime"].ToString();

            starttime1.Text = Settings.Default["tuesdaystarttime1"].ToString();
            endtime1.Text = Settings.Default["tuesdayendtime1"].ToString();

            starttime2.Text = Settings.Default["tuesdaystarttime2"].ToString();
            endtime2.Text = Settings.Default["tuesdayendtime2"].ToString();

            mondayon.Visible = false;
            tuesdayon.Visible = true;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            
        }

        private void wednesday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "open";
            Settings.Default["wednesdaydelete1"] = "open";
            Settings.Default["wednesdaydelete2"] = "open";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["wednesdaystarttime"].ToString();
            endtime.Text = Settings.Default["wednesdayendtime"].ToString();

            starttime1.Text = Settings.Default["wednesdaystarttime1"].ToString();
            endtime1.Text = Settings.Default["wednesdayendtime1"].ToString();

            starttime2.Text = Settings.Default["wednesdaystarttime2"].ToString();
            endtime2.Text = Settings.Default["wednesdayendtime2"].ToString();

            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = true;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
           
        }

        private void thursday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "open";
            Settings.Default["thursdaydelete1"] = "open";
            Settings.Default["thursdaydelete2"] = "open";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["thursdaystarttime"].ToString();
            endtime.Text = Settings.Default["thursdayendtime"].ToString();

            starttime1.Text = Settings.Default["thursdaystarttime1"].ToString();
            endtime1.Text = Settings.Default["thursdayendtime1"].ToString();

            starttime2.Text = Settings.Default["thursdaystarttime2"].ToString();
            endtime2.Text = Settings.Default["thursdayendtime2"].ToString();

            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = true;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
           
        }

        private void friday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "open";
            Settings.Default["fridaydelete1"] = "open";
            Settings.Default["fridaydelete2"] = "open";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["fridaystarttime"].ToString();
            endtime.Text = Settings.Default["fridayendtime"].ToString();

            starttime1.Text = Settings.Default["fridaystarttime1"].ToString();
            endtime1.Text = Settings.Default["fridayendtime1"].ToString();
            
            starttime2.Text = Settings.Default["fridaystarttime2"].ToString();
            endtime2.Text = Settings.Default["fridayendtime2"].ToString();


            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = true;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            weekdayon.Visible = false;
           
        }

        private void saturday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "open";
            Settings.Default["saturdaydelete1"] = "open";
            Settings.Default["saturdaydelete2"] = "open";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();


            starttime.Text = Settings.Default["saturdaystarttime"].ToString();
            endtime.Text = Settings.Default["saturdayendtime"].ToString();

            starttime1.Text = Settings.Default["saturdaystarttime1"].ToString();
            endtime1.Text = Settings.Default["saturdayendtime1"].ToString();

            starttime2.Text = Settings.Default["saturdaystarttime2"].ToString();
            endtime2.Text = Settings.Default["saturdayendtime2"].ToString();

            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = true;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            
        }

        private void sunday_Click(object sender, EventArgs e)
        {
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "open";
            Settings.Default["sundaydelete1"] = "open";
            Settings.Default["sundaydelete2"] = "open";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            Settings.Default.Save();

            starttime.Text = Settings.Default["sundaystarttime"].ToString();
            endtime.Text = Settings.Default["sundayendtime"].ToString();

            starttime1.Text = Settings.Default["sundaystarttime1"].ToString();
            endtime1.Text = Settings.Default["sundayendtime1"].ToString();

            starttime2.Text = Settings.Default["sundaystarttime2"].ToString();
            endtime2.Text = Settings.Default["sundayendtime2"].ToString();

            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = true;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            
        }

        private void starttime_Click(object sender, EventArgs e)
        {





        }

        private void deletetime2_Click(object sender, EventArgs e)
        {

            string defaultisopen2 = "closed";
            string mondayopen2 = Settings.Default["mondaydelete"].ToString();
            string tuesdayopen2 = Settings.Default["tuesdaydelete"].ToString();
            string wednesdayopen2 = Settings.Default["wednesdaydelete"].ToString();
            string thursdayopen2 = Settings.Default["thursdaydelete"].ToString();
            string fridayopen2 = Settings.Default["fridaydelete"].ToString();
            string saturdayopen2 = Settings.Default["saturdaydelete"].ToString();
            string sundayopen2 = Settings.Default["sundaydelete"].ToString();
            string everydayopen2 = Settings.Default["everydaydelete1"].ToString();
            string weekdayopen2 = Settings.Default["weekdaydelete"].ToString();
            string weekendopen2 = Settings.Default["weekenddelete"].ToString();

            bool weekenddefaultdelete2 = string.Equals(defaultisopen2, weekendopen2);
            bool weekdaydefaultdelete2 = string.Equals(defaultisopen2, weekdayopen2);
            bool everydaydefaultdelete2 = string.Equals(defaultisopen2, everydayopen2);
            bool mondaydefaultdelete2 = string.Equals(defaultisopen2, mondayopen2);
            bool tuesdaydefaultdelete2 = string.Equals(defaultisopen2, tuesdayopen2);
            bool wednesdaydefaultdelete2 = string.Equals(defaultisopen2, wednesdayopen2);
            bool thursdaydefaultdelete2 = string.Equals(defaultisopen2, thursdayopen2);
            bool fridaydefaultdelete2 = string.Equals(defaultisopen2, fridayopen2);
            bool saturdaydefaultdelete2 = string.Equals(defaultisopen2, saturdayopen2);
            bool sundaydefaultdelete2 = string.Equals(defaultisopen2, sundayopen2);

            if (mondaydefaultdelete2 == false)
            {
                Settings.Default["mondaystarttime2"] = "null";
                Settings.Default["mondayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["mondaystarttime2"].ToString();
                endtime2.Text = Settings.Default["mondayendtime2"].ToString();
            }
            else if (tuesdaydefaultdelete2 == false)
            {
                Settings.Default["tuesdaystarttime2"] = "null";
                Settings.Default["tuesdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["tuesdaystarttime2"].ToString();
                endtime2.Text = Settings.Default["tuesdayendtime2"].ToString();
            }
            else if (wednesdaydefaultdelete2 == false)
            {
                Settings.Default["wednesdaystarttime2"] = "null";
                Settings.Default["wednesdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["wednesdaystarttime2"].ToString();
                endtime2.Text = Settings.Default["wednesdayendtime2"].ToString();
            }
            else if (thursdaydefaultdelete2 == false)
            {
                Settings.Default["thursdaystarttime2"] = "null";
                Settings.Default["thursdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["thursdaystarttime2"].ToString();
                endtime2.Text = Settings.Default["thursdayendtime2"].ToString();
            }
            else if (fridaydefaultdelete2 == false)
            {
                Settings.Default["fridaystarttime2"] = "null";
                Settings.Default["fridayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["fridaystarttime2"].ToString();
                endtime2.Text = Settings.Default["fridayendtime2"].ToString();
            }
            else if (saturdaydefaultdelete2 == false)
            {
                Settings.Default["saturdaystarttime2"] = "null";
                Settings.Default["saturdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["saturdaystarttime2"].ToString();
                endtime2.Text = Settings.Default["saturdayendtime2"].ToString();
            }
            else if (sundaydefaultdelete2 == false)
            {
                Settings.Default["sundaystarttime2"] = "null";
                Settings.Default["sundayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["sundaystarttime2"].ToString();
                endtime2.Text = Settings.Default["sundayendtime2"].ToString();
            }
            else if (everydaydefaultdelete2 == false)
            {
                Settings.Default["mondaystarttime2"] = "null";
                Settings.Default["mondayendtime2"] = "null";
                Settings.Default["tuesdaystarttime2"] = "null";
                Settings.Default["tuesdayendtime2"] = "null";
                Settings.Default["wednesdaystarttime2"] = "null";
                Settings.Default["wednesdayendtime2"] = "null";
                Settings.Default["thursdaystarttime2"] = "null";
                Settings.Default["thursdayendtime2"] = "null";
                Settings.Default["fridaystarttime2"] = "null";
                Settings.Default["fridayendtime2"] = "null";
                Settings.Default["saturdaystarttime2"] = "null";
                Settings.Default["sundaystarttime2"] = "null";
                Settings.Default["sundayendtime2"] = "null";
                Settings.Default["saturdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = Settings.Default["sundaystarttime2"].ToString();
                endtime2.Text = Settings.Default["sundayendtime2"].ToString();

            }
            else if (weekdaydefaultdelete2 == false)
            {
                Settings.Default["mondaystarttime2"] = "null";
                Settings.Default["mondayendtime2"] = "null";
                Settings.Default["tuesdaystarttime2"] = "null";
                Settings.Default["tuesdayendtime2"] = "null";
                Settings.Default["wednesdaystarttime2"] = "null";
                Settings.Default["wednesdayendtime2"] = "null";
                Settings.Default["thursdaystarttime2"] = "null";
                Settings.Default["thursdayendtime2"] = "null";
                Settings.Default["fridaystarttime2"] = "null";
                Settings.Default["fridayendtime2"] = "null";

                starttime2.Text = "null";
                endtime2.Text = "null";
            }
            else if (weekenddefaultdelete2 == false)
            {
                Settings.Default["saturdaystarttime2"] = "null";
                Settings.Default["sundaystarttime2"] = "null";
                Settings.Default["sundayendtime2"] = "null";
                Settings.Default["saturdayendtime2"] = "null";
                Settings.Default.Save();

                starttime2.Text = "null";
                endtime2.Text = "null";
            }
            else
            {
                MessageBox.Show("There is a code error, please contact the creator on the 'help the creator' page on the dashboard");
            }

        }

        private void deletetime_Click(object sender, EventArgs e)
        {
            string defaultisopen = "closed";
            string mondayopen = Settings.Default["mondaydelete"].ToString();
            string tuesdayopen = Settings.Default["tuesdaydelete"].ToString();
            string wednesdayopen = Settings.Default["wednesdaydelete"].ToString();
            string thursdayopen = Settings.Default["thursdaydelete"].ToString();
            string fridayopen = Settings.Default["fridaydelete"].ToString();
            string saturdayopen = Settings.Default["saturdaydelete"].ToString();
            string sundayopen = Settings.Default["sundaydelete"].ToString();
            string everydayopen = Settings.Default["everydaydelete"].ToString();
            string weekdayopen = Settings.Default["weekdaydelete"].ToString();
            string weekendopen = Settings.Default["weekenddelete"].ToString();

            bool weekenddefaultdelete = string.Equals(defaultisopen, weekendopen);
            bool weekdaydefaultdelete = string.Equals(defaultisopen, weekdayopen);
            bool everydaydefaultdelete = string.Equals(defaultisopen, everydayopen);
            bool mondaydefaultdelete = string.Equals(defaultisopen, mondayopen);
            bool tuesdaydefaultdelete = string.Equals(defaultisopen, tuesdayopen);
            bool wednesdaydefaultdelete = string.Equals(defaultisopen, wednesdayopen);
            bool thursdaydefaultdelete = string.Equals(defaultisopen, thursdayopen);
            bool fridaydefaultdelete = string.Equals(defaultisopen, fridayopen);
            bool saturdaydefaultdelete = string.Equals(defaultisopen, saturdayopen);
            bool sundaydefaultdelete = string.Equals(defaultisopen, sundayopen);

            if (mondaydefaultdelete == false)
            {
                Settings.Default["mondaystarttime"] = "null";
                Settings.Default["mondayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["mondaystarttime"].ToString();
                endtime.Text = Settings.Default["mondayendtime"].ToString();
            }
           else if (tuesdaydefaultdelete == false)
            {
                Settings.Default["tuesdaystarttime"] = "null";
                Settings.Default["tuesdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["tuesdaystarttime"].ToString();
                endtime.Text = Settings.Default["tuesdayendtime"].ToString();
            }
            else if (wednesdaydefaultdelete == false)
            {
                Settings.Default["wednesdaystarttime"] = "null";
                Settings.Default["wednesdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["wednesdaystarttime"].ToString();
                endtime.Text = Settings.Default["wednesdayendtime"].ToString();
            }
            else if (thursdaydefaultdelete == false)
            {
                Settings.Default["thursdaystarttime"] = "null";
                Settings.Default["thursdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["thursdaystarttime"].ToString();
                endtime.Text = Settings.Default["thursdayendtime"].ToString();
            }
            else if (fridaydefaultdelete == false)
            {
                Settings.Default["fridaystarttime"] = "null";
                Settings.Default["fridayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["fridaystarttime"].ToString();
                endtime.Text = Settings.Default["fridayendtime"].ToString();
            }
            else if (saturdaydefaultdelete == false)
            {
                Settings.Default["saturdaystarttime"] = "null";
                Settings.Default["saturdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["saturdaystarttime"].ToString();
                endtime.Text = Settings.Default["saturdayendtime"].ToString();
            }
            else if (sundaydefaultdelete == false)
            {
                Settings.Default["sundaystarttime"] = "null";
                Settings.Default["sundayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = Settings.Default["sundaystarttime"].ToString();
                endtime.Text = Settings.Default["sundayendtime"].ToString();
            }
            else if(everydaydefaultdelete == false)
            {
                Settings.Default["mondaystarttime"] = "null";
                Settings.Default["mondayendtime"] = "null";
                Settings.Default["tuesdaystarttime"] = "null";
                Settings.Default["tuesdayendtime"] = "null";
                Settings.Default["wednesdaystarttime"] = "null";
                Settings.Default["wednesdayendtime"] = "null";
                Settings.Default["thursdaystarttime"] = "null";
                Settings.Default["thursdayendtime"] = "null";
                Settings.Default["fridaystarttime"] = "null";
                Settings.Default["fridayendtime"] = "null";
                Settings.Default["saturdaystarttime"] = "null";
                Settings.Default["sundaystarttime"] = "null";
                Settings.Default["sundayendtime"] = "null";
                Settings.Default["saturdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = "null";
                endtime.Text = "null";

            }
            else if (weekdaydefaultdelete == false)
            {

                Settings.Default["mondaystarttime"] = "null";
                Settings.Default["mondayendtime"] = "null";
                Settings.Default["tuesdaystarttime"] = "null";
                Settings.Default["tuesdayendtime"] = "null";
                Settings.Default["wednesdaystarttime"] = "null";
                Settings.Default["wednesdayendtime"] = "null";
                Settings.Default["thursdaystarttime"] = "null";
                Settings.Default["thursdayendtime"] = "null";
                Settings.Default["fridaystarttime"] = "null";
                Settings.Default["fridayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = "null";
                endtime.Text = "null";
            }
            else if (weekenddefaultdelete == false)
            {
                Settings.Default["saturdaystarttime"] = "null";
                Settings.Default["sundaystarttime"] = "null";
                Settings.Default["sundayendtime"] = "null";
                Settings.Default["saturdayendtime"] = "null";
                Settings.Default.Save();

                starttime.Text = "null";
                endtime.Text = "null";
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void deletetime1_Click(object sender, EventArgs e)
        {
            string defaultisopen1 = "closed";
            string mondayopen1 = Settings.Default["mondaydelete1"].ToString();
            string tuesdayopen1 = Settings.Default["tuesdaydelete1"].ToString();
            string wednesdayopen1 = Settings.Default["wednesdaydelete1"].ToString();
            string thursdayopen1 = Settings.Default["thursdaydelete1"].ToString();
            string fridayopen1 = Settings.Default["fridaydelete1"].ToString();
            string saturdayopen1 = Settings.Default["saturdaydelete1"].ToString();
            string sundayopen1 = Settings.Default["sundaydelete1"].ToString();
            string everydayopen1 = Settings.Default["everydaydelete1"].ToString();
            string weekdayopen1 = Settings.Default["weekdaydelete1"].ToString();
            string weekendopen1 = Settings.Default["weekenddelete1"].ToString();

            bool weekenddefaultdelete = string.Equals(defaultisopen1, weekendopen1);
            bool weekdaydefaultdelete1 = string.Equals(defaultisopen1, weekdayopen1);
            bool everydaydefaultdelete1 = string.Equals(defaultisopen1, everydayopen1);
            bool mondaydefaultdelete1 = string.Equals(defaultisopen1, mondayopen1);
            bool tuesdaydefaultdelete1 = string.Equals(defaultisopen1, tuesdayopen1);
            bool wednesdaydefaultdelete1 = string.Equals(defaultisopen1, wednesdayopen1);
            bool thursdaydefaultdelete1 = string.Equals(defaultisopen1, thursdayopen1);
            bool fridaydefaultdelete1 = string.Equals(defaultisopen1, fridayopen1);
            bool saturdaydefaultdelete1 = string.Equals(defaultisopen1, saturdayopen1);
            bool sundaydefaultdelete1 = string.Equals(defaultisopen1, sundayopen1);

            if (mondaydefaultdelete1 == false)
            {
                Settings.Default["mondaystarttime1"] = "null";
                Settings.Default["mondayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["mondaystarttime1"].ToString();
                endtime1.Text = Settings.Default["mondayendtime1"].ToString();
            }
            else if (tuesdaydefaultdelete1 == false)
            {
                Settings.Default["tuesdaystarttime1"] = "null";
                Settings.Default["tuesdayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["tuesdaystarttime1"].ToString();
                endtime1.Text = Settings.Default["tuesdayendtime1"].ToString();
            }
            else if (wednesdaydefaultdelete1 == false)
            {
                Settings.Default["wednesdaystarttime1"] = "null";
                Settings.Default["wednesdayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["wednesdaystarttime1"].ToString();
                endtime1.Text = Settings.Default["wednesdayendtime1"].ToString();
            }
            else if (thursdaydefaultdelete1 == false)
            {
                Settings.Default["thursdaystarttime1"] = "null";
                Settings.Default["thursdayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["thursdaystarttime1"].ToString();
                endtime1.Text = Settings.Default["thursdayendtime1"].ToString();
            }
            else if (fridaydefaultdelete1 == false)
            {
                Settings.Default["fridaystarttime1"] = "null";
                Settings.Default["fridayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["fridaystarttime1"].ToString();
                endtime1.Text = Settings.Default["fridayendtime1"].ToString();
            }
            else if (saturdaydefaultdelete1 == false)
            {
                Settings.Default["saturdaystarttime1"] = "null";
                Settings.Default["saturdayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["saturdaystarttime1"].ToString();
                endtime1.Text = Settings.Default["saturdayendtime1"].ToString();
            }
            else if (sundaydefaultdelete1 == false)
            {
                Settings.Default["sundaystarttime1"] = "null";
                Settings.Default["sundayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = Settings.Default["sundaystarttime1"].ToString();
                endtime1.Text = Settings.Default["sundayendtime1"].ToString();
            }
            else if (everydaydefaultdelete1 == false)
            {
                Settings.Default["mondaystarttime1"] = "null";
                Settings.Default["mondayendtime1"] = "null";
                Settings.Default["tuesdaystarttime1"] = "null";
                Settings.Default["tuesdayendtime1"] = "null";
                Settings.Default["wednesdaystarttime1"] = "null";
                Settings.Default["wednesdayendtime1"] = "null";
                Settings.Default["thursdaystarttime1"] = "null";
                Settings.Default["thursdayendtime1"] = "null";
                Settings.Default["fridaystarttime1"] = "null";
                Settings.Default["fridayendtime1"] = "null";
                Settings.Default["saturdaystarttime1"] = "null";
                Settings.Default["sundaystarttime1"] = "null";
                Settings.Default["sundayendtime1"] = "null";
                Settings.Default["saturdayendtime1"] = "null";
                Settings.Default.Save();

                starttime1.Text = "null";
                endtime1.Text = "null";

            }
            else if (weekdaydefaultdelete1 == false)
            {
                Settings.Default["mondaystarttime1"] = "null";
                Settings.Default["mondayendtime1"] = "null";
                Settings.Default["tuesdaystarttime1"] = "null";
                Settings.Default["tuesdayendtime1"] = "null";
                Settings.Default["wednesdaystarttime1"] = "null";
                Settings.Default["wednesdayendtime1"] = "null";
                Settings.Default["thursdaystarttime1"] = "null";
                Settings.Default["thursdayendtime1"] = "null";
                Settings.Default["fridaystarttime1"] = "null";
                Settings.Default["fridayendtime1"] = "null";

                starttime1.Text = "null";
                endtime1.Text = "null";

            }
            else if (weekenddefaultdelete == false)
            {
                Settings.Default["saturdaystarttime1"] = "null";
                Settings.Default["sundaystarttime1"] = "null";
                Settings.Default["sundayendtime1"] = "null";
                Settings.Default["saturdayendtime1"] = "null";
                Settings.Default.Save();
                starttime1.Text = "null";
                endtime1.Text = "null";
            }
            else
            {
                MessageBox.Show("There is a code error, please contact the creator on the 'help the creator' page on the dashboard");
            }
        }

        private void starttime2_Click(object sender, EventArgs e)
        {

        }

        private void endtime2_Click(object sender, EventArgs e)
        {

        }

        private void everyday_Click(object sender, EventArgs e)
        {
            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = true;
            weekdayon.Visible = false;
           

            // telling it to delete if one of them is 'open'
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "open";
            Settings.Default["everydaydelete1"] = "open";
            Settings.Default["everydaydelete2"] = "open";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";

            // to check all times are the same, if they are, it displays the text

            // check if first slot are all the same
            string mondayopen = Settings.Default["mondaystarttime"].ToString();
            string tuesdayopen = Settings.Default["tuesdaystarttime"].ToString();
            string wednesdayopen = Settings.Default["wednesdaystarttime"].ToString();
            string thursdayopen = Settings.Default["thursdaystarttime"].ToString();
            string fridayopen = Settings.Default["fridaystarttime"].ToString();
            string saturdayopen = Settings.Default["saturdaystarttime"].ToString();
            string sundayopen = Settings.Default["sundaystarttime"].ToString();

            bool montuethesame = string.Equals(mondayopen, tuesdayopen);
            bool wedthursthesame = string.Equals(wednesdayopen, thursdayopen);
            bool frisatthesame = string.Equals(fridayopen, saturdayopen);
            bool satsunthesame = string.Equals(sundayopen, saturdayopen);

            // check if second slot are all the same

            string mondayopen1 = Settings.Default["mondaystarttime1"].ToString();
            string tuesdayopen1 = Settings.Default["tuesdaystarttime1"].ToString();
            string wednesdayopen1 = Settings.Default["wednesdaystarttime1"].ToString();
            string thursdayopen1 = Settings.Default["thursdaystarttime1"].ToString();
            string fridayopen1 = Settings.Default["fridaystarttime1"].ToString();
            string saturdayopen1 = Settings.Default["saturdaystarttime1"].ToString();
            string sundayopen1 = Settings.Default["sundaystarttime1"].ToString();

            bool montuethesame1 = string.Equals(mondayopen1, tuesdayopen1);
            bool wedthursthesame1 = string.Equals(wednesdayopen1, thursdayopen1);
            bool frisatthesame1 = string.Equals(fridayopen1, saturdayopen1);
            bool satsunthesame1 = string.Equals(sundayopen1, saturdayopen1);

            // check if third slot are all the same

            string mondayopen2 = Settings.Default["mondaystarttime2"].ToString();
            string tuesdayopen2 = Settings.Default["tuesdaystarttime2"].ToString();
            string wednesdayopen2 = Settings.Default["wednesdaystarttime2"].ToString();
            string thursdayopen2 = Settings.Default["thursdaystarttime2"].ToString();
            string fridayopen2 = Settings.Default["fridaystarttime2"].ToString();
            string saturdayopen2 = Settings.Default["saturdaystarttime2"].ToString();
            string sundayopen2 = Settings.Default["sundaystarttime2"].ToString();

            bool montuethesame2 = string.Equals(mondayopen2, tuesdayopen2);
            bool wedthursthesame2 = string.Equals(wednesdayopen2, thursdayopen2);
            bool frisatthesame2 = string.Equals(fridayopen2, saturdayopen2);
            bool satsunthesame2 = string.Equals(sundayopen2, saturdayopen2);

            // if 1st slot are the same, it displays it in everyday
            if (montuethesame == true && wedthursthesame == true && frisatthesame == true && satsunthesame == true)
            {
                // if they are all the same, it displays one of them as the text, it doesn't matter which because they are all the same
                starttime.Text = Settings.Default["sundaystarttime"].ToString();
                endtime.Text = Settings.Default["sundayendtime"].ToString();
            }
            else if (montuethesame1 == true && wedthursthesame1 == true && frisatthesame1 == true && satsunthesame1 == true)
            {
                starttime1.Text = Settings.Default["sundaystarttime1"].ToString();
                endtime1.Text = Settings.Default["sundayendtime1"].ToString();
            }
            else if (montuethesame2 == true && wedthursthesame2 == true && frisatthesame2 == true && satsunthesame2 == true)
            {
                starttime2.Text = Settings.Default["sundaystarttime2"].ToString();
                endtime2.Text = Settings.Default["sundayendtime2"].ToString();
            }
            else
            {
                starttime.Text = "null";
                endtime.Text = "null";
                starttime1.Text = "null";
                endtime1.Text = "null";
                starttime2.Text = "null";
                endtime2.Text = "null";
            }
            Settings.Default.Save();
        }

        private void weekday_Click(object sender, EventArgs e)
        {
            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = true;
           
            // telling it to delete if one of them is 'open'
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "open";
            Settings.Default["weekdaydelete1"] = "open";
            Settings.Default["weekdaydelete2"] = "open";
            Settings.Default["weekenddelete"] = "closed";
            Settings.Default["weekenddelete1"] = "closed";
            Settings.Default["weekenddelete2"] = "closed";
            // check if first slot are all the same
            string mondayopen = Settings.Default["mondaystarttime"].ToString();
            string tuesdayopen = Settings.Default["tuesdaystarttime"].ToString();
            string wednesdayopen = Settings.Default["wednesdaystarttime"].ToString();
            string thursdayopen = Settings.Default["thursdaystarttime"].ToString();
            string fridayopen = Settings.Default["fridaystarttime"].ToString();

            bool montuethesame = string.Equals(mondayopen, tuesdayopen);
            bool wedthursthesame = string.Equals(wednesdayopen, thursdayopen);
            bool thursfrithesame = string.Equals(thursdayopen, fridayopen);


            // check if second slot are all the same

            string mondayopen1 = Settings.Default["mondaystarttime1"].ToString();
            string tuesdayopen1 = Settings.Default["tuesdaystarttime1"].ToString();
            string wednesdayopen1 = Settings.Default["wednesdaystarttime1"].ToString();
            string thursdayopen1 = Settings.Default["thursdaystarttime1"].ToString();
            string fridayopen1 = Settings.Default["fridaystarttime1"].ToString();
           

            bool montuethesame1 = string.Equals(mondayopen1, tuesdayopen1);
            bool wedthursthesame1 = string.Equals(wednesdayopen1, thursdayopen1);
            bool thursfrithesame1 = string.Equals(thursdayopen1, fridayopen1);

            // check if third slot are all the same

            string mondayopen2 = Settings.Default["mondaystarttime2"].ToString();
            string tuesdayopen2 = Settings.Default["tuesdaystarttime2"].ToString();
            string wednesdayopen2 = Settings.Default["wednesdaystarttime2"].ToString();
            string thursdayopen2 = Settings.Default["thursdaystarttime2"].ToString();
            string fridayopen2 = Settings.Default["fridaystarttime2"].ToString();

            bool montuethesame2 = string.Equals(mondayopen2, tuesdayopen2);
            bool wedthursthesame2 = string.Equals(wednesdayopen2, thursdayopen2);
            bool thursfrithesame2 = string.Equals(thursdayopen2, fridayopen2);

            if (montuethesame == true && wedthursthesame == true && thursfrithesame == true)
            {
                starttime.Text = Settings.Default["mondaystarttime"].ToString();
                endtime.Text = Settings.Default["mondayendtime"].ToString();
            }
            else if (montuethesame1 == true && wedthursthesame1 == true && thursfrithesame == true)
            {
                starttime1.Text = Settings.Default["mondaystarttime1"].ToString();
                endtime1.Text = Settings.Default["mondayendtime1"].ToString();
            }
            else if (montuethesame2 == true && wedthursthesame2 == true && thursfrithesame2 == true)
            {
                starttime2.Text = Settings.Default["mondaystarttime2"].ToString();
                endtime2.Text = Settings.Default["mondayendtime2"].ToString();
            }
        }

        private void weekday_click(object sender, EventArgs e)
        {
        

        }

        private void weekend_Click(object sender, EventArgs e)
        {
            mondayon.Visible = false;
            tuesdayon.Visible = false;
            wednesdayon.Visible = false;
            thursdayon.Visible = false;
            fridayon.Visible = false;
            saturdayon.Visible = false;
            sundayon.Visible = false;
            everydayon.Visible = false;
            weekdayon.Visible = false;
            

            // telling it to delete if one of them is 'open'
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete1"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
            Settings.Default["wednesdaydelete"] = "closed";
            Settings.Default["wednesdaydelete1"] = "closed";
            Settings.Default["wednesdaydelete2"] = "closed";
            Settings.Default["thursdaydelete"] = "closed";
            Settings.Default["thursdaydelete1"] = "closed";
            Settings.Default["thursdaydelete2"] = "closed";
            Settings.Default["fridaydelete"] = "closed";
            Settings.Default["fridaydelete1"] = "closed";
            Settings.Default["fridaydelete2"] = "closed";
            Settings.Default["saturdaydelete"] = "closed";
            Settings.Default["saturdaydelete1"] = "closed";
            Settings.Default["saturdaydelete2"] = "closed";
            Settings.Default["sundaydelete"] = "closed";
            Settings.Default["sundaydelete1"] = "closed";
            Settings.Default["sundaydelete2"] = "closed";
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["weekdaydelete"] = "closed";
            Settings.Default["weekdaydelete1"] = "closed";
            Settings.Default["weekdaydelete2"] = "closed";
            Settings.Default["weekenddelete"] = "open";
            Settings.Default["weekenddelete1"] = "open";
            Settings.Default["weekenddelete2"] = "open";

            // check first slot
            string saturdayopen = Settings.Default["saturdaystarttime"].ToString();
            string sundayopen = Settings.Default["sundaystarttime"].ToString();
            

            // check second slot
            string saturdayopen1 = Settings.Default["saturdaystarttime1"].ToString();
            string sundayopen1 = Settings.Default["sundaystarttime1"].ToString();

            // check third slot
            string saturdayopen2 = Settings.Default["saturdaystarttime2"].ToString();
            string sundayopen2 = Settings.Default["sundaystarttime2"].ToString();


            bool satsunthesame = string.Equals(saturdayopen, sundayopen);
            bool satsunthesame1 = string.Equals(saturdayopen1, sundayopen1);
            bool satsunthesame2 = string.Equals(saturdayopen2, sundayopen2);

            if (satsunthesame == true)
            {
                starttime.Text = Settings.Default["sundaystarttime"].ToString();
                endtime.Text = Settings.Default["sundayendtime"].ToString();

            }
            else if (satsunthesame1 == true)
            {
                starttime1.Text = Settings.Default["sundaystarttime1"].ToString();
                endtime1.Text = Settings.Default["sundayendtime1"].ToString();
            }
            else if (satsunthesame2 == true)
            {
                starttime2.Text = Settings.Default["sundaystarttime2"].ToString();
                endtime2.Text = Settings.Default["sundayendtime2"].ToString();
            }
            else
            {
                starttime.Text = "null";
                endtime.Text = "null";
                starttime1.Text = "null";
                endtime1.Text = "null";
                starttime2.Text = "null";
                endtime2.Text = "null";
            }
        }

        private void endtime_Click(object sender, EventArgs e)
        {

        }
    }
}
