﻿using System.Windows;
using System.Windows.Controls;
using CoPoleci.DAL;

namespace CoPoleci
{
    public partial class MovieDetails : UserControl
    {
        private readonly Movie clickedmovie = null;
        public MovieDetails(Movie movie)
        {
            InitializeComponent();
            clickedmovie = movie;
            if (clickedmovie.WasSeen == false)
            {
                ButtonAdd.Visibility = Visibility.Visible;
                ButtonRemove.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonAdd.Visibility = Visibility.Hidden;
                ButtonRemove.Visibility = Visibility.Visible;
            }
            LoadInfo();
            ActorListView.ItemsSource = ActorRepo.GetActorsFromMovie(clickedmovie);
            ActorListView.Items.Refresh();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            year_TextBlock.Text = "Rok produkcji: " + clickedmovie.Year.ToString();
            genre_TextBlock.Text = "Gatunek: " + clickedmovie.Genre;
            posterImage.Children.Add(new Image { Height = 500, Width = 190, Source = clickedmovie.Poster, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do zakładki:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }

        // Dodawanie filmu do ulubionych:
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (MovieRepo.AddToSeen(clickedmovie) == false)
            {
                MessageBox.Show("Nie udało się dodać filmu do obejrzanych!");
                return;
            }
            clickedmovie.WasSeen = true;
            ButtonAdd.Visibility = Visibility.Hidden;
            ButtonRemove.Visibility = Visibility.Visible;
        }

        // Usuwanie filmu z ulubionych:
        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (MovieRepo.RemoveFromSeen(clickedmovie) == false)
            {
                MessageBox.Show("Nie udało się usunąć filmu z obejrzanych!");
                return;
            }
            clickedmovie.WasSeen = false;
            ButtonAdd.Visibility = Visibility.Visible;
            ButtonRemove.Visibility = Visibility.Hidden;
        }
    }
}