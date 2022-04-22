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
    public partial class EventForm : Form
    {

        EventsDatabaseEntities _db = new EventsDatabaseEntities();

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = Form1.static_month+"/"+UserControlDays.static_day + "/" + Form1.static_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            eventTable newEvent = new eventTable()
            {
                eventDATE = txdate.Text,
                eventTXT = txevent.Text
            };

            _db.eventTables.Add(newEvent);

            if (_db.SaveChanges() > 0)
            {
                var count = _db.eventTables.Count();
                lblMsg.Text = count.ToString();
            }
            else
            {
                lblMsg.Text = "Not saved !";
            }
   
            Console.Beep();
            MessageBox.Show("Saved");
        }
    }
}
