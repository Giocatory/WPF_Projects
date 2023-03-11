using System;
using System.Windows;

namespace CardPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderPickCard_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cardsNumber.Text = sliderPickCard.Value.ToString("0");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cardsList.Items.Clear();
            string[] cards = CardPickerChoice.PickSomeCards(Convert.ToInt32(cardsNumber.Text));
            foreach (var card in cards)
            {
                cardsList.Items.Add(card);
            }
        }
    }
}