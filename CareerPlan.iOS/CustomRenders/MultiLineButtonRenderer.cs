using CareerPlan.Custom;
using CareerPlan.iOS.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MultiLineButton), typeof(MultiLineButtonRenderer))]
namespace CareerPlan.iOS.CustomRenders
{
    public class MultiLineButtonRenderer : ButtonRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TitleLabel.LineBreakMode = UIKit.UILineBreakMode.WordWrap;
                Control.TitleLabel.TextAlignment = UIKit.UITextAlignment.Center;
            }
        }

    }
}
