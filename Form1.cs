// *******************************************************************
// **   Author:          Matthew Pryor                              **
// **   Course Name:     CIS 1133 - Programming Logic & Language    **
// **   Instructor:      Jim Isom                                   **
// **   Assignment:      Special Programming Assignment             **
// **   Date:            April 29, 2022                             **
// *******************************************************************


//     ***********************************************
//     **            PROGRAM DESCRIPTION            **
//     ***********************************************
//     ** This program allows the user to calculate **
//     ** the cost of a motel room. The user has    **
//     ** three types of rooms they can select, and **
//     ** five different addons they can choose for **
//     ** the room that they reserve.               **
//     ***********************************************



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bob_s_Motel
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        // THIS IS THE CODE FOR THE "EXIT" BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // THIS IS THE CODE FOR THE "CALCULATE" BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            // VARIABLE DECLARATION:

            // TOTAL COST OF RESERVATION
            double reservationFee = 0.0;

            // ROOM COSTS
            const double roomcostStandard = 30.00;
            const double roomcostQueen = 40.00;
            const double roomcostKing = 50.00;

            // TAX RATE
            const double taxRate = 0.10;

            // TAX TOTAL
            double taxTotal = 0.0;

            // NUMBER OF DAYS RESERVED
            int daysReserved = 0;

            // EXTRA OPTIONS FOR RESERVATION
            const double optionSmokingRoom = 10.00;
            const double optionWiFi = 5.00;
            const double optionBigScreenTV = 5.00;
            const double optionTwoBeds = 5.00;
            const double optionNewspaper = 5.00;

            // NUMBER OF DAYS RESERVED
            DateTime dateOut = datePicker1.Value;
            DateTime dateIn = datePicker2.Value;

            // CALCULATE NUMBER OF DAYS RESERVED
            var days = (dateIn - dateOut).TotalDays;
            daysReserved = Convert.ToInt32(days);

            // CALCULATE RESERVATION COST
            if (rbStandard.Checked)
            {
                reservationFee = reservationFee + (roomcostStandard * daysReserved);
            }

            if (rbQueen.Checked)
            {
                reservationFee = reservationFee + (roomcostQueen * daysReserved);
            }

            if (rbKing.Checked)
            {
                reservationFee = reservationFee + (roomcostKing * daysReserved);
            }

            // CALCULATE COST OF ROOM OPTIONS
            if (cbSmokingRoom.Checked)
            {
                reservationFee = reservationFee + (optionSmokingRoom * daysReserved);
            }

            if (cbWiFi.Checked)
            {
                reservationFee = reservationFee + (optionWiFi * daysReserved);
            }

            if (cbBigScreenTV.Checked)
            {
                reservationFee = reservationFee + (optionBigScreenTV * daysReserved);
            }

            if (cbTwoBeds.Checked)
            {
                reservationFee = reservationFee + (optionTwoBeds * daysReserved);
            }

            if (cbNewspaper.Checked)
            {
                reservationFee = reservationFee + (optionNewspaper * daysReserved);
            }

            // CALCULATE TAX
            taxTotal = reservationFee * taxRate;
            reservationFee = reservationFee + taxTotal;

            // DISPLAY RESERVATION FEE

            DisplayFee.Text = ("Total Reservation Fee: " + reservationFee.ToString("C2"));
        }
    }
}
