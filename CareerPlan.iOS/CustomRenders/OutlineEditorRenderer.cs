using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CareerPlan.Custom;
using CareerPlan.iOS.CustomRenders;

[assembly: ExportRenderer(typeof(OutlineEditor), typeof(OutlineEditorRenderer))]
namespace CareerPlan.iOS.CustomRenders
{
    public class OutlineEditorRenderer : EditorRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextContainerInset = new UIKit.UIEdgeInsets(10, 7, 10, 7);
                Control.BackgroundColor = Color.Transparent.ToUIColor();
                Control.Layer.CornerRadius = 4;
                Control.Layer.BorderWidth = 1;
                Control.Layer.BorderColor = Color.FromHex("b3b3b3").ToCGColor();
            }
        }

    }
}
