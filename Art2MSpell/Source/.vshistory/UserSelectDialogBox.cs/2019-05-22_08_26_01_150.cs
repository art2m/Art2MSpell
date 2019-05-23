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
    using Collections;

    /// <summary>
    ///  select user name so then can connect current user to spelling lists.
    /// </summary>
    public partial class UserSelectDialogBox : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        public UserSelectDialogBox()
        {
            this.InitializeComponent();
            this.SetInitialBackgroundColors();
            this.lstUsers.Focus();
            this.ReadUserFileFillListBox();
        }

        /// <summary>
        /// Read users names list from file.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void ReadUserFileFillListBox()
        {
            if (!SpellingReadWriteClass.ReadUserNameFile())
            {
                return;
            }

            this.FillListBoxWithUserNames();
        }

        /// <summary>
        /// Place all the user names from the collection into the list box.
        /// User can then select there name and get all of there spelling list.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void FillListBoxWithUserNames()
        {
            var userNames = new UsersNameCollection();
            for (var index = 0; index < userNames.ItemsCount(); index++)
            {
                this.lstUsers.Items.Add(userNames.GetItemAt(index));
            }
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

        /// <summary>
        /// cancel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;
        }

        /// <summary>
        ///  Fille user name property with selected user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = this.txtName.Text;
        }

        /// <summary>
        ///  Get The name of the user from the list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void OnListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtName.Text = this.lstUsers.Text;
        }
    }
}