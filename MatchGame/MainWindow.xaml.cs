using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MatchGame
{
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer = new();
        private int tenthOfSecondsElapsed;
        private int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Start_game_Click()
        {
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
                timeTextBlock.Text += " - nice!!!";

                #region Dialog window with buttons

                string sMessageBoxText = "Do you want to continue?";
                string sCaption = "Match animals";

                MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
                MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

                MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

                switch (rsltMessageBox)
                {
                    case MessageBoxResult.Yes:
                        SetupGame();
                        break;

                    case MessageBoxResult.No:
                        MessageBox.Show("До новых встреч!!!");
                        Application.Current.Shutdown();
                        break;

                    case MessageBoxResult.Cancel:
                        MessageBox.Show("До новых встреч!!!");
                        Application.Current.Shutdown();
                        break;
                }

                #endregion Dialog window with buttons
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
            Random random = new();

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

            #region Entered textBlocks random animals

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                textBlock.Visibility = Visibility.Visible;
                if (textBlock.Name != "timeTextBlock")
                {
                    int count = animalEmoji.Count - 1;
                    int index = random.Next(count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }

            #endregion Entered textBlocks random animals

            timer.Start();
            tenthOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        private TextBlock? lastTextBlockClicked;
        private bool findingMatch = false;

        #region Main game logic

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

        #endregion Main game logic

        private void Start_game_Click(object sender, RoutedEventArgs e)
        {
            Start_game_Click();
        }
    }
}