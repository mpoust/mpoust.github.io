﻿using PoustResume.UI_Models;

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
                Url = "/projects",
                TelerikIcon = "csproj"
            },
            new MenuItemModel()
            {
                Text = "Have an Idea?",
                Url = "/contracting",
                TelerikIcon = "exclamation-circle"
            },
            new MenuItemModel()
            {
                Text = "Contact",
                TelerikIcon = "question-circle",
                Items = new List<MenuItemModel>()
                {
                    new MenuItemModel()
                    {
                        Text = "About Michael",
                        Url = "/about-me",
                        TelerikIcon = "info-circle"
                    },
                    new MenuItemModel()
                    {
                        Text = "Independent Contracting",
                        Url = "/contracting",
                        TelerikIcon = "exclamation-circle"
                    },
                    new MenuItemModel()
                    {
                        Text = "LinkedIn",
                        Url = "https://www.linkedin.com/in/michael-poust/",
                        TelerikIcon = "linkedin-box"
                    },
                    new MenuItemModel()
                    {
                        Text = "GitHub",
                        Url = "https://github.com/mpoust"
                    }
                }
            },
            new MenuItemModel()
            {
                Text = "Resume",
                TelerikIcon = "file-pdf"
                // TODO: Link to open Resume in new tab
            }
        };
    }
}