﻿using Android.App;
using Android.Os;
using Dot42;
using Dot42.Manifest;

[assembly: Application("dot42 Hello World Sample")]

namespace HelloWorld
{
    [Activity(Icon = "Icon", Label = "dot42 Hello World!")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstance)
        {
            base.OnCreate(savedInstance);
            SetContentView(R.Layouts.MainLayout);
        }
    }
}
