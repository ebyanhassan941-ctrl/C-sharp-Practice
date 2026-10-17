using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_Tricket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCaulculate_Click(object sender, EventArgs e)
        {
            // Declaring variables
            string PassengerName;
            int passengerAge;
            int NumberOfTicket;
            double baggageWeight;

            double TicketPrice = 0;
            double BasicTicketCost;
            double ticketDiscount = 0;
            double ageDiscount = 0;
            double insuranceCost = 0;
            double ExcessBaggage = 0;
            //double classAmount = 0;
            double finalTicketCost;
            string Travelclass = "";
            bool bookingApproved = true;
            String Rejection = "";

            try
            {
                PassengerName = txtName.Text;
                passengerAge = int.Parse(txtWeight.Text);
                NumberOfTicket = int.Parse(txtTicket.Text);
                baggageWeight = double.Parse(txtWeight.Text);
                if (int.TryParse(txtAge.Text, out passengerAge) && int.TryParse(txtTicket.Text, out NumberOfTicket) &&
                      double.TryParse(txtWeight.Text, out baggageWeight))
                {
                    if (PassengerName != "")
                    {
                        if (passengerAge >= 1 && passengerAge <= 100)
                        {
                            if (NumberOfTicket >= 1 && NumberOfTicket <= 5)
                            {
                                if (baggageWeight > 0 && baggageWeight <= 50)
                                {
                                    if (radioFirstClass.Checked)
                                    {
                                        Travelclass = "first class";
                                        TicketPrice = 100;
                                    }
                                    else if (radioNormalClass.Checked)
                                    {
                                        Travelclass = "normal";
                                        TicketPrice = 300;
                                    }
                                    else if (radioBussinessClass.Checked)
                                    {
                                        Travelclass = "business class";
                                        TicketPrice = 500;
                                    }
                                    else
                                    {
                                        MessageBox.Show("please select Travel Class.");
                                    }
                                    if (passengerAge < 12 && radioFirstClass.Checked)
                                    {
                                        bookingApproved = false;
                                        Rejection = "passenger below 12 can not book first class.";
                                    }
                                    if (bookingApproved == false)
                                    {
                                        MessageBox.Show(Rejection);
                                        lstDisplay.Text = "Booking Status: REJECTED";
                                    }
                                    else
                                    {
                                        lstDisplay.Text = "Booking Status: APPROVED";
                                    }

                                        BasicTicketCost = TicketPrice * NumberOfTicket;

                                    if (NumberOfTicket >= 3 && NumberOfTicket <= 5)
                                    {
                                        ticketDiscount = BasicTicketCost * 0.05;
                                    }
                                    else if (NumberOfTicket > 5)
                                    {
                                        ticketDiscount = BasicTicketCost * 0.1;
                                    }
                                    else
                                    {
                                        ticketDiscount = 0;
                                    }

                                    if (passengerAge < 12)
                                    {
                                        ageDiscount = BasicTicketCost * 0.2;
                                    }
                                    else if (passengerAge >= 60)
                                    {
                                        ageDiscount = BasicTicketCost * 0.1;
                                    }

                                    if (checkBaggage.Checked)
                                    {
                                        insuranceCost = 25 * NumberOfTicket;
                                    }
                                      double freeBaggage = 20 * NumberOfTicket; 
                                    if (baggageWeight > freeBaggage)
                                    {
                                        ExcessBaggage = baggageWeight - freeBaggage;
                                    }



                                    finalTicketCost = BasicTicketCost -ticketDiscount - ageDiscount + insuranceCost + TicketPrice;

                                    lstDisplay.Items.Add("AIRLINE BOOKING DETAILS");
                                    lstDisplay.Items.Add("------------------------------");
                                    lstDisplay.Items.Add("Guest Name: " + PassengerName);
                                    lstDisplay.Items.Add("Guest Age: " + passengerAge);
                                    lstDisplay.Items.Add("Number of Tickets: " + NumberOfTicket);
                                    lstDisplay.Items.Add("Class Type: " + Travelclass);
                                    lstDisplay.Items.Add("Class Price (per ticket): $" + TicketPrice.ToString("F2"));
                                    lstDisplay.Items.Add("Basic Ticket Cost: $" + BasicTicketCost.ToString("F2"));
                                    lstDisplay.Items.Add("Ticket Discount: -$" + ticketDiscount.ToString("F2"));
                                    lstDisplay.Items.Add("age Discount: -$" + ageDiscount.ToString("F2"));
                                    lstDisplay.Items.Add("Insurance Cost: +$" + insuranceCost.ToString("F2"));
                                    lstDisplay.Items.Add("------------------------------");
                                    lstDisplay.Items.Add("Final Total Cost: $" + finalTicketCost.ToString("F2"));
                                    lstDisplay.Items.Add("Booking Status: "+ bookingApproved);
                                }
                                else
                                {
                                    MessageBox.Show("number of beggage must be between 0 to 50");
                                }
                            }
                            else
                            {
                                MessageBox.Show("number of ticket must be between 1 to 5");
                            }
                        }
                        else
                        {
                            MessageBox.Show("passenger age must be between 1 to 100");
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter you name.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid number");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes
            txtName.Clear();
            txtAge.Clear();
            txtTicket.Clear();
            txtWeight.Clear();

            // Clear RadioButtons
            radioFirstClass.Checked = false;
            radioNormalClass.Checked = false;
            radioBussinessClass.Checked = false;

            // Clear Insurance
            checkBaggage.Checked = false;

            // Clear ListBox
            lstDisplay.Items.Clear();

            // Focus on Passenger Name
            txtName.Focus();
        
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
