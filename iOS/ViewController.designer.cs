// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Hex2RGB.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView colorView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton convertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbBlue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbGreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbRed { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfHexValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (colorView != null) {
                colorView.Dispose ();
                colorView = null;
            }

            if (convertButton != null) {
                convertButton.Dispose ();
                convertButton = null;
            }

            if (lbBlue != null) {
                lbBlue.Dispose ();
                lbBlue = null;
            }

            if (lbGreen != null) {
                lbGreen.Dispose ();
                lbGreen = null;
            }

            if (lbRed != null) {
                lbRed.Dispose ();
                lbRed = null;
            }

            if (tfHexValue != null) {
                tfHexValue.Dispose ();
                tfHexValue = null;
            }
        }
    }
}