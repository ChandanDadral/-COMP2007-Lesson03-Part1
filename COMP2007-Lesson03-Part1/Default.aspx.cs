﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_Lesson03_Part1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            UserNameTextBox.Enabled = false;
            PasswordTextBox.Text = "";
            PasswordTextBox.Enabled = false;
            InstructionLabel.Text = "Thank You for logging in.";
        }


    }
}