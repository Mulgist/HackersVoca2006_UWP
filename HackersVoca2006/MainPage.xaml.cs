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
            string dayStr = "";
            int day = 0;
            if (((Button)sender).Content.ToString().Substring(0,3) == "Day")
            {
                dayStr = ((Button)sender).Content.ToString().Substring(4);
                day = int.Parse(dayStr);
            }
            else
            {
                dayStr = ((Button)sender).Content.ToString().Substring(3);
                day = int.Parse(dayStr) + 60;
            }
            KeyValuePair<int, List<List<string>>> parameter;

            List<List<string>> result = Database.GetVoca(day);
            if (result.Count == 0)
            {
                MessageBoxOpen("업데이트 예정입니다.");
            }
            else
            {
                parameter = new KeyValuePair<int, List<List<string>>>(day, result);
                Frame.Navigate(typeof(VocaPage), parameter);
            }
        }

        private async void MessageBoxOpen(string content)
        {
            var dialog = new MessageDialog(content);
            await dialog.ShowAsync();
        }
    }
}
