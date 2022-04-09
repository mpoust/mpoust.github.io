namespace PoustResume.Components;

/// <summary>
///     Partial class providing logic for the NotFoundComponent
/// </summary>
public partial class NotFoundComponent
{
    /// <summary>
    ///     Navigate to the Home Page from the NotFoundComponent
    /// </summary>
    void NavigateHome()
    {
        NavManager.NavigateTo("/");
    }
}
