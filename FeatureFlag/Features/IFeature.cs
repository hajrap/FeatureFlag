namespace FeatureFlag.Features
{
    public interface IFeature
    {
        string FeatureName { get; set; }
        bool IsEnabled { get; set; }
    }
}