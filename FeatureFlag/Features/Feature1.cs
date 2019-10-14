using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FeatureFlag.Features
{
    [DataContract]
    public class Feature1 : IFeature
    {
        [DataMember]
        public string FeatureName { get; set; }
        [DataMember]
        public bool IsEnabled { get; set; }
    }
}
