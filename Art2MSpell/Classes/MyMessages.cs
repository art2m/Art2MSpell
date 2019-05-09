//---------------------------------------------------------------------------------------------------------------
// Spell-It
//
// MyMessages.cs
//
// File:     Spell-It.sln
// Author:   art2m_000]
// Company:
// Date:     8/28/2018
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//----------------------------------------------------------------------------------------------------------------

namespace Art2MSpell.Classes
{
    using System.Text;
    using System.Windows.Forms;

    /// <summary>Create message boxes.</summary>
    public static class MyMessages
    {
        #region PROPERTIES PUBLIC

        /// <summary>
        /// The error message to be displayed.
        /// </summary>
        public static string ErrorMessage { get; set; }

        /// <summary>
        /// The information message to be displayed.
        /// </summary>
        public static string InformationMessage { get; set; }

        /// <summary>
        /// Contains the name of the class where the message box was called from.
        /// </summary>
        public static string NameOfClass { get; set; }

        /// <summary>
        /// Contains the name of the method where the message box is called from.
        /// </summary>
        public static string NameOfMethod { get; set; }

        /// <summary>
        /// Contains the question to ask the user.
        /// </summary>
        public static string QuestionMessage { get; set; }

        /// <summary>
        /// Contains the warning message to be displayed.
        /// </summary>
        public static string WarningMessage { get; set; }

        #endregion PROPERTIES PUBLIC

        #region Public Methods

        /// <summary>
        /// Builds the error string.
        /// </summary>
        /// <param name="className">Class name.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="errorMsg">The error message to be displayed.</param>
        /// <param name="exceptionMessage">Exception message.</param>
        public static void BuildErrorString(string className, string methodName, string errorMsg,
            string exceptionMessage)
        {
            var sb = new StringBuilder(className);
            sb.AppendLine(methodName);
            sb.AppendLine(errorMsg);
            sb.AppendLine(exceptionMessage);
            ShowErrorMessage(sb.ToString(), NameOfClass);
        }

        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="msg">The errpr message to be displayed.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void ShowErrorMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Display error message box with message, class name and method name.
        /// </summary>
        /// <param name="msg">The error message to be displayed.</param>
        /// <param name="className">The class name.</param>
        /// <param name="methodName">The method name.</param>
        public static void ShowErrorMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Display error message box with method name and message.
        /// </summary>
        public static void ShowErrorMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(ErrorMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows the information message.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        public static void ShowInformationMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows the information message box.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="className">The name of the class.</param>
        /// <param name="methodName">The name of the method.</param>
        public static void ShowInformationMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Display information message box with method name and message.
        /// </summary>
        public static void ShowInformationMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(InformationMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows the question message.
        /// </summary>
        /// <param name="msg">The question message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns>yes or no answer to the question.</returns>
        public static DialogResult ShowQuestionMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Display question message box with method name and message.
        /// </summary>
        /// <returns>Return yes or no answer to the question.</returns>
        public static DialogResult ShowQuestionMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(QuestionMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Shows the warning message.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="methodname">The name of the method.</param>
        public static void ShowWarningMessage(string msg, string methodname)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodname, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows the warning message box.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void ShowWarningMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Display warning message box with method name and message.
        /// </summary>
        public static void ShowWarningMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(WarningMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Warning);
        }

        #endregion Public Methods
    }
}