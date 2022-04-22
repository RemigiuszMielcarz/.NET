using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_frontend
{
    public partial class Form1 : Form
    {
        int month, year;

        // Statyczne zmienne żeby dać je do innej formy dla miesiąca i roku
        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            // Pobierz pierwszy dzień miesiąca
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Pobierz liczbę dni w miesiącu
            int days = DateTime.DaysInMonth(year,month) + 1;

            // Konwertuj startofthemonth do INT
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Blank usercontrol
            for(int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            // Usercontrol dla dni
            for(int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            // Pobierz pierwszy dzień miesiąca
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Pobierz liczbę dni w miesiącu
            int days = DateTime.DaysInMonth(year, month) + 1;

            // Konwertuj startofthemonth do INT
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            // Usercontrol dla dni
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            // Pobierz pierwszy dzień miesiąca
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Pobierz liczbę dni w miesiącu
            int days = DateTime.DaysInMonth(year, month) + 1;

            // Konwertuj startofthemonth do INT
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            // Usercontrol dla dni
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
