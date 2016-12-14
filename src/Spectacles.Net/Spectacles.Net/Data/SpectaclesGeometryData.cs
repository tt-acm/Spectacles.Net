using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Spectacles.Net.Data
{
  [DataContract]
  public class SpectaclesGeometryData
  {
    // populate data object properties
    //jason.data.vertices = new object[mesh.Vertices.Count * 3];
    //jason.data.normals = new object[0];
    //jason.data.uvs = new object[0];
    //jason.data.faces = new object[mesh.Faces.Count * 4];
    //jason.data.scale = 1;
    //jason.data.visible = true;
    //jason.data.castShadow = true;
    //jason.data.receiveShadow = false;
    //jason.data.doubleSided = true;


    // https://github.com/mrdoob/three.js/wiki/JSON-Model-format-3

    // for the faces, we will use
    // triangle with material
    // 00 00 00 10 = 2
    // 2, [vertex_index, vertex_index, vertex_index], [material_index]     // e.g.:
    //
    //2, 0,1,2, 0

    [DataMember]
    public List<double> vertices { get; set; } // millimetres
    // "morphTargets": []
    [DataMember]
    public List<double> normals { get; set; }

    // "colors": []
    [DataMember]
    public List<double> uvs { get; set; }

    [DataMember]
    public List<int> faces { get; set; } // indices into Vertices + Materials

    [DataMember]
    public double scale { get; set; }

    [DataMember]
    public bool visible { get; set; }

    [DataMember]
    public bool castShadow { get; set; }

    [DataMember]
    public bool receiveShadow { get; set; }

    [DataMember]
    public bool doubleSided { get; set; }
  }
}