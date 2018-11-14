using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.System;
using Windows.UI.Core;
using HackersVoca2006Data;

namespace HackersVoca2006
{
    public sealed partial class VocaPage : Page
    {
        List<List<string>> entries = null;
        List<List<string>> randomEntries = null;
        List<string> currentVoca = null;
        List<int> confirmedVoca = null;
        int count = 0;
        int remainCount = 0;
        int index = 0;

        public VocaPage()
        {
            InitializeComponent();

            // 새로운 페이지에 계속 이 구문만 반복되면 누적된다.
            // 그래서 페이지를 다시 로드해서 키를 누르면 이전에 썼던 페이지도 같이 동작한다. (키다운 누적)
            Window.Current.CoreWindow.KeyDown += CoreWindowKeyDown;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            KeyValuePair<int, List<List<string>>> parameter = (KeyValuePair<int, List<List<string>>>)e.Parameter;
            entries = parameter.Value;
            if (parameter.Key <= 60)
            {
                DayTextBlock.Text = "Day " + parameter.Key.ToString();
            }
            else
            {
                string explanation = Database.GetExplanation(parameter.Key);
                DayTextBlock.Text = "Special " + (parameter.Key - 60).ToString() + " - " + explanation;
            }

            count = entries.Count;
            remainCount = count;
            RemainCntTextBlock.Text = remainCount.ToString() + " / " + count.ToString();
            Start();
        }

        // 페이지가 이동될때 마지막으로 할 행동
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            // 범용으로 키다운 컨트롤을 없앤다. (키다운 누적 방지)
            Window.Current.CoreWindow.KeyDown -= CoreWindowKeyDown;
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            Prev();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            Next();
        }

        private List<List<string>> ListRandomizer(List<List<string>> origin)
        {
            List<List<string>> random = new List<List<string>>();
            int[] randomNumbers = new int[origin.Count];
            Random rand = new Random();
            int num;

            for (int i = 0; i < origin.Count; i++)
            {
                while (true)
                {
                    num = rand.Next(1, origin.Count + 1);
                    if (randomNumbers.Contains(num)) { continue; }
                    else
                    {
                        randomNumbers[i] = num;
                        random.Add(origin.ElementAt(randomNumbers[i] - 1));
                        break;
                    }
                }
            }

            return random;
        }

        private List<List<string>> RefreshEntries(List<List<string>> prevList, List<int> confirmedIndeces)
        {
            List<List<string>> tempList = null;
            List<List<string>> newList = null;

            if (confirmedVoca == null) tempList = prevList;
            else
            {
                tempList = new List<List<string>>();
                for (int i = 0; i < prevList.Count; i++)
                {
                    if (confirmedIndeces.Contains(i)) continue;
                    else tempList.Add(prevList.ElementAt(i));
                }

                if (tempList.Count == 0)
                    return null;
            }

            newList = ListRandomizer(tempList);
            return newList;
        }

        private void Start()
        {
            // 페이지 텍스트 모두 지우기
            EngTextBlock.Text = "";
            MeanCountTextBlock.Text = "";
            KorTextBlock1.Text = "";
            KorTextBlock2.Text = "";
            KorTextBlock3.Text = "";
            ConfirmedChkBox.IsChecked = false;

            index = 0;
            if (randomEntries == null) randomEntries = RefreshEntries(entries, confirmedVoca);
            else randomEntries = RefreshEntries(randomEntries, confirmedVoca);
            confirmedVoca = new List<int>();

            // 전부 다 암기하여 끝남
            if (randomEntries == null)
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                }
            }
            else
            {
                currentVoca = randomEntries.ElementAt(index);
                EngTextBlock.Text = currentVoca.ElementAt(0);
                if (CountOfMeans(currentVoca) == 2) MeanCountTextBlock.Text = "(두가지 뜻)";
                else if (CountOfMeans(currentVoca) == 3) MeanCountTextBlock.Text = "(세가지 뜻)";
            }
        }

        private void Prev()
        {
            MessageBoxOpen("업데이트 예정입니다.");
        }

        private void Next()
        {
            int currentCount = CountOfMeans(currentVoca);

            if (KorTextBlock1.Text == "")
            {
                if (currentCount != 1) KorTextBlock1.Text = "① " + currentVoca.ElementAt(1);
                else KorTextBlock1.Text = currentVoca.ElementAt(1);
            }
            else if (KorTextBlock2.Text == "")
            {
                if (currentCount == 1) NextVoca();
                else KorTextBlock2.Text = "② " + currentVoca.ElementAt(2);
            }
            else if (KorTextBlock3.Text == "")
            {
                if (currentCount == 2) NextVoca();
                else KorTextBlock3.Text = "③ " + currentVoca.ElementAt(3);
            }
            else NextVoca();
        }

        private void NextVoca()
        {
            // 암기했는지 확인
            if (ConfirmedChkBox.IsChecked.Value)
            {
                remainCount--;
                RemainCntTextBlock.Text = remainCount.ToString() + " / " + count.ToString();
                confirmedVoca.Add(index);
            }

            // 마지막 인덱스인 경우 초기화
            if (index == randomEntries.Count - 1)
            {
                Start();
                return;
            }

            // 일반적인 경우
            currentVoca = randomEntries.ElementAt(++index);
            EngTextBlock.Text = currentVoca.ElementAt(0);
            MeanCountTextBlock.Text = "";
            KorTextBlock1.Text = "";
            KorTextBlock2.Text = "";
            KorTextBlock3.Text = "";
            ConfirmedChkBox.IsChecked = false;
            if (CountOfMeans(currentVoca) == 2) MeanCountTextBlock.Text = "(두가지 뜻)";
            else if (CountOfMeans(currentVoca) == 3) MeanCountTextBlock.Text = "(세가지 뜻)";
        }

        private int CountOfMeans(List<string> record)
        {
            if (record.ElementAt(2) == null) return 1;
            if (record.ElementAt(3) == null) return 2;
            return 3;
        }

        // 키 누름 이벤트 (키보드 등)
        // 버그 발생 - 두 번째 Day를 수행 중 randomEntries가 null로 됨
        // 키다운 누적으로 판단하고 해결함
        private void CoreWindowKeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if (args.VirtualKey == VirtualKey.PageDown || args.VirtualKey == VirtualKey.Right
                || args.VirtualKey == VirtualKey.Down || args.VirtualKey == VirtualKey.LeftButton)
                Next();
            else if (args.VirtualKey == VirtualKey.Back || args.VirtualKey == VirtualKey.PageUp
                || args.VirtualKey == VirtualKey.Left || args.VirtualKey == VirtualKey.Up)
                Prev();
        }

        public void ConfirmedChkBox_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                // Windows RT의 버그(KeyDown이 중복 발생) 방지 코드
                if (e.KeyStatus.RepeatCount == 1)
                {
                    if (ConfirmedChkBox.IsChecked.Value) ConfirmedChkBox.IsChecked = false;
                    else ConfirmedChkBox.IsChecked = true;
                }
            }
        }

        private async void MessageBoxOpen(string content)
        {
            var dialog = new MessageDialog(content);
            await dialog.ShowAsync();
        }
    }
}
