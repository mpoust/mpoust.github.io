namespace PoustResume.UI_Models;

/// <summary>
///     Model for displaying skills in a Carousel
/// </summary>
public class SkillCarouselModel
{
    /// <summary>
    ///     ID for the tab of the Carousel
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Title of the Skill in the Carousel
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     Level of the skill to display in the gauge
    /// </summary>
    public double? SkillLevel { get; set; }
}
