using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coverter
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to close it ?", "Close...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBinary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)8)
                e.Handled = false;
            else if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
            else if (ch != '1' && ch != '0')
                e.Handled = true;
                
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)8)
                e.Handled = false;
            else if (!char.IsDigit(ch))
                e.Handled = true;
        }

        private void txtHexadecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)8)
                e.Handled = false;
            else if (!char.IsDigit(ch) && !(ch >= 'A' && ch <= 'G'))
                e.Handled = true;
        }

        private void txtBinary_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBinary.Text.Trim()))
            {
                txtDecimal.Enabled = false;
                txtHexadecimal.Enabled = false;
            }
            else
            {
                txtDecimal.Enabled = true;
                txtHexadecimal.Enabled = true;
            }
        }

        private void txtBinary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBinary.Text.Trim()))
            {
                txtDecimal.Text = null;
                txtHexadecimal.Text = null;
                txtDecimal.Enabled = true;
                txtHexadecimal.Enabled = true;
            }
        }

        private void txtDecimal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDecimal.Text.Trim()))
            {
                txtBinary.Enabled = false;
                txtHexadecimal.Enabled = false;
            }
            else
            {
                txtBinary.Enabled = true;
                txtHexadecimal.Enabled = true;
            }
        }

        private void txtDecimal_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDecimal.Text.Trim()))
            {
                txtBinary.Text = null;
                txtHexadecimal.Text = null;
                txtBinary.Enabled = true;
                txtHexadecimal.Enabled = true;
            }
        }

        private void txtHexadecimal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHexadecimal.Text.Trim()))
            {
                txtBinary.Enabled = false;
                txtDecimal.Enabled = false;
            }
            else
            {
                txtBinary.Enabled = true;
                txtDecimal.Enabled = true;
            }
        }

        private void txtHexadecimal_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHexadecimal.Text.Trim()))
            {
                txtDecimal.Text = null;
                txtBinary.Text = null;
                txtBinary.Enabled = true;
                txtDecimal.Enabled = true;
            }
        }
        private void btConvert_Click(object sender, EventArgs e)
        {
            long bin, dec = 0, re;
            int i;


            if (string.IsNullOrEmpty(txtBinary.Text.Trim()) && string.IsNullOrEmpty(txtDecimal.Text.Trim()) && string.IsNullOrEmpty(txtHexadecimal.Text.Trim()))
            {
                MessageBox.Show("សូមបញ្ចូនចំនួនក្នុងប្រព័ន្ធគោលណាមួយជាមុនសិន", "Messing...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBinary.Focus();
            }
            else if (!string.IsNullOrEmpty(txtBinary.Text.Trim()))
            {
                txtDecimal.Text = null;
                txtHexadecimal.Text = null;
                i = 0;
                bin = long.Parse(txtBinary.Text);
                while (bin > 0)
                {
                    re = bin % 10;
                    bin = bin / 10;
                    dec = dec + re * (int)Math.Pow(2, i);
                    i++;
                }
                txtDecimal.Text = dec.ToString();

                //Convert from Decimal to HexaDecimal//

                char[] hexaDeciNum = new char[30];

                // counter for hexadecimal number array
                i = 0;
                while (dec != 0)
                {
                    // temporary variable to
                    // store remainder
                    long temp = 0;

                    // storing remainder in temp
                    // variable.
                    temp = dec % 16;

                    // check if temp < 10
                    if (temp < 10)
                    {
                        hexaDeciNum[i] = (char)(temp + 48);
                        i++;
                    }
                    else
                    {
                        hexaDeciNum[i] = (char)(temp + 55);
                        i++;
                    }

                    dec = dec / 16;
                }

                // printing hexadecimal number
                // array in reverse order
                for (int j = i - 1; j >= 0; j--)
                    txtHexadecimal.Text = txtHexadecimal.Text + hexaDeciNum[j];
            }


            else if (!string.IsNullOrEmpty(txtDecimal.Text.Trim()))
            {
                txtBinary.Text = null;
                txtHexadecimal.Text = null;
                dec = long.Parse(txtDecimal.Text);

                //Convert from Decimal to HexaDecimal//

                char[] hexaDeciNum = new char[30];

                // counter for hexadecimal number array
                i = 0;
                while (dec != 0)
                {
                    // temporary variable to
                    // store remainder
                    long temp = 0;

                    // storing remainder in temp
                    // variable.
                    temp = dec % 16;

                    // check if temp < 10
                    if (temp < 10)
                    {
                        hexaDeciNum[i] = (char)(temp + 48);
                        i++;
                    }
                    else
                    {
                        hexaDeciNum[i] = (char)(temp + 55);
                        i++;
                    }

                    dec = dec / 16;
                }

                // printing hexadecimal number
                // array in reverse order
                for (int j = i - 1; j >= 0; j--)
                    txtHexadecimal.Text = txtHexadecimal.Text + hexaDeciNum[j];

                //convert from decimal to binary
                // array to store binary number
                dec = long.Parse(txtDecimal.Text);
                long[] binaryNum = new long[32];
                // counter for binary array
                i = 0;
                while (dec > 0)
                {
                    // storing remainder in
                    // binary array
                    binaryNum[i] = dec % 2;
                    dec = dec / 2;
                    i++;
                }

                // printing binary array
                // in reverse order
                for (int j = i - 1; j >= 0; j--)
                    txtBinary.Text = txtBinary.Text + binaryNum[j];
            }


            else
            {
                txtBinary.Text = null;
                txtDecimal.Text = null;

                // Convert from Hexadecimal to Decimal
                string hexVal=txtHexadecimal.Text;
                int len = hexVal.Length;

                // Initializing base1 value
                // to 1, i.e 16^0
                int base1 = 1;

                int dec_val = 0;

                // Extracting characters as
                // digits from last character
                for (i = len - 1; i >= 0; i--)
                {
                    // if character lies in '0'-'9',
                    // converting it to integral 0-9
                    // by subtracting 48 from ASCII value
                    if (hexVal[i] >= '0' && hexVal[i] <= '9')
                    {
                        dec_val += (hexVal[i] - 48) * base1;

                        // incrementing base1 by power
                        base1 = base1 * 16;
                    }

                    // if character lies in 'A'-'F' ,
                    // converting it to integral
                    // 10 - 15 by subtracting 55
                    // from ASCII value
                    else if (hexVal[i] >= 'A' && hexVal[i] <= 'F')
                    {
                        dec_val += (hexVal[i] - 55) * base1;

                        // incrementing base1 by power
                        base1 = base1 * 16;
                    }
                }
                txtDecimal.Text = dec_val.ToString();

                //convert from decimal to binary
                // array to store binary number
                dec = long.Parse(txtDecimal.Text);
                long[] binaryNum = new long[32];
                // counter for binary array
                i = 0;
                while (dec > 0)
                {
                    // storing remainder in
                    // binary array
                    binaryNum[i] = dec % 2;
                    dec = dec / 2;
                    i++;
                }

                // printing binary array
                // in reverse order
                for (int j = i - 1; j >= 0; j--)
                    txtBinary.Text = txtBinary.Text + binaryNum[j];
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = null;
                }
                ct.Enabled = true;
            }
        }
    }
}
