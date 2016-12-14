using System.Collections.Generic;
using Spectacles.Net.Data;

namespace Spectacles.Net
{
  public interface ISpectaclesExporter
  {
    void OnAddMetadata(Metadata metadata);
    void OnAddGeometries(List<SpectaclesGeometry> geometries);
    void OnAddMaterials(List<SpectaclesMaterial> materials);
    void OnAddSpectacleObject(SpectaclesObject spectaclesObject);
    string ExportToJson(string path);
  }
}
