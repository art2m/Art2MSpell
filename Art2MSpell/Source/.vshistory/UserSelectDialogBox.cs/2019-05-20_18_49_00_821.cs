﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art2MSpell.Source
{
    using Classes;

    public partial class UserSelectDialogBox : Form
    {
        public UserSelectDialogBox()
        {
            this.InitializeComponent();
            this.SetInitialBackgroundColors();
            this.lstUsers.Focus();
        }

        
       
        /// <summary>
        /// Set the control colors
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.SaddleBrown;
            this.btnCancel.BackColor = Color.Red;
            this.btnOk.BackColor = Color.LawnGreen;
            this.lblUserName.BackColor = Color.Goldenrod;

        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;
        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = this.txtName.Text;
        }

        private void OnListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtName.Text = this.lstUsers.Text;
        }
    }
}
