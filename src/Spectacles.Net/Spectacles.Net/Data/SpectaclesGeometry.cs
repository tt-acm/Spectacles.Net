using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Spectacles.Net.Data
{
  [DataContract]
  public class SpectaclesGeometry
  {
    [DataMember]
    public string uuid { get; set; }

    [DataMember]
    public string type { get; set; } // "Geometry"

    [DataMember]
    public SpectaclesGeometryData data { get; set; }

    // [DataMember]
    // public double scale { get; set; }

    [DataMember]
    public List<SpectaclesMaterial> materials { get; set; }
  }
}