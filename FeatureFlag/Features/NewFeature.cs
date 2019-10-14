using RimDev.AspNetCore.FeatureFlags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureFlag.Features
{
    public class NewFeature : Feature
    {
        // Optional, displays on UI:
        public override string Description { get; } = "My feature description.";
    }
}
