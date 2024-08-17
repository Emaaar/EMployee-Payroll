using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try { 
            double Hworks = Double.Parse(HrsWrk.Text);
            String CStat = CivStatus.SelectedItem.ToString();
            String EmpStat = EmpStatus.SelectedItem.ToString();

            double grossincome = 0;
            double deductions = 0;
            double pibig = 0;
            double phealth = 0;
            double netincome = 0;
            double rpd = 0;
            double rph = 0;

                switch (EmpStat)
                {
                    case "R":
                        rpd = 800;
                        break;
                    case "P":
                        rpd = 600;
                        break;
                    case "C":
                        rpd = 500;
                        break;
                    case "T":
                        rpd = 450;
                        break;
                    case "Others":
                        rpd = 400;
                        break;

                }


            /*if(EmpStat == "R")
            {
                rpd = 800;

            }else if (EmpStat == "C")
            {
                rpd = 600;
            }else if(EmpStat == "P")
            {
                rpd = 500;
            }
            else if (EmpStat == "T")
            {
                rpd = 450;
            }
            else
            {
                rpd = 400;
            }*/

            rph = rpd / 8;
            grossincome = Hworks * rph;

            if (grossincome > 10000)
            {
                pibig = grossincome * 0.05;
            }
            else if (grossincome > 5000)
            {
                pibig = grossincome * 0.03;
            }
            else
            {
                pibig = grossincome * 0.02;
            }

                switch (CStat)
                {
                    case "M":
                        phealth = 500;
                        break;
                    case "S":
                        phealth = 300;
                        break;
                    case "Others":
                        phealth = 400;
                        break;


                }
            /*if (CStat == "S")
            {
                phealth = 500;
            }else if (CStat == "M")
            {
                phealth = 300;
            }
            else
            {
                phealth = 400;
            }
            */
            deductions = phealth + pibig;
            netincome = grossincome - deductions;

            NetInc.Text = "" + netincome;

            }
            catch(Exception err)
            {
                DisplayAlert("Error", $"INPUT INVALID", "OK");
            }

        }
    }
}
