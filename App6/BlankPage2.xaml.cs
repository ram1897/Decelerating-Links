using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Device.Location;
using Windows.ApplicationModel.Background;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        public BlankPage2()
        {
            this.InitializeComponent();
        }
        public GeoPosition<GeoCoordinate> Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public GeoPositionStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        //  public event EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>> PositionChanged;
        //public event EventHandler<GeoPositionStatusChangedEventArgs> StatusChanged;
        public async void geospeed(object sender, RoutedEventArgs e)
        {
            var access = await BackgroundExecutionManager.RequestAccessAsync();
            switch (access)
            {
                case BackgroundAccessStatus.Unspecified:
                    break;
                case BackgroundAccessStatus.AllowedMayUseActiveRealTimeConnectivity:
                    break;
                case BackgroundAccessStatus.AllowedWithAlwaysOnRealTimeConnectivity:
                    break;
                case BackgroundAccessStatus.Denied:
                    break;
                default:
                    break;
            }
            var task = new BackgroundTaskBuilder
            {
                Name = "My task",
                //       TaskEntryPoint = typeof(BackgroundStuff.MyBackgroundTask).ToString()
            };
            var trigger = new ApplicationTrigger();
            task.SetTrigger(trigger);
           // var condition = new SystemCondition(SystemConditionType.InternetAvailable);
           // task.Register();
            await trigger.RequestAsync();
            GetLocationCourseAndSpeed();
        }
        public void GetLocationCourseAndSpeed()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watcher.TryStart(true, TimeSpan.FromMilliseconds(3000));
            if (watcher.Position.Location.IsUnknown != true)
            {
                int i = 0;
                if (combobox2.IsEnabled)
                {
                    i = Convert.ToInt32(combobox2.Content);
                }
                else if (comboBox3.IsEnabled)
                {
                    i = Convert.ToInt32(comboBox3.Content);
                }
                else
                {
                    i = Convert.ToInt32(comboBox4.Content);
                }
                GeoCoordinate coord = watcher.Position.Location;
                if (coord.Speed > i)
                {
                    textBlock2.Text = "Slow down your speed to enable communication";
                    Windows.UI.ViewManagement.InputPane.GetForCurrentView().TryHide();
                }
            }
            else
            {
                textBlock2.Text = "you are riding safe";
                Windows.UI.ViewManagement.InputPane.GetForCurrentView().TryShow();
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Start(bool suppressPermissionPrompt)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public bool TryStart(bool suppressPermissionPrompt, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

    }
}
