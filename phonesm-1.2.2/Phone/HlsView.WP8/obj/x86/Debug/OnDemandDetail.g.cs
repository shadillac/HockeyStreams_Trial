﻿#pragma checksum "C:\Users\shmorris\Documents\GitHub\HockeyStreams_Trial\phonesm-1.2.2\Phone\HlsView.WP8\OnDemandDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D20039AD8FE439282A6A3F309C1E0CA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace HlsView {
    
    
    public partial class OnDemandDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock awayText;
        
        internal System.Windows.Controls.TextBlock atText;
        
        internal System.Windows.Controls.TextBlock homeText;
        
        internal System.Windows.Controls.TextBlock txtGameTime;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Top%20Cheddar%20Hockey%20Streams;component/OnDemandDetail.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.awayText = ((System.Windows.Controls.TextBlock)(this.FindName("awayText")));
            this.atText = ((System.Windows.Controls.TextBlock)(this.FindName("atText")));
            this.homeText = ((System.Windows.Controls.TextBlock)(this.FindName("homeText")));
            this.txtGameTime = ((System.Windows.Controls.TextBlock)(this.FindName("txtGameTime")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
        }
    }
}

