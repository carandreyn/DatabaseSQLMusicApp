namespace DatabaseSqlMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadAlbums = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAlbumBtn = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_imageURL = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadAlbums
            // 
            this.LoadAlbums.Location = new System.Drawing.Point(291, 19);
            this.LoadAlbums.Name = "LoadAlbums";
            this.LoadAlbums.Size = new System.Drawing.Size(146, 24);
            this.LoadAlbums.TabIndex = 0;
            this.LoadAlbums.Text = "Load Albums";
            this.LoadAlbums.UseVisualStyleBackColor = true;
            this.LoadAlbums.Click += new System.EventHandler(this.LoadAlbums_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(690, 177);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(653, 19);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(146, 24);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 23);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1000, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAlbumBtn);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.txt_imageURL);
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.txt_artist);
            this.groupBox1.Controls.Add(this.txt_albumName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Album";
            // 
            // addAlbumBtn
            // 
            this.addAlbumBtn.Location = new System.Drawing.Point(172, 174);
            this.addAlbumBtn.Name = "addAlbumBtn";
            this.addAlbumBtn.Size = new System.Drawing.Size(75, 23);
            this.addAlbumBtn.TabIndex = 12;
            this.addAlbumBtn.Text = "Add";
            this.addAlbumBtn.UseVisualStyleBackColor = true;
            this.addAlbumBtn.Click += new System.EventHandler(this.addAlbumBtn_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(88, 146);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(159, 23);
            this.txt_description.TabIndex = 11;
            // 
            // txt_imageURL
            // 
            this.txt_imageURL.Location = new System.Drawing.Point(82, 113);
            this.txt_imageURL.Name = "txt_imageURL";
            this.txt_imageURL.Size = new System.Drawing.Size(165, 23);
            this.txt_imageURL.TabIndex = 10;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(52, 84);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(195, 23);
            this.txt_year.TabIndex = 9;
            // 
            // txt_artist
            // 
            this.txt_artist.Location = new System.Drawing.Point(56, 54);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.Size = new System.Drawing.Size(191, 23);
            this.txt_artist.TabIndex = 8;
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(99, 25);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(148, 23);
            this.txt_albumName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ImageURL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Album Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(582, 150);
            this.dataGridView2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoadAlbums);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadAlbums;
        private DataGridView dataGridView1;
        private Button SearchButton;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_description;
        private TextBox txt_imageURL;
        private TextBox txt_year;
        private TextBox txt_artist;
        private TextBox txt_albumName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button addAlbumBtn;
        private Label label6;
        private DataGridView dataGridView2;
    }
}