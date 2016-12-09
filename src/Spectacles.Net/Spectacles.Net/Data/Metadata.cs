using System.Runtime.Serialization;

namespace Spectacles.Net.Data
{
  public class Metadata
  {
    [DataMember]
    public string type { get; set; }      // "Object"

    [DataMember]
    public double version { get; set; }   // 4.3

    [DataMember]
    public string generator { get; set; } // "Spectacles.RevitExporter Revit Spectacles exporter"
  }
}