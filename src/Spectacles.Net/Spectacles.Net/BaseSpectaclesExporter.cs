using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Spectacles.Net.Data;

namespace Spectacles.Net
{
  /// <summary>
  /// An abstract base exporter class that holds an instance of the 
  /// SpectaclesContainer class and provides hooks to attach data to
  /// the properties of the Spectacles container. The class should be
  /// extended by individual exporters, providing custom implementations
  /// and logic that is unique to the individual application platforms.
  /// </summary>
  public abstract class BaseSpectaclesExporter : ISpectaclesExporter
  {
    private readonly SpectaclesContainer _container;

    protected BaseSpectaclesExporter()
    {
      _container = new SpectaclesContainer
      {
        metadata = new Metadata(),
        geometries = new List<SpectaclesGeometry>(),
        materials = new List<SpectaclesMaterial>(),
        obj = new SpectaclesObject()
      };
    }

    /// <summary>
    /// Provides Metadata object to add additional information
    /// </summary>
    /// <param name="metadata">A Metadata instance</param>
    public abstract void OnAddMetadata(Metadata metadata);

    /// <summary>
    /// Provides SpectaclesGeometry list to add geometry to
    /// </summary>
    /// <param name="spectaclesGeometries">List of SpectaclesGeometry objects</param>
    public abstract void OnAddGeometries(List<SpectaclesGeometry> spectaclesGeometries);

    /// <summary>
    /// Provides SpectaclesMaterial list to add materials to
    /// </summary>
    /// <param name="spectaclesMaterials">List of SpectaclesMaterial objects</param>
    public abstract void OnAddMaterials(List<SpectaclesMaterial> spectaclesMaterials);


    /// <summary>
    /// Provides SpectaclesObject to add scene objects to
    /// </summary>
    /// <param name="spectaclesObject">A SpectaclesObject instance</param>
    public abstract void OnAddSpectacleObject(SpectaclesObject spectaclesObject);

    /// <summary>
    /// Execute JSON serialization
    /// </summary>
    /// <param name="path">File to save JSON to</param>
    /// <returns></returns>
    public virtual string ExportToJson(string path)
    {
      // Execute custom implementations of adding to SpectaclesContainer
      OnAddMetadata(_container.metadata);
      OnAddGeometries(_container.geometries);
      OnAddMaterials(_container.materials);
      OnAddSpectacleObject(_container.obj);

      // Serialize SpectaclesContainer to JSON
      var spectaclesJson = JsonConvert.SerializeObject(_container);
      
      // Write to file
      using (var outputFile = new StreamWriter(path))
      {
        outputFile.Write(spectaclesJson);
      }

      return spectaclesJson;
    }
  }
}
