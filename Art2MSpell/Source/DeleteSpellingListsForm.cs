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
    public partial class DeleteSpellingListsForm : Form
    {
        public DeleteSpellingListsForm()
        {
            InitializeComponent();

            this.SetInitialBackgroundColor();
            // this.SetInitalControlState();

            // TODO: Add list show spelling words.
            // TODO: Add list show pelling list paths / names.

            // TODO : Add button for deleting selected list.
            // TODO: Add select all items spelling list button.

            // TODO: ADD BUTTON FOR CLOSE.
        }

        private void SetInitalControlState()
        {
            throw new NotImplementedException();
        }

        private void SetInitialBackgroundColor()
        {
            this.BackColor = Color.Chocolate;
            this.btnClose.BackColor = Color.RosyBrown;
            this.btnDeleteAll.BackColor = Color.LightSteelBlue;
            this.btnDeleteSel.BackColor = Color.LightSteelBlue;

        }


    }
}
