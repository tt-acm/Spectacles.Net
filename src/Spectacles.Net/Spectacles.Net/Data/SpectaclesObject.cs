using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Spectacles.Net.Data
{
  [DataContract]
  public class SpectaclesObject
  {
    [DataMember]
    public string uuid { get; set; }

    [DataMember]
    public string name { get; set; }     // BIM <document name>

    [DataMember]
    public string type { get; set; }     // Object3D

    [DataMember]
    public double[] matrix { get; set; } // [1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1]

    [DataMember]
    public List<SpectaclesObject> children { get; set; }

    // The following are only on the children:

    [DataMember]
    public string geometry { get; set; }

    [DataMember]
    public string material { get; set; }

    //[DataMember] public List<double> position { get; set; }
    //[DataMember] public List<double> rotation { get; set; }
    //[DataMember] public List<double> quaternion { get; set; }
    //[DataMember] public List<double> scale { get; set; }
    //[DataMember] public bool visible { get; set; }
    //[DataMember] public bool castShadow { get; set; }
    //[DataMember] public bool receiveShadow { get; set; }
    //[DataMember] public bool doubleSided { get; set; }

    [DataMember]
    public Dictionary<string, string> userData { get; set; }
  }
}