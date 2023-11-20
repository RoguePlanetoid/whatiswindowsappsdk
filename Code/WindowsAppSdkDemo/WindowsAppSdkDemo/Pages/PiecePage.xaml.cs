using Comentsys.Toolkit.WindowsAppSdk;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsAppSdkDemo.Pages;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class PiecePage : Page
{
    public PiecePage() =>
        this.InitializeComponent();

    private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args) =>
        Piece.Fill = new SolidColorBrush(args.NewColor);

    private void IsSquare_Toggled(object sender, RoutedEventArgs e) =>
        Piece.IsSquare = IsSquare.IsOn;
}
