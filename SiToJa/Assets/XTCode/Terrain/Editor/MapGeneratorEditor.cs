using UnityEditor;
using UnityEngine;

namespace XTCode.Terrain.Editor {
    [CustomEditor( typeof(MapGenerator) )]
    public class MapGeneratorEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            MapGenerator mapGen = (MapGenerator) this.target;

            if ( DrawDefaultInspector() ) {
                if ( mapGen.autoUpdate ) mapGen.DrawMapInEditor();
            }

            if ( GUILayout.Button( "Generate" ) ) {
                mapGen.DrawMapInEditor();
            }
        }
    }
}