// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSBatteryComponent
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGet { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIsLow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLevel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblStatus { get; set; }

        [Action ("BtnGet_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnGet_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnGet != null) {
                btnGet.Dispose ();
                btnGet = null;
            }

            if (lblIsLow != null) {
                lblIsLow.Dispose ();
                lblIsLow = null;
            }

            if (lblLevel != null) {
                lblLevel.Dispose ();
                lblLevel = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }
        }
    }
}