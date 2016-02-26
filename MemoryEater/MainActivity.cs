using System;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MemoryEater
{
    [Activity(Label = "MemoryEater", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Timer _timer;
        private FauxService _service;
        private TextView _textView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);
            
            _textView = FindViewById<TextView>(Resource.Id.MyText);
            _service = new FauxService();

            FindViewById<Button>(Resource.Id.MyButton).Click += (sender, args) =>
            {
                _timer = new Timer(50);
                _timer.Elapsed += TimerOnElapsed;
                _timer.Start();
            };

            FindViewById<Button>(Resource.Id.MyButton2).Click += (sender, args) => _timer?.Stop();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            _timer.Stop();

            _service.GetThing()
                .ContinueWith(data =>
                {
                    GC.Collect();
                    RunOnUiThread(() =>
                    {
                        _textView.Text = data.Result.Thing1.Foo;
                        _textView.SetTextColor(data.Result.Thing1.Baz ? Color.Red : Color.Green);
                        _timer.Start();
                    });
                });

        }
    }
}

