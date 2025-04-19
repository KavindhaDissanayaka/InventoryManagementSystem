using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class DecimalInputHandler
    {
        public static void HandleDecimalInput(object sender, KeyPressEventArgs e, Boolean negativeValue)
        {
            if (negativeValue)
            {
                // allows 0-9, backspace, and decimal
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                // allows 0-9, backspace, and decimal
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                    return;
                }
            }

            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            int selectionStart = textBox.SelectionStart;

            // Checks if the entered character is a decimal point
            if (e.KeyChar == 46)
            {
                // If the text already contains a decimal point or the caret position is at the start,
                // or the caret position is after two decimal places, cancel the input
                if (text.IndexOf('.') != -1 || selectionStart == 0 || DecimalPlacesAfter(text) >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (text.IndexOf('.') != -1)
            {
                // If there is a decimal point, check if adding the character would exceed two decimal places
                int decimalIndex = text.IndexOf('.');
                if (e.KeyChar != 8)
                {
                    if (selectionStart > decimalIndex && text.Substring(decimalIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                
            }
        }
        public static void HandleIntigerInput(object sender, KeyPressEventArgs e, Boolean negativeValue)
        {
            if (negativeValue)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                    return;
                }
            }

            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            int selectionStart = textBox.SelectionStart;
        }
        private static int DecimalPlacesAfter(string text)
        {
            int decimalIndex = text.IndexOf('.');
            if (decimalIndex != -1 && decimalIndex < text.Length - 1)
            {
                return text.Length - decimalIndex - 1;
            }
            return 0;
        }

    }
}
