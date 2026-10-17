using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {
            String GuestName;
            int guestAge;
            int numberOfNights;
            int NumberOfGuests;

            double ratePerDay = 0;
            double BasicCost = 0;
            double stayDiscount = 0;
            double seniorDiscount = 0;
            double breakfastCost = 0;
            double serviceSurcharge = 0;
            double finalCost;
            double discountRate = 0;
            String RoomType = "";
            String BookingStatus = "APPROVED";

            try
            {
                GuestName = txtName.Text;
                guestAge = int.Parse(txtAge.Text);
                numberOfNights = int.Parse(txtNights.Text);
                NumberOfGuests = int.Parse(txtGuests.Text);
                if (int.TryParse(txtAge.Text, out guestAge) && int.TryParse(txtNights.Text, out numberOfNights) &&
                    int.TryParse(txtGuests.Text, out NumberOfGuests))
                {
                    if(GuestName != "")
                    {
                        if(guestAge > 18 && guestAge <= 90)
                        {
                            if(numberOfNights > 1 && numberOfNights <= 30)
                            {
                                if(NumberOfGuests > 1 && NumberOfGuests <= 6)
                                {
                                    if (radioStandard.Checked)
                                    {
                                        RoomType = "standard";
                                    }
                                    else if (radioNormal.Checked)
                                    {
                                        RoomType = "normal";
                                    }
                                    else if (radioHight.Checked)
                                    {
                                        RoomType = "high";
                                    }
                                    else
                                    {
                                        MessageBox.Show("please select room type.");
                                    }
                                    if(radioStandard.Checked && NumberOfGuests > 2)
                                    {
                                        BookingStatus = "REJECTED";
                                    }
                                    else if(radioNormal.Checked && NumberOfGuests > 4)
                                    {
                                        BookingStatus = "REJECTED";
                                    }
                                    else if(radioHight.Checked && NumberOfGuests > 6)
                                    {
                                        BookingStatus = "REJECTED";
                                    }
                                    if(BookingStatus == "REJECTED")
                                    {
                                        lstBookingDetails.Items.Add("Booking Details." + "\n" + "==================================" + "\n" +
                                            "Guest name: " + GuestName + "\n" + "guest age: " + guestAge + "\n" +
                                            "Booking Details: " + BookingStatus);
                                    }

                                    switch (RoomType)
                                    {
                                        case "standar":
                                            ratePerDay = 50;
                                            break;
                                        case "normal":
                                            ratePerDay = 80;
                                            break;
                                        case "high":
                                            ratePerDay = 130;
                                            break;
                                    }

                                    BasicCost = ratePerDay * numberOfNights;

                                    if(numberOfNights > 5 &&  numberOfNights <= 9)
                                    {
                                        discountRate =  0.05;
                                    }
                                    else if(numberOfNights >= 10)
                                    {
                                        discountRate = 0.12;
                                    }
                                    stayDiscount = BasicCost * discountRate;

                                    if(NumberOfGuests > 4)
                                    {
                                        serviceSurcharge =BasicCost * 0.05;
                                    }
                                    if(guestAge >= 60)
                                    {
                                        seniorDiscount = BasicCost *0.05;
                                    }
                                    if (checkBreakfast.Checked)
                                    {
                                        breakfastCost = 10 * NumberOfGuests * numberOfNights;
                                    }
                                    finalCost = BasicCost - stayDiscount - seniorDiscount + breakfastCost + serviceSurcharge;

                                    lstBookingDetails.Items.Add("BOOKING DETAILS");
                                    lstBookingDetails.Items.Add("------------------------------");
                                    lstBookingDetails.Items.Add("Guest Name: " + GuestName);
                                    lstBookingDetails.Items.Add("Guest Age: " + guestAge);
                                    lstBookingDetails.Items.Add("Number of Guests: " + NumberOfGuests);
                                    lstBookingDetails.Items.Add("Number of Nights: " + numberOfNights);
                                    lstBookingDetails.Items.Add("Room Type: " + RoomType);
                                    lstBookingDetails.Items.Add("Rate Per Night: $" + ratePerDay.ToString("F2"));
                                    lstBookingDetails.Items.Add("Basic Room Cost: $" + BasicCost.ToString("F2"));
                                    lstBookingDetails.Items.Add("Stay Discount: $" + stayDiscount.ToString("F2"));
                                    lstBookingDetails.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
                                    lstBookingDetails.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("F2"));
                                    lstBookingDetails.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("F2"));
                                    lstBookingDetails.Items.Add("------------------------------");
                                    lstBookingDetails.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
                                    lstBookingDetails.Items.Add("Booking Status: " + BookingStatus);
                                }
                                else
                                {
                                    MessageBox.Show("number of guests must be between 1 to 6.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("number of nights must be between 1 to 30.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("age of guests must be between 18 throught 90.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("name can not be empty.");
                    }
                }
                else
                {
                    MessageBox.Show("enter valid number.");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes
            txtName.Clear();
            txtAge.Clear();
            txtGuests.Clear();
            txtNights.Clear();

            // Clear RadioButtons
            radioStandard.Checked = false;
            radioNormal.Checked = false;
            radioHight.Checked = false;

            // Clear Insurance
            checkBreakfast.Checked = false;

            // Clear ListBox
            lstBookingDetails.Items.Clear();

            // Focus on Passenger Name
            txtName.Focus();
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
