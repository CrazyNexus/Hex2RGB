using System;

using UIKit;

namespace Hex2RGB.iOS
{
   public partial class ViewController : UIViewController
   {

      public ViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         convertButton.TouchUpInside += ConvertButton_TouchUpInside;
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.      
      }

      //

      void ConvertButton_TouchUpInside(object sender, EventArgs e)
      {
         string hexValue = tfHexValue.Text;
         string redHexValue = hexValue.Substring(0, 2);
         string greenHexValue = hexValue.Substring(2, 2);
         string blueHexValue = hexValue.Substring(4, 2);

         int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
         int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
         int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

         lbRed.Text = redValue.ToString();
         lbGreen.Text = greenValue.ToString();
         lbBlue.Text = blueValue.ToString();

         colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
      }
   }
}
