﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroes_Quest
{
    public partial class PlayerHub : Form
    {

        public PlayerHub()
        {
            InitializeComponent();
            DatabaseAccessObject dbaccess = new DatabaseAccessObject();
            PlayerNameDisplay.Text = "";
        }

        private void PlayerHub_Load(object sender, EventArgs e)
        {

        }
    }
}
