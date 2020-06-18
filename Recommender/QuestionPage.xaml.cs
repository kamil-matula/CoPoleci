using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class QuestionPage : UserControl
    {
        int intRate = 0, intCount = 1, Rate = 0;
        public double wynik;

        public QuestionPage()
        {
            InitializeComponent();
            LoadImages();
            QuestionNumber.Text = $"Pytanie nr {++Questions.Number}";
            QuestionBlock.Text = Questions.questions[Questions.Number - 1];
            LeftEnd.Text = Questions.leftEnds[Questions.Number - 1];
            RightEnd.Text = Questions.rightEnds[Questions.Number - 1];
            Above.Text = Questions.aboves[Questions.Number - 1];
        }

        private void nextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            if (rateValue.Text == "")
            {
                MessageBox.Show("Podaj ilość gwiazdek!");
            }
            else
            {
                wynik = Convert.ToDouble(rateValue.Text) / 10;
                Ratings.RatingsList.Add(wynik);
                rateValue.Text = "";

                // Przejście na kolejną stronę
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).GridPrincipal.Children.Clear();
                        if (Questions.Number == 10) (window as MainWindow).GridPrincipal.Children.Add(new Result());
                        else (window as MainWindow).GridPrincipal.Children.Add(new QuestionPage());
                    }
                }
            }
        }

        private void LoadImages()
        {
            for (int i = 1; i <= 10; i++)
            {
                Image img = new Image
                {
                    Name = "imgRate" + i,
                    Stretch = Stretch.UniformToFill,
                    Height = 30,
                    Width = 30,
                    Source = new BitmapImage(new Uri(@"\Images\gwiazdaSzara.png", UriKind.Relative))
                };
                img.MouseEnter += imgRateMinus_MouseEnter;
                greyStarRate.Children.Add(img);

                Image img1 = new Image
                {
                    Name = "imgRate" + i + i,
                    Stretch = Stretch.UniformToFill,
                    Height = 30,
                    Width = 30,
                    Visibility = Visibility.Hidden,
                    Source = new BitmapImage(new Uri(@"\Images\gwiazda.png", UriKind.Relative))
                };
                img1.MouseEnter += imgRatePlus_MouseEnter;
                img1.MouseLeave += imgRatePlus_MouseLeave;
                img1.MouseLeftButtonUp += imgRatePlus_MouseLeftButtonUp;
                goldStarRate.Children.Add(img1);
            }
        }
       
        private void imgRateMinus_MouseEnter(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Visible, Visibility.Hidden);
        }

        private void imgRatePlus_MouseEnter(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Visible, Visibility.Hidden);
        }

        private void imgRatePlus_MouseLeave(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Hidden, Visibility.Visible);
        }

        private void starRating_MouseLeave(object sender, MouseEventArgs e)
        {
            SetImage(Rate, Visibility.Visible, Visibility.Hidden);
        }

        private void GetData(object sender, Visibility imgYellowVisibility, Visibility imgGrayVisibility)
        {
            GetRating(sender as Image);
            SetImage(intRate, imgYellowVisibility, imgGrayVisibility);
        }

        private void SetImage(int intRate, Visibility imgYellowVisibility, Visibility imgGrayVisibility)
        {
            foreach (Image imgItem in goldStarRate.Children.OfType<Image>())
            {
                if (intCount <= intRate)
                    imgItem.Visibility = imgYellowVisibility;
                else
                    imgItem.Visibility = imgGrayVisibility;
                intCount++;
            }
            intCount = 1;
        }

        private void imgRatePlus_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GetRating(sender as Image);
            Rate = intRate;
            rateValue.Text = intRate.ToString();
        }

        private void GetRating(Image Img)
        {
            string strImgName = Img.Name;
            if ((strImgName == "imgRate10") || (strImgName == "imgRate1010"))
            {
                intRate = Convert.ToInt32(strImgName.Substring(strImgName.Length - 2, 2));
            }
            else
            {
                intRate = Convert.ToInt32(strImgName.Substring(strImgName.Length - 1, 1));
            }
        }
    }
}