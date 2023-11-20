using Microsoft.UI.Xaml.Controls;
using WindowsAppSdkDemo.Enums;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsAppSdkDemo.Pages;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class DicePage : Page
{
    public DicePage() => this.InitializeComponent();

    private void Dice_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (DiceValue?.SelectedValue != null)
        {
            var value = (int)(DiceValue)DiceValue.SelectedValue;
            if (Dice != null)
            {
                Dice.Value = value;
            }
        }
    }
}
