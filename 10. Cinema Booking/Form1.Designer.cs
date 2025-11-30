namespace _10.Cinema_Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "10. Cinema Booking ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Location = new System.Drawing.Point(132, 86);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(148, 20);
            this.textBoxMovie.TabIndex = 2;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(132, 112);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(148, 20);
            this.textBoxGenre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genre:";
            // 
            // textBoxSeat
            // 
            this.textBoxSeat.Location = new System.Drawing.Point(132, 138);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.Size = new System.Drawing.Size(148, 20);
            this.textBoxSeat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(132, 164);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownPrice.TabIndex = 8;
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowDetails.Location = new System.Drawing.Point(73, 210);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(175, 36);
            this.buttonShowDetails.TabIndex = 9;
            this.buttonShowDetails.Text = "Show Ticket Details";
            this.buttonShowDetails.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowDetails);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "10. Cinema Booking ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonShowDetails;
    }
}

