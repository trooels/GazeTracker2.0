﻿#pragma checksum "..\..\..\..\Calibration\SharingControlUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D53F32AB3CE81E59D17FAE1BFC04ECB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GazeGUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GazeTrackerUI.CalibrationUI {
    
    
    /// <summary>
    /// SharingControlUC
    /// </summary>
    public partial class SharingControlUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GazeTrackerUI.CalibrationUI.SharingControlUC UserControl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridSharing;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectBG_Copy;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBarSharing;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Calibration\SharingControlUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GazeGUI.ButtonGlass BtnSharingCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GazeTrackerUI;component/calibration/sharingcontroluc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Calibration\SharingControlUC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((GazeTrackerUI.CalibrationUI.SharingControlUC)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.GridSharing = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.RectBG_Copy = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.ProgressBarSharing = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            this.BtnSharingCancel = ((GazeGUI.ButtonGlass)(target));
            
            #line 48 "..\..\..\..\Calibration\SharingControlUC.xaml"
            this.BtnSharingCancel.ButtonAction += new System.Windows.RoutedEventHandler(this.ShareDataCancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

