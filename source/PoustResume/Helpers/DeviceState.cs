namespace PoustResume.Helpers;

/// <summary>
///     Helper class to determine what type of device is accessing the application.
///     <br/><br/>
///     Assists with adjusting the layout according to current device, via TelerikMediaQuery
/// </summary>
public class DeviceState
{
    /// <summary>
    ///     Is the current device a Desktop based on breakpoint? If false
    ///     the device is Tablet or Mobile
    /// </summary>
    private bool _isDesktop = false;

    /// <summary>
    ///     StateChanged is an event handler other pages can subscribe to
    /// </summary>
    public event EventHandler StateChanged;

    /// <summary>
    ///     This method will always return the current device state
    /// </summary>
    /// <returns></returns>
    public bool GetDeviceState()
    {
        return _isDesktop;
    }

    /// <summary>
    ///     This method will allow for assigning a device state based on the
    ///     results of a TelerikMediaQuery
    /// </summary>
    /// <param name="state"></param>
    public void SetDeviceState(bool state)
    {
        _isDesktop = state;
        StateHasChanged();
    }

    /// <summary>
    ///     This method will update any subscribers that the DeviceState has changed. 
    ///     <br/>
    ///     This allows the components to update and handle layout adjustments accordingly.
    /// </summary>
    private void StateHasChanged()
    {
        StateChanged?.Invoke(this, EventArgs.Empty);
    }
}