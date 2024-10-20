using UnityEngine;

public class FloorMove : MonoBehaviour
{
    public float StartX;
		public float EndX;

		private void Update() {
			if (transform.position.x < EndX) {
				transform.position = new Vector2(StartX, transform.position.y);
			}
		}
}
