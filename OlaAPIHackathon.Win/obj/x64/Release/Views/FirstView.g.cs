﻿

#pragma checksum "D:\OlaAPIHackathon\OlaAPIHackathon\OlaAPIHackathon.Win\Views\FirstView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F83DD13A7009A7490F21511BD8B8491"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlaAPIHackathon.Win.Views
{
    partial class FirstView : global::Cirrious.MvvmCross.WindowsCommon.Views.MvxWindowsPage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 83 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TrackRide;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 84 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CancelRide;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 64 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.MapObj_Loaded;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 59 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BookNow;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 50 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.GetMiniAvailability;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 46 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.GetPrimeAvailability;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 42 "..\..\..\Views\FirstView.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.GetSedanAvailability;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


