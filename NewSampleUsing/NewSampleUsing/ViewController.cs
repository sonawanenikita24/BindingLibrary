using Foundation;
using System;
using UIKit;
using MessagePrinterBinder;

namespace NewSampleUsing
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var myclass = new MyClass();

            lblText.Text = myclass.Value;
            // Perform any additional setup after loading the view, typically from a nib.
        }

       
    }
}