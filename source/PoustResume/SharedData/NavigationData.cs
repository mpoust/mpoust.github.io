using PoustResume.UI_Models;

namespace PoustResume.SharedData;

/// <summary>
///     Class to encapsulate shared navigation data that should be used in both
///     Desktop, and Mobile navigation menus.
/// </summary>
public class NavigationData
{
    /// <summary>
    ///     The list of items displayed in the rendered navigation window
    /// </summary>
    public List<MenuItemModel> MenuItems { get; set; }

    /// <summary>
    ///     Constructor with default navigation options, shared across all rendered
    ///     navigation windows
    /// </summary>
    public NavigationData()
    {
        MenuItems = new List<MenuItemModel>()
        {
            new MenuItemModel()
            {
                Text = "Projects",
                Url = "/projects"
            },
            new MenuItemModel()
            {
                Text = "Contact",
                Items = new List<MenuItemModel>()
                {
                    new MenuItemModel()
                    {
                        Text = "LinkedIn",
                        Url = "https://www.linkedin.com/in/michael-poust/"
                    },
                    new MenuItemModel()
                    {
                        Text = "GitHub",
                        Url = "https://github.com/mpoust"
                    },
                    new MenuItemModel()
                    {
                        Text = "Email",
                        Url = "mailto:michael.poust221@gmail.com"
                    }
                }
            },
            new MenuItemModel()
            {
                Text = "Resume"
                // TODO: Link to open Resume in new tab
            }
        };
    }
}
