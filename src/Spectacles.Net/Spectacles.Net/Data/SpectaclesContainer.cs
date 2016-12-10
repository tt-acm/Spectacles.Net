//The MIT License (MIT)

//Those portions created by va3c authors are provided with the following copyright:

//Copyright (c) 2014 va3c

//Those portions created by Thornton Tomasetti employees are provided with the following copyright:

//Copyright (c) 2015 Thornton Tomasetti

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

#region Namespaces

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion // Namespaces

namespace Spectacles.Net.Data
{
  /// <summary>
  /// three.js object class, successor of SpectaclesScene.
  /// The structure and properties defined here were
  /// reverse engineered ftom JSON files exported 
  /// by the three.js and Spectacles editors.
  /// </summary>
  [DataContract]
  public class SpectaclesContainer
  {
    [DataMember]
    public Metadata metadata { get; set; }

    [DataMember( Name = "object" )]
    public SpectaclesObject obj { get; set; }

    [DataMember]
    public List<SpectaclesGeometry> geometries;

    [DataMember]
    public List<SpectaclesMaterial> materials;
  }
}
