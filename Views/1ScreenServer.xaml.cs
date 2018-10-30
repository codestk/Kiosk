using System;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IntelligentKioskSample.Views
{
    [KioskExperience(Title = "Mall Kiosk", ImagePath = "ms-appx:/Assets/mall.png", ExperienceType = ExperienceType.Kiosk)]
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class _1ScreenServer : Page
    {
        public _1ScreenServer()
        {
            this.InitializeComponent();
            EnterKioskMode();
        }

        private void EnterKioskMode()
        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            if (!view.IsFullScreenMode)
            {
                view.TryEnterFullScreenMode();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void LoadEmbeddedAppFile()
        {
            try
            {
                Uri pathUri = new Uri("ms-appx:///Assets/Mp4/Demo.mkv");
                //mediaPlayer.Source = MediaSource.CreateFromUri(pathUri);
                mediaPlayer.Source = pathUri;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception.
                    // For example: Log error or notify user problem with file
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadEmbeddedAppFile();
            // Create the playback item
            // var source = MediaSource.CreateFromUri(rootPage.CaptionedMediaUri);
            // msLogger = new MediaSourceLogger(LoggerControl, source);

            //  mpiLogger = new MediaPlaybackItemLogger(LoggerControl, playbackItem);

            // Turn on English captions by default
            //playbackItem.TimedMetadataTracksChanged += (item, args) =>
            //{
            //if (args.CollectionChange == CollectionChange.ItemInserted)
            //{
            //  //  LoggerControl.Log($"TimedMetadataTracksChanged, Number of tracks: {item.TimedMetadataTracks.Count}");

            //    uint changedTrackIndex = args.Index;
            //    TimedMetadataTrack changedTrack = playbackItem.TimedMetadataTracks[(int)changedTrackIndex];

            //    if (changedTrack.Language == "en")
            //    {
            //        playbackItem.TimedMetadataTracks.SetPresentationMode(changedTrackIndex, TimedMetadataTrackPresentationMode.PlatformPresented);
            //    }
            //}
            //};

            // Set the source to begin playback of the item
            //this.mediaPlayerElement.Source = playbackItem;
            //LoggerControl.Log($"Loaded: {rootPage.CaptionedMediaUri}");
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // msLogger?.Dispose();
            //  msLogger = null;
            //  mpiLogger?.Dispose();
            //  mpiLogger = null;
            //  MediaPlayerHelper.CleanUpMediaPlayerSource(mediaPlayerElement.MediaPlayer);
        }

        private DispatcherTimer timer;

        private void scrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();

            timer.Tick += (ss, ee) =>
            {
                if (timer.Interval.Ticks == 300)
                {
                   

                    //each time set the offset to scrollviewer.HorizontalOffset + 5
                    scrollviewer.ScrollToHorizontalOffset(scrollviewer.HorizontalOffset + 2);
                    //if the scrollviewer scrolls to the end, scroll it back to the start.
                    if (scrollviewer.HorizontalOffset == (scrollviewer.ScrollableWidth))
                    {
                       
                        scrollviewer.ScrollToHorizontalOffset(0);
                    }
                }
            };
            timer.Interval = new TimeSpan(300);
            timer.Start();
        }

        private void scrollviewer_Unloaded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}