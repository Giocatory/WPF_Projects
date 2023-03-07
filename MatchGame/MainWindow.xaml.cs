using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthOfSecondsElapsed;
        int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;

            SetupGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tenthOfSecondsElapsed++;
            timeTextBlock.Text = (tenthOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text += " - Play again?";
            }
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetupGame();
            }
        }

        private void SetupGame()
        {
            Random random = new Random();

            List<string> animalEmoji = new() 
            {
                "🐎", "🐎",
                "🐘", "🐘",
                "🐄", "🐄",
                "🐕", "🐕",
                "🐈", "🐈",
                "🐒", "🐒",
                "🐁", "🐁",
                "🦆", "🦆",
                //"🐎", "🐎"
            };

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                if(textBlock.Name != "timeTextBlock")
                {
                    int count = animalEmoji.Count - 1;
                    int index = random.Next(count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
                
            }

            timer.Start();
            tenthOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        TextBlock? lastTextBlockClicked;
        bool findingMatch = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock? textBlock = sender as TextBlock;
            if (findingMatch == false && textBlock != null)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock?.Text == lastTextBlockClicked?.Text)
            {
                matchesFound += 1;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }
    }
}
