namespace Video_Rental_Arshdeep
{
    partial class MovieView
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
            this.dataGridViewMovieView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovieView
            // 
            this.dataGridViewMovieView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieView.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewMovieView.Name = "dataGridViewMovieView";
            this.dataGridViewMovieView.Size = new System.Drawing.Size(997, 342);
            this.dataGridViewMovieView.TabIndex = 1;
            this.dataGridViewMovieView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovieView_CellContentClick);
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 347);
            this.Controls.Add(this.dataGridViewMovieView);
            this.Name = "MovieView";
            this.Text = "MovieView";
            this.Load += new System.EventHandler(this.MovieView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovieView;
    }
}