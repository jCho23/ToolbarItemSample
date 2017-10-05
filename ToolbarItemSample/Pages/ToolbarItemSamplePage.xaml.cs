using Xamarin.Forms;

namespace ToolbarItemSample
{
    public partial class ToolbarItemSamplePage : ContentPage
    {
        public ToolbarItemSamplePage()
        {
            InitializeComponent();
        }

        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EmptyListPage());
        }
    }
}
