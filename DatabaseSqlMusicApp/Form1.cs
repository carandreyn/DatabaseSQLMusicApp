namespace DatabaseSqlMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource AlbumBindingSource = new BindingSource();
        BindingSource TracksBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAlbums_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            AlbumBindingSource.DataSource = albumsDAO.getAllAlbums();

            dataGridView1.DataSource = AlbumBindingSource;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            AlbumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = AlbumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            string imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);

            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            TracksBindingSource.DataSource = albumsDAO.getTracksUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView2.DataSource = TracksBindingSource;
        }

        private void addAlbumBtn_Click(object sender, EventArgs e)
        {
            // add a new item to the database
            Album album = new Album()
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);

            MessageBox.Show(result + " rows have been inserted.");
        }
    }
}