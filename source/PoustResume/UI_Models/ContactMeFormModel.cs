namespace PoustResume.UI_Models;

/// <summary>
///     Model to hold the data for submitting a contact me form request
/// </summary>
public class ContactMeFormModel
{
    /// <summary>
    ///     Name of the person submitting the contact request
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Email address of the person submitting the contact request
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    ///     Subject of the contact request
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    ///     Message content for the contact request
    /// </summary>
    public string Message { get; set; }
}
