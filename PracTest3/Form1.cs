using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PracTest3
{
    public partial class Form1 : Form
    {
        //Name: Cameron Nepe
        //ID: 1262199

        //The number of days in the calendar, 1 is Monday and 5 is Friday
        const int NUM_DAYS = 5;
        //The number of hours to display for each day
        const int NUM_HOURS = 10;
        //The starting hour for the calendar (9am)
        const int START_HOUR = 9;
        //The amount of gap between the text and outline of an appointment
        const int OFFSET = 2;
        //The width of an appointment
        const int APP_WIDTH = 100;
        //The height of an appointment
        const int APP_HEIGHT = 60;

        //Colour variables for the different appointments
        Color WORK_COLOUR = Color.Gold;
        Color PERSONAL_COLOUR = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws the given text at the specified x and y coordinates
        /// </summary>
        /// <param name="paper">Where to draw the text</param>
        /// <param name="hour">The hour of the appointment</param>
        /// <param name="text">The text of the appointment</param>
        /// <param name="x">The x position of the appointment</param>
        /// <param name="y">The y position of the appointment</param>
        private void DrawText(Graphics paper, int hour, string text, int x, int y)
        {
            paper.DrawString(hour.ToString() + ".00: " + text, new Font("Arial", 8),
                Brushes.Black, x + OFFSET, y + OFFSET);

        }

        /// <summary>
        /// Draws an appointment in the given color.
        /// </summary>
        /// <param name="paper">Where to draw the appointment</param>
        /// <param name="x">The x position of the appointment</param>
        /// <param name="y">The y position of the appointment</param>
        /// <param name="backColor">The background color of the appointment</param>
        private void DrawAppointment(Graphics paper, int x, int y, Color backColor)
        {
            SolidBrush br = new SolidBrush(backColor);
            Pen pen1 = new Pen(Color.Black, 1);

            paper.FillRectangle(br, x, y, APP_WIDTH, APP_HEIGHT);
            paper.DrawRectangle(pen1, x, y, APP_WIDTH, APP_HEIGHT);
        }

        /// <summary>
        /// Draws an empty calendar.
        /// </summary>
        /// <param name="paper">Where to draw the calendar</param>
        private void DrawCalendar(Graphics paper)
        {
            //The x position of the current appointment
            int x = 0;
            //The y position of the current appointment
            int y = 0;

            //Clear the drawing area
            pictureBoxCalendar.Refresh();

            //Loop for each day in the calendar
            for (int hour = 1; hour <= NUM_HOURS; hour++)
            {
                //Loop for each hour in the calendar
                for (int day = 1; day <= NUM_DAYS; day++)
                {
                    //Draw the appointment and then move to the next position
                    DrawAppointment(paper, x, y, Color.White);
                    x += APP_WIDTH;
                }

                //Move down to the next row and move back to beginning of the row
                y += APP_HEIGHT;
                x = 0;
            }
        }

        /// <summary>
        /// Calculate the x position of an appointment.
        /// </summary>
        /// <param name="day">The day of the appointment</param>
        /// <returns>The x position of the appointment based on the given day</returns>
        private int CalculateX(string day)
        {
            //Stores all the days to display on the calendar
            string[] dayArray = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri" };
            //The x position of the appointment
            int x = 0;
            //The number for a day, Mon = 0, Fri = 4
            int dayNum = 0;

            //Look through the array for the given day
            for (int i = 0; i < dayArray.Length; i++)
            {
                //Check if the current day matches the given day
                if (dayArray[i] == day)
                {
                    //Store the day number for the given day
                    dayNum = i;
                }
            }

            //Calculate the x position of the appointment depending on the day
            x = dayNum * APP_WIDTH;

            return x;
        }
    }
}
