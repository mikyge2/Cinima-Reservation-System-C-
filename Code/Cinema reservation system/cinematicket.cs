﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_reservation_system
{
    public partial class cinematicket : Form
    {
        public cinematicket(string name,string datetime, string seat)
        {
            InitializeComponent();

            label2.BackColor = Color.Transparent; // Making Label Transparent
            label2.Parent = pictureBox1;
            moviename.Text=name;
            seatno.Text=seat;
            reservationdate.Text=datetime;
        }

        private void closebutton_Click(object sender, EventArgs e)
        { 
            
            this.Close();
        }
    }
}
