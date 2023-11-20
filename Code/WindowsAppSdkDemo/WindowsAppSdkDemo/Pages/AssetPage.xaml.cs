using Comentsys.Assets.Flags;
using Comentsys.Assets.FluentEmoji;
using Comentsys.Assets.Games;
using Comentsys.Toolkit.WindowsAppSdk;
using Microsoft.UI.Xaml.Controls;
using WindowsAppSdkDemo.Enums;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsAppSdkDemo.Pages;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class AssetPage : Page
{
    public AssetPage() =>
        this.InitializeComponent();

    private async void Emoji_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (FluentEmojiSet?.SelectedValue != null && FluentEmojiType?.SelectedValue != null)
        {
            var set = (FluentEmojiSet)FluentEmojiSet.SelectedValue;
            var type = (FluentEmojiType)FluentEmojiType.SelectedValue;
            var source = set switch
            {
                Enums.FluentEmojiSet.Contrast => await ContrastFluentEmoji.Get(type).AsImageSourceAsync(),
                Enums.FluentEmojiSet.Shaded => await ShadedFluentEmoji.Get(type).AsImageSourceAsync(),
                _ => await FlatFluentEmoji.Get(type).AsImageSourceAsync(),
            };
            if (EmojiImage != null)
            {
                EmojiImage.Source = source;
            }
        }
    }

    private async void Flag_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (FlagSet?.SelectedValue != null && FlagType?.SelectedValue != null)
        {
            var set = (FlagSet)FlagSet.SelectedValue;
            var type = (FlagType)FlagType.SelectedValue;
            var source = await Flag.Get(set, type).AsImageSourceAsync();
            if (FlagImage != null)
            {
                FlagImage.Source = source;
            }
        }
    }

    private async void Chess_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ChessPieceSet?.SelectedValue != null && ChessPieceType?.SelectedValue != null)
        {
            var set = (ChessPieceSet)ChessPieceSet.SelectedValue;
            var type = (ChessPieceType)ChessPieceType.SelectedValue;
            var source = await ChessPiece.Get(set, type).AsImageSourceAsync();
            if (ChessImage != null)
            {
                ChessImage.Source = source;
            }
        }
    }

    private async void Mahjong_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (MahjongTileType?.SelectedValue != null)
        {
            var type = (MahjongTileType)MahjongTileType.SelectedValue;
            var source = await MahjongTile.Get(type).AsImageSourceAsync();
            if (MahjongImage != null)
            {
                MahjongImage.Source = source;
            }
        }
    }
}