using Android.App;
using Android.OS;
using Android.Renderscripts;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using AndroidX.AppCompat.App;
using Benchmark.Shared;

using System;

namespace Benchmark
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.btnRun);

            button.Click += RunBenchmark;
        }

        private void RunBenchmark(object sender, EventArgs e)
        {
            var javaFunctions = new JavaFunctions();
            BenchmarkCreator.Create("Java sqrt", (i) => javaFunctions.Sqrt(i), 100000);
        }

    }
}