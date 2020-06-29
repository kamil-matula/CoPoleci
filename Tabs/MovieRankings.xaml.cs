using CoPoleci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class MovieRankings : UserControl
    {
        List<Movie> AllMovies;
        public MovieRankings()
        {
            AllMovies = QueryManager.Movies;
            InitializeComponent();
            LoadIcon();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(items.ItemsSource);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TOP 3 Najśmieszniejsze
            if (ChooseTOP.SelectedIndex == 0 && ChooseCategory != null && ChooseCategory.SelectedIndex == 0)
                ChooseFunniestMovies(3);

            // TOP 5 Najśmieszniejsze
            else if (ChooseTOP.SelectedIndex == 1 && ChooseCategory.SelectedIndex == 0)
                ChooseFunniestMovies(5);

            // TOP 10 Najśmieszniejsze
            else if (ChooseTOP.SelectedIndex == 2 && ChooseCategory.SelectedIndex == 0)
                ChooseFunniestMovies(10);

            // TOP 3 Najnowsze
            else if (ChooseTOP.SelectedIndex == 0 && ChooseCategory != null && ChooseCategory.SelectedIndex == 1)
                ChooseNewestOrOldestMovies(3, "new");

            // TOP 5 Najnowsze
            else if (ChooseTOP.SelectedIndex == 1 && ChooseCategory.SelectedIndex == 1)
                ChooseNewestOrOldestMovies(5, "new");

            // TOP 10 Najnowsze
            else if (ChooseTOP.SelectedIndex == 2 && ChooseCategory.SelectedIndex == 1)
                ChooseNewestOrOldestMovies(10, "new");

            // TOP 3 Najstarsze
            else if (ChooseTOP.SelectedIndex == 0 && ChooseCategory != null && ChooseCategory.SelectedIndex == 2)
                ChooseNewestOrOldestMovies(3, "old");

            // TOP 5 Najstarsze
            else if (ChooseTOP.SelectedIndex == 1 && ChooseCategory.SelectedIndex == 2)
                ChooseNewestOrOldestMovies(5, "old");

            // TOP 10 Najstarsze
            else if (ChooseTOP.SelectedIndex == 2 && ChooseCategory.SelectedIndex == 2)
                ChooseNewestOrOldestMovies(10, "old");

            // TOP 3 Najstraszniejsze
            else if (ChooseTOP.SelectedIndex == 0 && ChooseCategory != null && ChooseCategory.SelectedIndex == 3)
                ChooseScariestMovies(3);

            // TOP 5 Najstraszniejsze
            else if (ChooseTOP.SelectedIndex == 1 && ChooseCategory.SelectedIndex == 3)
                ChooseScariestMovies(5);

            // TOP 10 Najstraszniejsze
            else if (ChooseTOP.SelectedIndex == 2 && ChooseCategory.SelectedIndex == 3)
                ChooseScariestMovies(10);
        }

        private void Movie_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var clickedmovie = QueryManager.Movies.Find(i => i.Id == Convert.ToUInt16(btn.Tag));
            _ = QueryManager.SeenMovies; // odświeża właściwości WasSeen, AddToSeenDate i Rate w klasie Movie

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new MovieDetails(clickedmovie));
        }

        private void LoadIcon()
        {
            string nameOfImage = "branking.png";
            Image img = new Image
            {
                Height = 130,
                Width = 140,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(25, 0, 0, 0),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\{nameOfImage}", UriKind.Relative))
            };

            icon.Children.Add(img);
        }


        private void ChooseNewestOrOldestMovies(int howMany, string OldOrNew)
        {
            Dictionary<int, short> NewestMovies = new Dictionary<int, short>();
            Dictionary<int, short> OldestMovies = new Dictionary<int, short>();

            items.ClearValue(ListView.ItemsSourceProperty);
            items.Items.Clear();

            for (int i = 0; i < howMany; i++)
            {
                NewestMovies.Add(i, AllMovies[i].Year);
                OldestMovies.Add(i, AllMovies[i].Year);
            }

            for (int i = howMany; i < AllMovies.Count; i++)
            {
                short min = NewestMovies.Min(val => val.Value);
                short max = OldestMovies.Max(val => val.Value);

                if (min < AllMovies[i].Year)
                {
                    var value = NewestMovies.First(val => val.Value == min);
                    NewestMovies.Remove(value.Key);
                    NewestMovies.Add(i, AllMovies[i].Year);

                }

                if (max > AllMovies[i].Year)
                {
                    var value = OldestMovies.First(val => val.Value == max);
                    OldestMovies.Remove(value.Key);
                    OldestMovies.Add(i, AllMovies[i].Year);
                }
            }

            var OrderedOldMovies = OldestMovies.OrderBy(x => x.Value).ThenBy(y => y.Key);
            var OrderedNewMovies = NewestMovies.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            if (OldOrNew == "new")
            {
                foreach (var movie in OrderedNewMovies)
                    items.Items.Add(MovieRepo.GetAllMovies()[movie.Key]);
            }

            if (OldOrNew == "old")
            {
                foreach (var movie in OrderedOldMovies)
                    items.Items.Add(MovieRepo.GetAllMovies()[movie.Key]);
            }
            
        }

        private void ChooseFunniestMovies(int howMany)
        {
            Dictionary<int, double> FunniestMovies = new Dictionary<int, double>();
            items.ClearValue(ListView.ItemsSourceProperty);
            items.Items.Clear();

            for (int i = 0; i < howMany; i++)
            {
                FunniestMovies.Add(i, AllMovies[i].X_fun);
            }

            for (int i = howMany; i < AllMovies.Count; i++)
            {
                double min = FunniestMovies.Min(val => val.Value);

                if (min < AllMovies[i].X_fun)
                {
                    var value = FunniestMovies.First(val => val.Value == min);
                    FunniestMovies.Remove(value.Key);
                    FunniestMovies.Add(i, AllMovies[i].X_fun);

                }
            }

            var OrderedFunnyMovies = FunniestMovies.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            foreach (var movie in OrderedFunnyMovies)
            {
                items.Items.Add(MovieRepo.GetAllMovies()[movie.Key]);
            }
        }

        private void ChooseScariestMovies(int howMany)
        {
            Dictionary<int, double> ScariestMovies = new Dictionary<int, double>();
            items.ClearValue(ListView.ItemsSourceProperty);
            items.Items.Clear();

            for (int i = 0; i < howMany; i++)
            {
                ScariestMovies.Add(i, AllMovies[i].X_scary);
            }

            for (int i = howMany; i < AllMovies.Count; i++)
            {
                double min = ScariestMovies.Min(val => val.Value);

                if (min < AllMovies[i].X_scary)
                {
                    var value = ScariestMovies.First(val => val.Value == min);
                    ScariestMovies.Remove(value.Key);
                    ScariestMovies.Add(i, AllMovies[i].X_scary);

                }
            }

            var OrderedScaryMovies = ScariestMovies.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            foreach (var movie in OrderedScaryMovies)
            {
                items.Items.Add(MovieRepo.GetAllMovies()[movie.Key]);
            }
        }

    }
}