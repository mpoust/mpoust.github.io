namespace PoustResume.UI_Models;

/// <summary>
///     Model for constructing Telerik Menu Items.
/// </summary>
public class MenuItemModel
{
    /// <summary>
    ///     Text to display. Leave empty to show icon only.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    ///     ToolTip to show using Telerik ToolTip. Leave empty for no ToolTip.
    /// </summary>
    public string ToolTip { get; set; }

    /// <summary>
    ///     Route to either an internal or external page. Check with <see cref="IsInternalPage(string)"/> to
    ///     determine the link type.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    ///     Name of the TelerikIcon. See <see href="https://docs.telerik.com/blazor-ui/common-features/font-icons#icons-list">Telerik Docs</see>
    ///     for the full Icon list.
    /// </summary>
    public string TelerikIcon { get; set; }

    /// <summary>
    ///     Sub-List of <see cref="MenuItemModel"/> to display under this
    ///     menu item as a nested list.
    /// </summary>
    public List<MenuItemModel> Items { get; set; }

    /// <summary>
    ///     Is this item a separator for sectioning the menu (in a drawer) into 
    ///     multiple sections
    /// </summary>
    public bool IsSeparator { get; set; } = false;

    /// <summary>
    ///     Determines if the link is internal (in-app) or to an external source.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public bool IsInternalPage(string url)
    {
        if (string.IsNullOrEmpty(url)) return false;

        var protocols = new string[] { "//", "http://", "https://" };
        return !protocols.Any(p => url.StartsWith(p.ToLower()));
    }
}
