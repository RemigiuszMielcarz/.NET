using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calendar_frontend
{
    public partial class UserControlDays : UserControl
    {
        string connString = "data source=.;initial catalog=EventsDatabase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot";

        // Statyczna zmienna dla dnia
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void displayEvent()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM eventTable where eventDATE = @eventDATE";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("eventDATE", Form1.static_month + "/" + UserControlDays.static_day + "/" + Form1.static_year);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text=reader["eventTXT"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
            timer1.Stop();
        }
    }
}
