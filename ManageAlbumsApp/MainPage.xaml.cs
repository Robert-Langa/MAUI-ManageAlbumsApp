namespace ManageAlbumsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddAlbumClicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            string band = BandEntry.Text;
            string yearProduced = YearProducedEntry.Text;

            if (string.IsNullOrWhiteSpace(title) ||
                    string.IsNullOrWhiteSpace(band) ||
                        string.IsNullOrWhiteSpace(yearProduced))
            {
                ResultsLabel.Text = "Enter the Title,Band/Artist & Year of the Album to proceed.";
                return;
            }

            try
            {
                int year = int.Parse(yearProduced);

                Album album = new Album()
                {
                    Title = title,
                    Band = band,
                    YearProduced = year
                };

                _albumManager.AddAlbum(album);

                ResultsLabel.Text = $"\"{title}\" by the {band} was added successfully!";

                TitleEntry.Text = "";
                BandEntry.Text = "";
                YearProducedEntry.Text = "";

            }

            catch (ArgumentException aex)
            {
                ResultsLabel.Text = aex.Message;
            }
            catch (Exception ex)
            {
                ResultsLabel.Text = "Year produced must be an integer number.";
            }

        }

        private void OnShowAlbumsBtnClicked(object sender, EventArgs e)
        {
            if (_albumManager.NumberOfAlbums == 0)
            {
                ResultsLabel.Text = "No albums to show - use the form to enter some!";
                return;
            }

            ResultsLabel.Text = "";

            string allAlbums = "";

            foreach (Album album in _albumManager.GetAllAlbums())
            {
                allAlbums += $"\"{album}\n";

            }

            AllAlbumsEditor.Text = allAlbums;
        }

        private void OnShowAlbumsByYearBtnClicked(object sender, EventArgs e)
        {
            if (_albumManager.NumberOfAlbums == 0)
            {
                ResultsLabel.Text = "No albums to show - use the form to enter some!";
                return;
            }


            ResultsLabel.Text = "";

            string allAlbums = "";

            int filterYear = int.Parse(AlbumByYearProducedEntry.Text);


            foreach (Album album in _albumManager.GetAlbumsWithMinYear(filterYear))
            {
                allAlbums += $"{album}\n";
            }

            AllAlbumsEditor.Text = allAlbums;

        }

        private AlbumManager _albumManager = new AlbumManager();

    }

}
