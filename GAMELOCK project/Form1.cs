using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using GAMELOCK_project.Properties;
using System.Collections;

namespace GAMELOCK_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // UNCOMMENT AND RUN TO RESET
            //Settings.Default["hasopenedonce"] = "no";
            //Settings.Default["mondaystarttime"] = "null";
            //Settings.Default["mondayendtime"] = "null";
            //Settings.Default["mondaystarttime1"] = "null";
            //Settings.Default["mondayendtime1"] = "null";
            //Settings.Default["mondaystarttime2"] = "null";
            //Settings.Default["mondayendtime2"] = "null";
            //Settings.Default["username"] = "null";
            //Settings.Default["tuesdaystarttime"] = "null";
            //Settings.Default["tuesdayendtime"] = "null";
            //Settings.Default["tuesdaystarttime1"] = "null";
            //Settings.Default["tuesdayendtime1"] = "null";
            //Settings.Default["tuesdaystarttime2"] = "null";
            //Settings.Default["tuesdayendtime2"] = "null";
            //Settings.Default["thursdaystarttime"] = "null";
            //Settings.Default["thursdayendtime"] = "null";
            //Settings.Default["thursdaystarttime1"] = "null";
            //Settings.Default["thursdayendtime1"] = "null";
            //Settings.Default["fridaystarttime"] = "null";
            //Settings.Default["fridaystarttime1"] = "null";
            //Settings.Default["fridaystarttime2"] = "null";
            //Settings.Default["fridayendtime"] = "null";
            //Settings.Default["fridayendtime1"] = "null";
            //Settings.Default["fridayendtime2"] = "null";

            // to make sure the selected process doesn't give an error
            Settings.Default["everydaydelete"] = "closed";
            Settings.Default["everydaydelete1"] = "closed";
            Settings.Default["everydaydelete2"] = "closed";
            Settings.Default["mondaydelete"] = "closed";
            Settings.Default["mondaydelete1"] = "closed";
            Settings.Default["mondaydelete2"] = "closed";
            Settings.Default["tuesdaydelete"] = "closed";
            Settings.Default["tuesdaydelete2"] = "closed";
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


            //uncommented (failsafe) to make sure its a no
            Settings.Default["mondayselected"] = "no";
            Settings.Default["tuesdayselected"] = "no";
            Settings.Default["wednesdayselected"] = "no";
            Settings.Default["thursdayselected"] = "no";
            Settings.Default["fridayselected"] = "no";
            Settings.Default["saturdayselected"] = "no";
            Settings.Default["sundayselected"] = "no";

            Settings.Default["edittimeswindow"] = "closed";
            Settings.Default.Save();

            string hasopened = Settings.Default["hasopenedonce"].ToString();
            string haveopened = "no";
            bool hasntopenedbefore = string.Equals(hasopened, haveopened);
            
            if (hasntopenedbefore == true)
            {
                Settings.Default["hasopenedonce"] = "yes";

                // UNCOMMENT AND RUN TO RESET
                //Settings.Default["username"] = "null";
                //Settings.Default["hasopenedonce"] = "no";


                var namewindow = new selectname();
                Settings.Default.Save();
                namewindow.Show();
            }

           


            string defaultname = "null";
            string username = Settings.Default["username"].ToString();
            bool isdefaultname = string.Equals(defaultname, username);

 
            if (isdefaultname == true)
            {
                
            }

            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string AMPM = DateTime.Now.ToString("tt");
            string time = DateTime.Now.ToString("HH");
            int realtime = Convert.ToInt32(time);
            string usersname1 = Settings.Default["username"].ToString();
            string fulltimeanddate = DateTime.Now.ToString("ddd d MMM, HH:mm tt");
            label2.Text = fulltimeanddate;


            if (realtime > 12 && realtime < 17)
            {
                label1.Text = "Good afternoon, " + usersname1;
            }
            else if (realtime < 12)
            {
                label1.Text = "Good morning, "+ usersname1;
            }
            else if (realtime == 12)
            {
                label1.Text = "Good afternoon, " + usersname1;
            }
            else if (realtime > 17)
            {
                label1.Text = "Good evening, " + usersname1;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //Settings.Default["username"]
            Settings.Default.Save();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void schedule_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void downtime_Click(object sender, EventArgs e)
        {
            var downtimewindow = new downtime();
            downtimewindow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
