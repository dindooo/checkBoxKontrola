namespace comboBoxAplikacija
{
    partial class Form1
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
            this.dorucakBox = new System.Windows.Forms.CheckBox();
            this.narudzbaBox = new System.Windows.Forms.CheckBox();
            this.veceraBox = new System.Windows.Forms.CheckBox();
            this.rucakBox = new System.Windows.Forms.CheckBox();
            this.dugmePosalji = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dorucakBox
            // 
            this.dorucakBox.AutoSize = true;
            this.dorucakBox.Location = new System.Drawing.Point(112, 48);
            this.dorucakBox.Name = "dorucakBox";
            this.dorucakBox.Size = new System.Drawing.Size(67, 17);
            this.dorucakBox.TabIndex = 0;
            this.dorucakBox.Text = "Dorucak";
            this.dorucakBox.UseVisualStyleBackColor = true;
            this.dorucakBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // narudzbaBox
            // 
            this.narudzbaBox.AutoSize = true;
            this.narudzbaBox.Location = new System.Drawing.Point(303, 235);
            this.narudzbaBox.Name = "narudzbaBox";
            this.narudzbaBox.Size = new System.Drawing.Size(99, 17);
            this.narudzbaBox.TabIndex = 1;
            this.narudzbaBox.Text = "Sakrij narudzbu";
            this.narudzbaBox.UseVisualStyleBackColor = true;
            this.narudzbaBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // veceraBox
            // 
            this.veceraBox.AutoSize = true;
            this.veceraBox.Location = new System.Drawing.Point(112, 128);
            this.veceraBox.Name = "veceraBox";
            this.veceraBox.Size = new System.Drawing.Size(60, 17);
            this.veceraBox.TabIndex = 2;
            this.veceraBox.Text = "Vecera";
            this.veceraBox.UseVisualStyleBackColor = true;
            // 
            // rucakBox
            // 
            this.rucakBox.AutoSize = true;
            this.rucakBox.Location = new System.Drawing.Point(112, 88);
            this.rucakBox.Name = "rucakBox";
            this.rucakBox.Size = new System.Drawing.Size(58, 17);
            this.rucakBox.TabIndex = 3;
            this.rucakBox.Text = "Rucak";
            this.rucakBox.UseVisualStyleBackColor = true;
            // 
            // dugmePosalji
            // 
            this.dugmePosalji.Location = new System.Drawing.Point(112, 231);
            this.dugmePosalji.Name = "dugmePosalji";
            this.dugmePosalji.Size = new System.Drawing.Size(75, 23);
            this.dugmePosalji.TabIndex = 4;
            this.dugmePosalji.Text = "Posalji";
            this.dugmePosalji.UseVisualStyleBackColor = true;
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(303, 46);
            this.ispis.Multiline = true;
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(185, 153);
            this.ispis.TabIndex = 5;
            this.ispis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 596);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.dugmePosalji);
            this.Controls.Add(this.rucakBox);
            this.Controls.Add(this.veceraBox);
            this.Controls.Add(this.narudzbaBox);
            this.Controls.Add(this.dorucakBox);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucakBox;
        private System.Windows.Forms.CheckBox narudzbaBox;
        private System.Windows.Forms.CheckBox veceraBox;
        private System.Windows.Forms.CheckBox rucakBox;
        private System.Windows.Forms.Button dugmePosalji;
        private System.Windows.Forms.TextBox ispis;
    }
}

