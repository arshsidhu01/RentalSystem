namespace RentalSystem
{
    partial class Issue_ReturnVideo
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
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAllRentedMovie = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIssueVideo = new System.Windows.Forms.Button();
            this.RentedDate = new System.Windows.Forms.DateTimePicker();
            this.ddlVideo = new System.Windows.Forms.ComboBox();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.rbAllRental = new System.Windows.Forms.RadioButton();
            this.rbRentedOut = new System.Windows.Forms.RadioButton();
            this.button_return = new System.Windows.Forms.Button();
            this.rentalVideoId = new System.Windows.Forms.Label();
            this.videoId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllRentedMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "DateReturned";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "DateRented";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // Plot
            // 
            this.Plot.DataPropertyName = "Plot";
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "RentalCost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            this.RentalCost.Width = 50;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "RentedMovieId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            this.RMID.Width = 50;
            // 
            // gridAllRentedMovie
            // 
            this.gridAllRentedMovie.AllowUserToAddRows = false;
            this.gridAllRentedMovie.AllowUserToDeleteRows = false;
            this.gridAllRentedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllRentedMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.Plot,
            this.DateRented,
            this.DateReturned});
            this.gridAllRentedMovie.Location = new System.Drawing.Point(12, 332);
            this.gridAllRentedMovie.Name = "gridAllRentedMovie";
            this.gridAllRentedMovie.ReadOnly = true;
            this.gridAllRentedMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllRentedMovie.Size = new System.Drawing.Size(975, 224);
            this.gridAllRentedMovie.TabIndex = 59;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // btnIssueVideo
            // 
            this.btnIssueVideo.BackColor = System.Drawing.Color.White;
            this.btnIssueVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIssueVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.btnIssueVideo.Location = new System.Drawing.Point(190, 226);
            this.btnIssueVideo.Name = "btnIssueVideo";
            this.btnIssueVideo.Size = new System.Drawing.Size(153, 37);
            this.btnIssueVideo.TabIndex = 58;
            this.btnIssueVideo.Text = "Issue Video";
            this.btnIssueVideo.UseVisualStyleBackColor = false;
            this.btnIssueVideo.Click += new System.EventHandler(this.btnRentalVideo_Click);
            // 
            // RentedDate
            // 
            this.RentedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentedDate.Location = new System.Drawing.Point(190, 185);
            this.RentedDate.Name = "RentedDate";
            this.RentedDate.Size = new System.Drawing.Size(230, 20);
            this.RentedDate.TabIndex = 56;
            // 
            // ddlVideo
            // 
            this.ddlVideo.FormattingEnabled = true;
            this.ddlVideo.Location = new System.Drawing.Point(190, 143);
            this.ddlVideo.Name = "ddlVideo";
            this.ddlVideo.Size = new System.Drawing.Size(230, 21);
            this.ddlVideo.TabIndex = 54;
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(190, 95);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(230, 21);
            this.ddlCustomer.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(293, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 46);
            this.label3.TabIndex = 63;
            this.label3.Text = "Issue/Return Video\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(42, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Select Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(42, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select Movie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(42, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Rental Date";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.btn_close.Image = global::RentalSystem.Properties.Resources.cancel__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(349, 224);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.btn_close.Size = new System.Drawing.Size(133, 39);
            this.btn_close.TabIndex = 68;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rbAllRental
            // 
            this.rbAllRental.AutoSize = true;
            this.rbAllRental.BackColor = System.Drawing.Color.Transparent;
            this.rbAllRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllRental.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbAllRental.Location = new System.Drawing.Point(12, 298);
            this.rbAllRental.Name = "rbAllRental";
            this.rbAllRental.Size = new System.Drawing.Size(120, 17);
            this.rbAllRental.TabIndex = 69;
            this.rbAllRental.TabStop = true;
            this.rbAllRental.Text = "All Rented Video";
            this.rbAllRental.UseVisualStyleBackColor = false;
            this.rbAllRental.CheckedChanged += new System.EventHandler(this.rbAllRental_CheckedChanged);
            // 
            // rbRentedOut
            // 
            this.rbRentedOut.AutoSize = true;
            this.rbRentedOut.BackColor = System.Drawing.Color.Transparent;
            this.rbRentedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRentedOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbRentedOut.Location = new System.Drawing.Point(161, 298);
            this.rbRentedOut.Name = "rbRentedOut";
            this.rbRentedOut.Size = new System.Drawing.Size(126, 17);
            this.rbRentedOut.TabIndex = 70;
            this.rbRentedOut.TabStop = true;
            this.rbRentedOut.Text = "Rented Out Video";
            this.rbRentedOut.UseVisualStyleBackColor = false;
            this.rbRentedOut.CheckedChanged += new System.EventHandler(this.rbRentedOut_CheckedChanged);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.White;
            this.button_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(89)))), ((int)(((byte)(144)))));
            this.button_return.Location = new System.Drawing.Point(834, 578);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(153, 37);
            this.button_return.TabIndex = 71;
            this.button_return.Text = "Return Video";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentalVideoId
            // 
            this.rentalVideoId.AutoSize = true;
            this.rentalVideoId.Location = new System.Drawing.Point(664, 215);
            this.rentalVideoId.Name = "rentalVideoId";
            this.rentalVideoId.Size = new System.Drawing.Size(0, 13);
            this.rentalVideoId.TabIndex = 72;
            this.rentalVideoId.Visible = false;
            // 
            // videoId
            // 
            this.videoId.AutoSize = true;
            this.videoId.Location = new System.Drawing.Point(789, 215);
            this.videoId.Name = "videoId";
            this.videoId.Size = new System.Drawing.Size(0, 13);
            this.videoId.TabIndex = 73;
            this.videoId.Visible = false;
            // 
            // Issue_ReturnVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalSystem.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1008, 747);
            this.Controls.Add(this.videoId);
            this.Controls.Add(this.rentalVideoId);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.rbRentedOut);
            this.Controls.Add(this.rbAllRental);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridAllRentedMovie);
            this.Controls.Add(this.btnIssueVideo);
            this.Controls.Add(this.RentedDate);
            this.Controls.Add(this.ddlVideo);
            this.Controls.Add(this.ddlCustomer);
            this.Name = "Issue_ReturnVideo";
            this.Text = "Issue_ReturnVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Issue_ReturnVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllRentedMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridView gridAllRentedMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Button btnIssueVideo;
        private System.Windows.Forms.DateTimePicker RentedDate;
        private System.Windows.Forms.ComboBox ddlVideo;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RadioButton rbAllRental;
        private System.Windows.Forms.RadioButton rbRentedOut;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label rentalVideoId;
        private System.Windows.Forms.Label videoId;
    }
}