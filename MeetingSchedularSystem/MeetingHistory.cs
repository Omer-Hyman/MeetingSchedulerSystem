using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public enum UserType
{
    // this is how we do importance
    One,
    Two,
    Three,
    Four,
    Five
};
namespace WindowsFormsApp2
{
    public partial class MeetingHistory : Form
    {
        // this will display the meetings
        private DataGridView dataGridView2 = new DataGridView();
        private BindingSource meetingSource1 = new BindingSource();

        public MeetingHistory()
        {
            this.Load += new System.EventHandler(MeetingHistory_Load);
        }
        private void MeetingHistory_Load(object sender, System.EventArgs e)
        { 
            // format of the meetings, will create a big grid with all previous meetings + test data
            string[] possibles = { "Rosalia Cortez", "Heather McLean", "Sam Scott" };
            string[] potentialEquipment = { "Printer", "Big Screen", "Projector" };
            DateTime timeDate = new DateTime(2020, 3, 1, 7, 0, 0);
            meetingSource1.Add(new Meeting("Liam Williams", possibles, timeDate, potentialEquipment, "this is a test meeting", UserType.Five, "Room 101"));
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSize = true;
            dataGridView2.DataSource = meetingSource1;
            dataGridView2.Columns.Add(CreateComboBoxWithEnums());
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "User";
            dataGridView2.Columns.Add(column);
            // must add more to this once it is linked with UI
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Importance Level";
            column.Name = "importance level";
            dataGridView2.Columns.Add(column);
           

            this.Controls.Add(dataGridView2);
            this.AutoSize = true;
            this.Text = "User scheduler system";
        }

        // more part of creating the grid
        DataGridViewComboBoxColumn CreateComboBoxWithEnums()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(UserType));
            combo.DataPropertyName = "User Type";
            combo.Name = "User Type";
            return combo;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // this is the class that will ultimately define meeting. Could be put back in its own file but want to get this implementation working first

        private class Meeting
        {
            // attributes
            private string meetingInitiator;
            private DateTime timeDate;
            private string[] guests;
            private string[] equipment;
            private string meetingDescription;
            private UserType importanceLevel;
            private string location_input;
            public Meeting(string initiator, string[] possibleGuests, DateTime date, string[] Equipment, string description, UserType type, string location)
            {
                // constructor
                meetingInitiator = initiator;
                guests = possibleGuests;
                timeDate = date;
                equipment = Equipment;
                meetingDescription = description;
                importanceLevel = type;
                location_input = location;


            }
            public Meeting()
            {
                meetingInitiator = "<enter name>";
                //DateTime timeDate = new DateTime(2020, 3, 1, 7, 0, 0);
                meetingDescription = "";
                importanceLevel = UserType.Five;

            }

         
            // working getters and setters for every attribute
            public string Initiator
            {
                get
                {
                    return meetingInitiator;
                }
                set
                {
                    meetingInitiator = value;
                }
            }
            public String[] Guests
            {
                get
                {
                    return guests;
                }
                set
                {
                    guests = value;
                }
            }
            public DateTime Date
            {
                get
                {
                    return timeDate;
                }
                set
                {
                    timeDate = value;
                }
            }
            
            public String[] Equipment
            {
                get
                {
                    return equipment;
                }
                set
                {
                    equipment = value;
                }
            }

            public string Description
            {
                get
                {
                    return meetingDescription;
                }
                set
                {
                    meetingDescription = value;
                }
            }

            public UserType Importance
            {
                get
                {
                    return importanceLevel;
                }
                set
                {
                    importanceLevel = value;
                }
            }
            public string Location
            {
                get
                {
                    return location_input;
                }
                set
                {
                    location_input = value;
                }
            }

        }

        private void MeetingHistory_Load_1(object sender, EventArgs e)
        {

        }
    }
}
