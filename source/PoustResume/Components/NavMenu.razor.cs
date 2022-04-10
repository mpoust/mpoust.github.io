using PoustResume.SharedData;
using PoustResume.UI_Models;

namespace PoustResume.Components;

/// <summary>
///     Partial class providing logic for the NavMenu component
/// </summary>
public partial class NavMenu
{
    /// <summary>
    ///     The list of items displayed in the menu bar
    /// </summary>
    List<MenuItemModel>? MenuItems { get; set; }

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
        MenuItems = new NavigationData().MenuItems;
    }
}
