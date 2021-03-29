using OverrideSearchBarCancelButtonText.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchBar), typeof(CustomSearchBarRenderer))]
namespace OverrideSearchBarCancelButtonText.iOS.Renderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TextChanged += Control_TextChanged;
            }
        }

        private void Control_TextChanged(object sender, UISearchBarTextChangedEventArgs e)
        {
            if (Control != null)
            {
                UIButton button = GetCancelButton(Control);
                if (button != null)
                {
                    button.SetTitle("Go!", UIControlState.Normal);
                }
                else
                {
                    Control.ShowsCancelButton = false;
                }
            }
        }

        private UIButton GetCancelButton(UIView view)
        {
            if (view.GetType() == typeof(UIButton))
                return view as UIButton;

            if (view.Subviews == null || view.Subviews.Length == 0)
                return null;

            foreach (UIView v in view.Subviews)
            {
                var result = GetCancelButton(v);
                if (result != null)
                    return result;
            }

            return null;
        }
    }
}