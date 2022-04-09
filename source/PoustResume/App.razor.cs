namespace PoustResume;

/// <summary>
///     Partial class providing logic for the primary App.razor component
/// </summary>
public partial class App
{
    /// <summary>
    ///     Component initialization
    /// </summary>
    protected override void OnInitialized()
    {
        DeviceState.StateChanged += OnDeviceStateAdvancedStateChanged;

        base.OnInitialized();
    }

    /// <summary>
    ///     Subscribe to the DeviceState object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void OnDeviceStateAdvancedStateChanged(object sender, EventArgs e) => StateHasChanged();

    /// <summary>
    ///     Dispose of the subscription to DeviceState
    /// </summary>
    void IDisposable.Dispose() => DeviceState.StateChanged -= OnDeviceStateAdvancedStateChanged;
}
