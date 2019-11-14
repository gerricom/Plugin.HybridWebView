﻿using System;
using Android.Webkit;

namespace Plugin.HybridWebView.Droid
{
    public class FormsWebViewChromeClient : WebChromeClient
    {
        readonly WeakReference<HybridWebViewRenderer> _reference;

        public FormsWebViewChromeClient(HybridWebViewRenderer renderer)
        {
            _reference = new WeakReference<HybridWebViewRenderer>(renderer);
        }
    }
}