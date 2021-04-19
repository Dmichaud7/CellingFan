using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fan
{
    //Denis Michaud
    //This represent my own work.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speed = 0;
        string fanRotation = "going clockwise.";
        bool flag = false;

        /// <summary>
        /// Loads the default information for the fan
        /// fan currently at speed 0 (off)
        /// and fan rotation set to clockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FanInfo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Change the rotation of the celling fan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotation_Click(object sender, EventArgs e)
        {
            try
            {
                flag = !flag;

                if (flag)
                {
                    fanRotation = "going counter clockwise.";
                
                    FanInfo();
                }
                else
                {
                    fanRotation = "going clockwise.";
                    FanInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Change the speed of the celling fan
        /// if the fan speed is 0 the fan is currently off
        /// if the fan speed goes pass 3 it goes back to 0 (off)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFanSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                speed++;

                switch (speed)
                {
                    case 1:
                        FanInfo();
                        break;
                    case 2:
                        FanInfo();
                        break;
                    case 3:
                        FanInfo();
                        break;
                    default:
                        speed = 0;
                        FanInfo();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Method to display the current state of the celling fan
        /// and to change the image display depending on the current state of the celling fan (off, clockwise, counter clockwise)
        /// </summary>
        private void FanInfo()
        {
            if(speed > 0)
            {
                lblFan.Text = "Celling fan is currently at speed " + speed + " " + fanRotation;

                if (flag)
                {
                    picFan.Image = Fan.Properties.Resources.counterclockwise;
                }
                else
                {
                    picFan.Image = Fan.Properties.Resources.clockwise;
                }
               
            }
            else
            {
                lblFan.Text = "Celling fan is currently off.";
                picFan.Image = Fan.Properties.Resources.fan;
            }
       
        }

 
    }
}
