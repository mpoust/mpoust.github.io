using Microsoft.AspNetCore.Components;

namespace PoustResume.Components.Resume.WhatIDo;

/// <summary>
///     Partial class providing logic for the Flip Card templated component
/// </summary>
public partial class FlipCardComponent
{
    /// <summary>
    ///     Route to send the on-click action of the Flip Card back
    /// </summary>
    [Parameter]
    public string NavigationRoute { get; set; }

    /// <summary>
    ///     Template to display on the front of the flip card
    /// </summary>
    [Parameter]
    public RenderFragment FrontTemplate { get; set; }

    /// <summary>
    ///     Template to display on the back of the flip card
    /// </summary>
    [Parameter]
    public RenderFragment BackTemplate { get; set; }


    /// <summary>
    ///     Navigate to the Route provided as component parameter
    /// </summary>
    /// <param name="navRoute"></param>
    void NavigateOnClick()
    {
        NavManager.NavigateTo($"/{NavigationRoute}");
    }

}
