using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using HackersVoca2006Data;
using Windows.Storage;

namespace HackersVoca2006
{
    sealed partial class App : Application
    {
        // 로컬 앱 세팅 데이터 폴더 검색
        public static ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            // 앱 첫 실행때만 데이터베이스 초기 작업을 수행한다.
            // 데이터베이스 내용이 수정이 일어나면 앱을 삭제하고 다시 설치해야 한다.
            if (localSettings.Values["firstrun"] == null)
            {
                Database.InitializeDatabase();
                localSettings.Values["firstrun"] = true;
            }
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
