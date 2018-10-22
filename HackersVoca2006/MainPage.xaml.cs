using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HackersVoca2006Data;
using Windows.UI.Core;
using Windows.ApplicationModel.Core;

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
