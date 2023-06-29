using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms.Xaml;

namespace proyectoFinal_DBP
{
    public class PageViewModel : INotifyPropertyChanged
    {
        Stopwatch stopWatch = new Stopwatch();
        private Timer time = new Timer();

        private string stopWatchHours;
        public string StopWatchHours
        {
            get { return stopWatchHours; }
            set
            {
                stopWatchHours = value;
                OnPropertyChanged("StopWatchHours");
            }
        }

        private string stopWatchMinutes;
        public string StopWatchMinutes
        {
            get { return stopWatchMinutes; }
            set
            {
                stopWatchMinutes = value;
                OnPropertyChanged("StopWatchMinutes");
            }
        }

        private string stopWatchSeconds;
        public string StopWatchSeconds
        {
            get { return stopWatchSeconds; }
            set
            {
                stopWatchSeconds = value;
                OnPropertyChanged("StopWatchSeconds");
            }
        }

        public TimeSpan prevTime;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if(changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public PageViewModel()
        {
            stopWatch.Start();
            prevTime = TimeSpan.Zero;

            StopWatchHours=stopWatch.Elapsed.Hours.ToString();
            StopWatchMinutes=stopWatch.Elapsed.Minutes.ToString();
            StopWatchSeconds=stopWatch.Elapsed.Seconds.ToString();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                StopWatchHours = stopWatch.Elapsed.Hours.ToString();
                StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
                StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();
                return true;
            });

        }

        public void SetTime()
        {
            stopWatch.Stop();
            prevTime = stopWatch.Elapsed;
            Preferences.Set("PrevTime", prevTime.ToString());
        }
    }
}
