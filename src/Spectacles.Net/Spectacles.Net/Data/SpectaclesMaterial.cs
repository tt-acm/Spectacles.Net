using System.Runtime.Serialization;

namespace Spectacles.Net.Data
{
  /// <summary>
  ///   Based on MeshPhongMaterial obtained by exporting a cube
  /// </summary>
  public class SpectaclesMaterial
  {
    [DataMember]
    public string uuid { get; set; }

    [DataMember]
    public string name { get; set; }

    [DataMember]
    public string type { get; set; }      // MeshPhongMaterial

    [DataMember]
    public string color { get; set; }        // 16777215

//    [DataMember]
//    public int ambient { get; set; }      //16777215
//
//    [DataMember]
//    public int emissive { get; set; }     // 1

    [DataMember]
    public double opacity { get; set; }   // 1

    [DataMember]
    public bool transparent { get; set; } // false

    [DataMember]
    public bool wireframe { get; set; }   // false

//    [DataMember]
//    public int shading { get; set; }      // 1
    [DataMember]
    public int side { get; set; }
  }
}