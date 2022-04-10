using PoustResume.SharedData;
using PoustResume.UI_Models;
using Telerik.Blazor.Components;

namespace PoustResume.Components.Layouts;

/// <summary>
///     Partial class providing logic for the MobileLayout
/// </summary>
public partial class MobileLayout
{
    /// <summary>
    ///     The list of items displayed in the menu bar
    /// </summary>
    List<MenuItemModel>? MenuItems { get; set; }

    /// <summary>
    ///     Reference to the Drawer used for Mobile Navigation
    /// </summary>
    TelerikDrawer<MenuItemModel> NavDrawerRef { get; set; }

    /// <summary>
    ///     Component Initialization
    /// </summary>
    protected override void OnInitialized()
    {
        GenerateMenuData();
    }

    /// <summary>
    ///     Initialize the menu with data
    /// </summary>
    void GenerateMenuData()
    {
        MenuItems = new NavigationData().GenerateMobileNavigationData().MenuItems;
    }
}
