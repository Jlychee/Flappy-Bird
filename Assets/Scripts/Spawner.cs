using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
		public float timeToSpawn, minYPos, maxYPos;
		private float timer;

		private void Start() {
			timer = timeToSpawn;
		}

		private void Update() {
			if (timer <= 0) {
				timer = timeToSpawn;
				float pos = Random.Range(minYPos, maxYPos);
				GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
				pipe.transform.position = new Vector3(pipe.transform.position.x, pos, 0);
				Destroy(pipe, 3.3f);
			}
			else {
				timer -= Time.deltaTime;
			}
		}
}
