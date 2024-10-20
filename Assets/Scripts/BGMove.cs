using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private float speed;
		private MeshRenderer _meshRenderer;
		private Vector2 _meshOffset;

		private void Start() {
			_meshRenderer = GetComponent<MeshRenderer>();
			_meshOffset = _meshRenderer.sharedMaterial.mainTextureOffset;
		}

		private void OnDisable() {
			_meshRenderer.sharedMaterial.mainTextureOffset = _meshOffset;
		}

		private void Update() {
			var x = Mathf.Repeat(Time.time * speed, 1);
			var offset = new Vector2(x, _meshOffset.y);
			_meshRenderer.sharedMaterial.mainTextureOffset = offset;
		}
}
