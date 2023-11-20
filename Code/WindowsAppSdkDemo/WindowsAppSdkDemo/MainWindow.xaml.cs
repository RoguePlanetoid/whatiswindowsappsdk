using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsAppSdkDemo;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow() => this.InitializeComponent();

    private void Navigation_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        var selected = (NavigationViewItem)args.SelectedItem;
        if (selected != null)
        {
            Content.Navigate(Type.GetType($"WindowsAppSdkDemo.Pages.{selected.Tag}"));
        }
    }
}
