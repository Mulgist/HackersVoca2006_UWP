using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HackersVoca2006Data;

namespace HackersVoca2006
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DayBtn_Click(object sender, RoutedEventArgs e)
        {
            string dayStr = ((Button)sender).Content.ToString().Substring(4);
            int day = int.Parse(dayStr);

            List<List<string>> result = Database.GetVoca(day);
            if (result.Count == 0)
            {
                MessageBoxOpen("업데이트 예정입니다.");
            }
            else
            {
                Frame.Navigate(typeof(VocaPage), result);
            }
        }

        private async void MessageBoxOpen(string content)
        {
            var dialog = new MessageDialog(content);
            await dialog.ShowAsync();
        }
    }
}
