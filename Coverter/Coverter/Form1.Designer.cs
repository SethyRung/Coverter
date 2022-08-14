
namespace Coverter
{
    partial class Convert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHexadecimal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "បម្លែងប្រព័ន្ធគោល";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 67);
            this.panel1.TabIndex = 1;
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(49, 123);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(433, 42);
            this.txtBinary.TabIndex = 1;
            this.txtBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBinary.Enter += new System.EventHandler(this.txtBinary_Enter);
            this.txtBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinary_KeyPress);
            this.txtBinary.Leave += new System.EventHandler(this.txtBinary_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ប្រព័ន្ធគោល២";
            // 
            // btConvert
            // 
            this.btConvert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConvert.Image = global::Coverter.Properties.Resources.replace_32;
            this.btConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConvert.Location = new System.Drawing.Point(49, 396);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(120, 42);
            this.btConvert.TabIndex = 4;
            this.btConvert.Text = "Convert";
            this.btConvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConvert.UseVisualStyleBackColor = false;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::Coverter.Properties.Resources.reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(204, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 42);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Coverter.Properties.Resources.close_window_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(362, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ប្រព័ន្ធគោល១០";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(49, 210);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(433, 42);
            this.txtDecimal.TabIndex = 2;
            this.txtDecimal.Tag = "";
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDecimal.Enter += new System.EventHandler(this.txtDecimal_Enter);
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            this.txtDecimal.Leave += new System.EventHandler(this.txtDecimal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "ប្រព័ន្ធគោល១៦";
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Location = new System.Drawing.Point(49, 304);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.Size = new System.Drawing.Size(433, 42);
            this.txtHexadecimal.TabIndex = 3;
            this.txtHexadecimal.Tag = "";
            this.txtHexadecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHexadecimal.Enter += new System.EventHandler(this.txtHexadecimal_Enter);
            this.txtHexadecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexadecimal_KeyPress);
            this.txtHexadecimal.Leave += new System.EventHandler(this.txtHexadecimal_Leave);
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(524, 492);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHexadecimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBinary);
            this.Font = new System.Drawing.Font("!Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Convert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHexadecimal;
    }
}

