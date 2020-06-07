namespace Video_Rental_Arshdeep
{
    partial class MovieAdd
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
            this.btnAddMovies = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMovies
            // 
            this.btnAddMovies.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovies.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovies.Location = new System.Drawing.Point(266, 219);
            this.btnAddMovies.Name = "btnAddMovies";
            this.btnAddMovies.Size = new System.Drawing.Size(166, 71);
            this.btnAddMovies.TabIndex = 47;
            this.btnAddMovies.Text = "Add Movie";
            this.btnAddMovies.UseVisualStyleBackColor = false;
            this.btnAddMovies.Click += new System.EventHandler(this.btnAddMovies_Click);
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(438, 143);
            this.genre.Multiline = true;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(176, 28);
            this.genre.TabIndex = 46;
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(128, 145);
            this.plot.Multiline = true;
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(176, 26);
            this.plot.TabIndex = 45;
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(438, 97);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(176, 20);
            this.copies.TabIndex = 44;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(128, 101);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(176, 20);
            this.year.TabIndex = 43;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(128, 52);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(176, 25);
            this.title.TabIndex = 41;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(438, 48);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(176, 20);
            this.rating.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(369, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Plot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(369, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Copies:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(369, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rating:";
            // 
            // MovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.btnAddMovies);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovieAdd";
            this.Text = "MovieAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovies;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}