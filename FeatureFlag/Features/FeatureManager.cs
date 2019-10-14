using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FeatureFlag.Features
{
    public class FeatureManager : IFeatureManager
    {
        private readonly string filePath;
        private readonly string jsonfile;
        private readonly JObject jsonObject;

        public FeatureManager() {
            filePath = @"C:\Repo\FeatureFlag\FeatureFlag\FeatureFlagData.json";
            jsonfile = File.ReadAllText(filePath);
            jsonObject = JObject.Parse(jsonfile);
        }
        public void AddFeature(Feature1 f1) {
            var newFeatureValue=  "{  '" + f1.FeatureName + "': {  'IsEnabled': '" + f1.IsEnabled + "'}}";  
            try
            {
                var Features = GetJArray("Features");
                var newFeature = JObject.Parse(newFeatureValue);
                Features.Add(newFeature);
                jsonObject["Features"] = Features;
                string newJsonResult = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, newJsonResult);
            }
            catch (Exception ex) {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }

        }
        public List<Feature1> RemmoveFeature() {
            throw new NotImplementedException();
        }
        public bool ToggleFeature() {
            throw new NotImplementedException();
        }
        public List<Feature1> FetchFeatures()
        {
            try
            {
                var Features = GetJArray("Features");
                return JsonConvert.DeserializeObject<List<Feature1>>(Features.ToString());
            }
            catch (Exception ex) {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
                return null;
            }
        
        }
        private JArray GetJArray(string propertyName)
        {
            return jsonObject.GetValue(propertyName) as JArray;
        }
    }
}
