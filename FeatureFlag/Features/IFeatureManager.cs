using System.Collections.Generic;

namespace FeatureFlag.Features
{
    public interface IFeatureManager
    {
        void AddFeature(Feature1 f1);
        List<Feature1> RemmoveFeature();
        bool ToggleFeature();
        List<Feature1> FetchFeatures();
    }
}