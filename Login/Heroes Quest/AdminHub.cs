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
    public partial class AdminHub : Form
    {
        public AdminHub()
        {
            DatabaseAccessObject dbaccess = new DatabaseAccessObject();
            InitializeComponent();
        }
    }
}
