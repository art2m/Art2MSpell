
namespace Art2MSpell.Source
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Classes;

    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();

            this.txtUserName.Focus();
        }

        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.SaddleBrown;
            this.btnCancel.BackColor = Color.Red;
            this.btnOk.BackColor = Color.LawnGreen;
            this.lblUserName.BackColor = Color.Goldenrod;


        }

        /// <summary>
        /// if user cancels then set the user name property to string empty.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;
        }

        /// <summary>
        /// if user enters text save it to usr name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            var name = this.txtUserName.Text.Trim();

            if (string.IsNullOrEmpty(name) || name.Length < 1)
            {
                SpellingPropertiesClass.UserName = string.Empty;
                return;
            }

            SpellingPropertiesClass.UserName = name;
        }
    }
}
