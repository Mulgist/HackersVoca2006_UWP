using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using HackersVoca2006Data;

namespace HackersVoca2006
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            // 나중에 이것은 앱 설치 후 초기작업으로써만 수행할 수 있도록 해야 함.
            Database.InitializeDatabase();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // 이전에 일시 중지된 응용 프로그램에서 상태를 로드합니다.
                }

                // 현재 창에 프레임 넣기
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // 탐색 스택이 복원되지 않으면 첫 번째 페이지로 돌아가고 필요한 정보를 탐색 매개 변수로 전달하여 새 페이지를 구성합니다.
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // 현재 창이 활성 창인지 확인
                Window.Current.Activate();
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            // 응용 프로그램 상태를 저장하고 백그라운드 작업을 모두 중지합니다.
            deferral.Complete();
        }
    }
}
