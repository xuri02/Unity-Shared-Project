using UnityEngine;

namespace XTCode.Terrain {
    public class MapDisplay : MonoBehaviour {
        public Renderer     textureRender;
        public MeshFilter   meshFilter;
        public MeshRenderer meshRenderer;

        public void DrawTexture(Texture2D texture) {
            this.textureRender.sharedMaterial.mainTexture = texture;
            this.textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);
        }

        public void DrawMesh(MeshData meshDate) {
            this.meshFilter.sharedMesh = meshDate.CreateMesh();
            meshFilter.transform.localScale = Vector3.one * FindObjectOfType<MapGenerator>().terrainData.uniformScale;
        }
    }
}