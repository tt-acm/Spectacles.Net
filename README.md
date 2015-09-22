# Spectacles.Net
__A .Net library to standardize [Spectacles](http://core.thorntontomasetti.com/apps/Spectacles/) exporter development.__  


At the moment, the two Spectacles exporters for [Grasshopper](https://github.com/tt-acm/Spectacles.GrasshopperExporter) and [Revit](https://github.com/tt-acm/Spectacles.RevitExporter) each contain code to serialize geometry into .json files that can be loaded by the Spectacles Viewer, and they do so in slightly different ways.  We should standardize and refactor that code into a shared library that can be referenced by all Spectacles exporters to eliminate duplicate code bases, and to standardize the way geometry is serialized into Spectacles.json files.   


Standardization will not only help the quality of the exporters, I think it will dramatically improve the stability and cleanliness of the viewer.  A peek at [this bit of code](https://github.com/tt-acm/Spectacles.WebViewer/blob/gh-pages/js/SPECTACLES.js#L973-L989) will help illustrate the current issue:

```javascript
//function to traverse materials in the scene when deep updates are needed - fog on off/ shadows on / off, etc
SPECT.lightingRig.updateSceneMaterials = function () {
    SPECT.scene.traverse(function (child) {
        if (child instanceof THREE.Mesh) {
            child.material.needsUpdate = true;
        }
        else if (child.type === 'Object3D') {
            try {
                for (var i = 0; i < child.children.length; i++) {
                      for (var j = 0; j < child.children[i].children.length; j++) {
                        child.children[i].children[j].material.needsUpdate = true;
                    }
                }
            } catch (e) { }
        }
    });
};
```  

The Grasshopper Exporter creates THREE.mesh objects, and the Revit Exporter creates THREE.object3d objects, which contain children THREE.mesh objects.  

We currently carry a ton of ugly viewer code to deal with this discrepency, and if the exporters were using a shared Spectacles.Net library to handle geometry serialization, all of that could be eliminated.  Of course this problem will only get worse as more exporters are developed, so we'd like to nip it in the bud now if possible!

