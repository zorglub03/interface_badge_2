using Avalonia.Controls;

namespace interface_badge_2.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChangePage()
        {
            if(viewer.IsVisible == true)
            {
                viewer.IsVisible = false;
                manager.IsVisible = true;
                addButton.IsVisible = true;
                modButton.IsVisible = true;
                menuHomePage.IsEnabled = true;
                menuManager.IsEnabled = false;
            }
            else if(manager.IsVisible == true) 
            {
                manager.IsVisible = false;
                viewer.IsVisible = true;
                addButton.IsVisible = false;
                modButton.IsVisible = false;
                menuHomePage.IsEnabled = false;
                menuManager.IsEnabled = true;
            }
        }
    }
}
