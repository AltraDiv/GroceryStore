using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT_Project_2
{

    public partial class Form1 : Form
    {
        #region Global Variable Declaretion
        bool start = false;
        int Range = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();

        }
        private void Startbtn_Click(object sender, EventArgs e)
        {
            Resetbtn.Hide();
            Startbtn.Hide();
            start = true;
        }

        private void btnGroceryStores_Click(object sender, EventArgs e)
        {
            #region GroceryStore Button Clicked
            string[] LblLoc = new string[6];
            LblLoc[0] = " Walmart\nAddress: 100 City Centre Drive, Mississauga, L5B 2G7\nPhone Number : (905) 270-9300\nHours: 7am - 11pm (Monday-Sunday)  ";
            LblLoc[1] = " Whole Food Markets \n Address: 155 Square One Drive Mississauga, ON L5B 0E2 \n PhoneNumber : (905) 275-9393\nHours 8am-10om(Monday - Friday)\n 8am- 9pm (Saturday- Sunday) ";
            LblLoc[2] = " Town & Country Market \n Address: 3855 Duke Of York Blvd, Mississauga ON L5B 3Z9\n Hours: 24 hours (Monday-Sunday) ";
            LblLoc[3] = "Oceans Fresh Foods Market\n Address: 4557 Hurontario St, Mississauga, ON L4Z3M1\n Phone Number: (905) 568- 8988\n Hours: 9.30am-10pm (Monday-Friday)\n 9am-10pm(Saturday-Sunday)";
            LblLoc[4] = " Marc's, No Frills\n Address: 925 Rathburn Road East, Mississauga, ON L4W 4CW\n 8am-9pm (Monday-Friday)\n 8am-7pm(Saturday-Sunday) ";
            LblLoc[5] = " Metro\n Address: 1585 Mississauga Valley Blvd, Mississauga,ONL5A3W9\n Phone Number: (905) 566-9100\n 24 hours(Monday- Sunday) ";
            if (start)
            {

                lblDisplayBox1.Text = " ";
                lblDisplayBox.Text = " ";
                btnGasStations.Hide(); // Hides not selected button 
                btnSportsCentres.Hide();
                btnPharmacy.Hide();
                lblDetails1.Text = LblLoc[0];
                lblDetails2.Text = LblLoc[1];
                lblDetails3.Text = LblLoc[2];
                lbldetails4.Text = LblLoc[3];
                lblDetails5.Text = LblLoc[4];
                lbldetails6.Text = LblLoc[5];
                lblDetails1.Hide();
                lblDetails2.Hide();
                lblDetails3.Hide();
                lbldetails4.Hide();
                lblDetails5.Hide();
                lbldetails6.Hide();

                if (Range == 0)
                {
                    MessageBox.Show("Your range was 0 so your number of locations are 0\nPlease Click Reset");
                }
                else if (Range == 1)
                {
                    lblDetails1.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    
                }
                else if (Range == 3)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                }
                else if (Range == 4)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                }
                else if (Range == 5)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                }
                else if (Range == 6)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                    lbldetails6.Show();
                }


                /*
                lblDetails1.Text = " Walmart\nAddress: 100 City Centre Drive, Mississauga, L5B 2G7\nPhone Number : (905) 270-9300\nHours: 7am - 11pm (Monday-Sunday)  "; //displays info about store
                lblDetails2.Text = " Whole Food Markets \n Address: 155 Square One Drive Mississauga, ON L5B 0E2 \n PhoneNumber : (905) 275-9393\nHours 8am-10om(Monday - Friday)\n 8am- 9pm (Saturday- Sunday) ";//displays info about store
                lblDetails3.Text = " Town & Country Market \n Address: 3855 Duke Of York Blvd, Mississauga ON L5B 3Z9\n Hours: 24 hours (Monday-Sunday) ";//displays info about store
                lbldetails4.Text = "Oceans Fresh Foods Market\n Address: 4557 Hurontario St, Mississauga, ON L4Z3M1\n Phone Number: (905) 568- 8988\n Hours: 9.30am-10pm (Monday-Friday)\n 9am-10pm(Saturday-Sunday)";//displays info about store
                lblDetails5.Text = " Marc's, No Frills\n Address: 925 Rathburn Road East, Mississauga, ON L4W 4CW\n 8am-9pm (Monday-Friday)\n 8am-7pm(Saturday-Sunday) ";//displays info about store
                lbldetails6.Text = " Metro\n Address: 1585 Mississauga Valley Blvd, Mississauga,ONL5A3W9\n Phone Number: (905) 566-9100\n 24 hours(Monday- Sunday) ";//displays info about store
                */
                Resetbtn.Show();


            }
            #endregion
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            #region Pharmacy Button Click
            string[] lblLocation = new string[6];
            lblLocation[0] = "I.D.A Parkside Pharmacy\nAddress: 4062 Confederation Pkwy, Mississauga, ON L5B 0G4\nPhone Number: (289) 914-0099\nHours: 9am-9pm(Monday-Fryday)\n9am-5pm(Saturday)\n10am-3pm(Sunday) ";
            lblLocation[1] = "Walmart Pharmacy\nAddress: 100 City Centre Drive, Mississauga, L5B 2C9\nPhone Number: (905) 270 - 8331\nHours: 7am - 11pm(Monday - Sunday)\n7: 30am - 11pm(Saturday)";
            lblLocation[2] = " LIving Arts Pharmacy\nAddress: 4100 Living Art Dr, Mississauga, on L5B 0C3\nPhone Number: (905)279-0002\nHours: 9am-7pm (Monday-Friday)\n10am-3pm (Saturday)\nClosed (Sunday)";
            lblLocation[3] = " Shoppers Drug Mart\nAddress: 3980 Grand Park Dr, Mississauga, ON L5B 4M6\nPhone Number: (905) 566-9600\nHours: 8am-10pm (Monday-Saturday)\n9am-10pm (Sunday)";
            lblLocation[4] = " MediCare Clinic\nAddress: 3885 Duke of York Blvd #104&amp;105, Mississauga, ON L5B 0E4\nPhone Number: (905)848-4844\nHours: 9am-8pm (Monday-Friday\n10am-3pm (Saturday)\nClosed (Sunday)";
            lblLocation[5] = " Citi Pharmacy\nAddress: 3420 Hurontario St, Mississauga, ON L5B 4A9\nPhone Number: (905)270-1030\nHours: 9am-8pm (Moday-Saturday)\nClosed (Sunday)";

            if (start)
            {
                lblDisplayBox1.Text = " ";
                lblDisplayBox.Text = " ";
                btnGasStations.Hide();
                btnGroceryStores.Hide();
                btnSportsCentres.Hide();

                lblDetails1.Text = lblLocation[0];
                lblDetails2.Text = lblLocation[1];
                lblDetails3.Text = lblLocation[2];
                lbldetails4.Text = lblLocation[3];
                lblDetails5.Text = lblLocation[4];
                lbldetails6.Text = lblLocation[5];
                lblDetails1.Hide();
                lblDetails2.Hide();
                lblDetails3.Hide();
                lbldetails4.Hide();
                lblDetails5.Hide();
                lbldetails6.Hide();

                if (Range == 0)
                {
                    MessageBox.Show("Your range was 0 so your number of locations are 0\nPlease Click Reset");
                }
                else if (Range == 1)
                {
                    lblDetails1.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                }
              
                else if (Range == 3)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                }
                else if (Range == 4)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                }
                else if (Range == 5)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                }
                else if (Range == 6)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                    lbldetails6.Show();
                }


                // lblDetails1.Text = " I.D.A Parkside Pharmacy\nAddress: 4062 Confederation Pkwy, Mississauga, ON L5B 0G4\nPhone Number: (289) 914-0099\nHours: 9am-9pm(Monday-Fryday)\n9am-5pm(Saturday)\n10am-3pm(Sunday) ";
                //lblDetails2.Text = " Walmart Pharmacy\nAddress: 100 City Centre Drive, Mississauga, L5B 2C9\nPhone Number: (905) 270-8331\nHours: 7am-11pm (Monday-Sunday)\n7:30am-11pm (Saturday)";
                //lblDetails3.Text = " Shoppers Drug Mart\nAddress: 3980 Grand Park Dr, Mississauga, ON L5B 4M6\nPhone Number: (905) 566-9600\nHours: 8am-10pm (Monday-Saturday)\n9am-10pm (Sunday)";
                //lbldetails4.Text = " LIving Arts Pharmacy\nAddress: 4100 Living Art Dr, Mississauga, on L5B 0C3\nPhone Number: (905)279-0002\nHours: 9am-7pm (Monday-Friday)\n10am-3pm (Saturday)\nClosed (Sunday)";
                //lblDetails5.Text = " MediCare Clinic\nAddress: 3885 Duke of York Blvd #104&amp;105, Mississauga, ON L5B 0E4\nPhone Number: (905)848-4844\nHours: 9am-8pm (Monday-Friday\n10am-3pm (Saturday)\nClosed (Sunday)";
                //lbldetails6.Text = " Citi Pharmacy\nAddress: 3420 Hurontario St, Mississauga, ON L5B 4A9\nPhone Number: (905)270-1030\nHours: 9am-8pm (Moday-Saturday)\nClosed (Sunday)";
            }
            Resetbtn.Show();
            #endregion
        }

        private void btnGasStations_Click(object sender, EventArgs e)
        {
            #region Gas Station Clicked
            string[] lblNew = new string[6];
            lblNew[0] = " Petro Canada\n Address: 3680 Hurontario Street, Mississauga, ONL5B1P3\n Phone Number: (905) 279- 4213\n Open 24 hours\n $1.05(Standard) ";
            lblNew[1] = " Esso\n Address: 3445 Hurontario St, Mississauga, ON L5A 2H4\n Phone Number: (905)272-2224\n Open 24 hours\n $1.05/(Standard) ";
            lblNew[2] = " HUSKY\n Adress: 5020 McLaughlin Rd, Mississauga, ON L5R 3R8\n Phone Number: (905)502-7511\n Hours 6am-11pm (Monday-Sunday)\n $0.99(Standard) ";
            lblNew[3] = " Shell\n Address: 3685 Erindale Station Rd, Mississauga, ON L5C 2S9\n Phone Number: (905)270-9816\n Hours: Open 24 hours\n $1.05(Standard) ";
            lblNew[4] = " Pioneer Energy\n Address: 3411 Mavis Rd, Mississauga, ON L5C 1T7\n Phne Number: (905)897-8648\n Hours: Open 24 hours\n $0.99(Standard) ";
            lblNew[5] = " Canadian Tire Gas\n Address: 3020 Mavis Rd, Mississauga, ON L5C 1T8\n Phone Number: (905)281-9526\n Hours: Open 24 hours\n $1.00(Standard) ";

            if (start)
            {
                lblDisplayBox1.Text = " ";
                lblDisplayBox.Text = " ";
                btnSportsCentres.Hide();
                btnGroceryStores.Hide();
                btnPharmacy.Hide();
                lblDetails1.Text = lblNew[0];
                lblDetails2.Text = lblNew[1];
                lblDetails3.Text = lblNew[2];
                lbldetails4.Text = lblNew[3];
                lblDetails5.Text = lblNew[4];
                lbldetails6.Text = lblNew[5];
                lblDetails1.Hide();
                lblDetails2.Hide();
                lblDetails3.Hide();
                lbldetails4.Hide();
                lblDetails5.Hide();
                lbldetails6.Hide();

                if (Range == 0)
                {
                    MessageBox.Show("Your range was 0 so your number of locations are 0\nPlease Click Reset");
                }
                else if (Range == 1)
                {
                    lblDetails1.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();

                }
                else if (Range == 3)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                }
                else if (Range == 4)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                }
                else if (Range == 5)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                }
                else if (Range == 6)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                    lbldetails6.Show();
                }

                // lblDetails1.Text = " Petro Canada\n Address: 3680 Hurontario Street, Mississauga, ONL5B1P3\n Phone Number: (905) 279- 4213\n Open 24 hours\n $1.05(Standard) ";
                // lblDetails2.Text = " Esso\n Address: 3445 Hurontario St, Mississauga, ON L5A 2H4\n Phone Number: (905)272-2224\n Open 24 hours\n $1.05/(Standard) ";
                // lblDetails3.Text = " HUSKY\n Adress: 5020 McLaughlin Rd, Mississauga, ON L5R 3R8\n Phone Number: (905)502-7511\n Hours 6am-11pm (Monday-Sunday)\n $0.99(Standard) ";
                // lbldetails4.Text = " Shell\n Address: 3685 Erindale Station Rd, Mississauga, ON L5C 2S9\n Phone Number: (905)270-9816\n Hours: Open 24 hours\n $1.05(Standard) ";
                // lblDetails5.Text = " Pioneer Energy\n Address: 3411 Mavis Rd, Mississauga, ON L5C 1T7\n Phne Number: (905)897-8648\n Hours: Open 24 hours\n $0.99(Standard) ";
                // lbldetails6.Text = " Canadian Tire Gas\n Address: 3020 Mavis Rd, Mississauga, ON L5C 1T8\n Phone Number: (905)281-9526\n Hours: Open 24 hours\n $1.00(Standard) ";




            }
            Resetbtn.Show();
            #endregion
        }

        private void btnSportsCentres_Click(object sender, EventArgs e)
        {
            #region SportsCenter Button Clicked
            string[] lblMoc = new string[6];
            lblMoc[0] = " Canlan Sportsplex\n Address: 3360 Wolfedale Rd, Mississauga, ON L5C 1W4\n Phone Number: (905)897-9622\n Hours: 10am-12am (Monday-Friday)\n 8am-12am (Sautrday-Sunday) ";
            lblMoc[1] = " YMCA Centre\n Address: 325 Burnhamthorpe Rd W, Mississauga, ON L5B 3R2\n Phone Number: (905)897-9622\n Hours: 5am-12am (Monday-Friday)\n 7am-8pm (Saturday-Sunday) ";
            lblMoc[2] = " Mississauga SportZone\n Address: 5600 Rose Cherry Pl, Mississauga, ON L4Z 4B6\n Phone Number: (905)615-3200 ext.2895\n Hours: 6am-1am (Monday-Sunday) ";
            lblMoc[3] = " Invader Sportsplex\n Address: 6765 Invader Crescent, Mississauga, ON L5T 2B7\n Phone Number: (905)565-0500\n Hours: 9am-12am (Monday-Friday)\n 6am-12am (Saturday-Sunday) ";
            lblMoc[4] = " UFC GYM Mississauga\n Address: 3900 Grand Park Dr, Mississauga, ON L5B 4M6\n Phone Number: (905)615-1500\n Hours: 6am-10pm (Monday-Friday)\n 8am-6pm (Saturday-Sunday) ";
            lblMoc[5] = " Mississauga Valley Community Centre\n Address: 1275 Mississauga Valley Blvd, Mississauga, ON L5A 3R8\n Phone Number: (905)615-4670\n Daily 6am-12pm ";

            if (start)
            {
                lblDisplayBox1.Text = " ";
                lblDisplayBox.Text = " ";
                btnGasStations.Hide();
                btnGroceryStores.Hide();
                btnPharmacy.Hide();
                lblDetails1.Text = lblMoc[0];
                lblDetails2.Text = lblMoc[1];
                lblDetails3.Text = lblMoc[2];
                lbldetails4.Text = lblMoc[3];
                lblDetails5.Text = lblMoc[4];
                lbldetails6.Text = lblMoc[5];
                lblDetails1.Hide();
                lblDetails2.Hide();
                lblDetails3.Hide();
                lbldetails4.Hide();
                lblDetails5.Hide();
                lbldetails6.Hide();

                if (Range == 0)
                {
                    MessageBox.Show("Your range was 0 so your number of locations are 0\nPlease Click Reset");
                }
                else if (Range == 1)
                {
                    lblDetails1.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                }
                else if (Range == 2)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();

                }
                else if (Range == 3)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                }
                else if (Range == 4)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                }
                else if (Range == 5)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                }
                else if (Range == 6)
                {
                    lblDetails1.Show();
                    lblDetails2.Show();
                    lblDetails3.Show();
                    lbldetails4.Show();
                    lblDetails5.Show();
                    lbldetails6.Show();
                }

                // lblDetails1.Text = " Canlan Sportsplex\n Address: 3360 Wolfedale Rd, Mississauga, ON L5C 1W4\n Phone Number: (905)897-9622\n Hours: 10am-12am (Monday-Friday)\n 8am-12am (Sautrday-Sunday) ";
                // lblDetails2.Text = " YMCA Centre\n Address: 325 Burnhamthorpe Rd W, Mississauga, ON L5B 3R2\n Phone Number: (905)897-9622\n Hours: 5am-12am (Monday-Friday)\n 7am-8pm (Saturday-Sunday) ";
                // lblDetails3.Text = " Mississauga SportZone\n Address: 5600 Rose Cherry Pl, Mississauga, ON L4Z 4B6\n Phone Number: (905)615-3200 ext.2895\n Hours: 6am-1am (Monday-Sunday) ";
                // lbldetails4.Text = " Invader Sportsplex\n Address: 6765 Invader Crescent, Mississauga, ON L5T 2B7\n Phone Number: (905)565-0500\n Hours: 9am-12am (Monday-Friday)\n 6am-12am (Saturday-Sunday) ";
                // lblDetails5.Text = " UFC GYM Mississauga\n Address: 3900 Grand Park Dr, Mississauga, ON L5B 4M6\n Phone Number: (905)615-1500\n Hours: 6am-10pm (Monday-Friday)\n 8am-6pm (Saturday-Sunday) ";
                // lbldetails6.Text = " Mississauga Valley Community Centre\n Address: 1275 Mississauga Valley Blvd, Mississauga, ON L5A 3R8\n Phone Number: (905)615-4670\n Daily 6am-12pm ";
            }
            Resetbtn.Show();
            #endregion
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            #region RangeBox Set
            try
            { 
            Range = int.Parse(Rangebox.Text);
            
            
                if (Range == 0 || Range == 1 || Range == 2 || Range == 3 || Range == 4 || Range == 5 || Range == 6 || Range == null)
                {
                    Range = int.Parse(Rangebox.Text);
                    MessageBox.Show("Your Range Value has been set to " + Range);

                }
                else
                {
                    MessageBox.Show("Please enter a valid value from 1-6, your range value has been set as 0");
                    Range = 0;
                    Rangebox.Text = "";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Try Again");
            }
            #endregion
        }
    }
}
