using Comentsys.Toolkit.WindowsAppSdk;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsAppSdkDemo.Pages;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class SectorPage : Page
{
    public SectorPage() => this.InitializeComponent();

    private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args) =>
        Sector.Fill = new SolidColorBrush(args.NewColor);

    private void RangeSelector_ValueChanged(object sender, CommunityToolkit.WinUI.UI.Controls.RangeChangedEventArgs e)
    {
        Sector.Start = Range.RangeStart;
        Sector.Finish = Range.RangeEnd;
    }
}
