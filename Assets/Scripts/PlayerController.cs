using UnityEngine;

public class PlayerController : MonoBehaviour
{	
	public float speed;
	private Rigidbody2D rb;
	public BirdAnimation birdAnimation;

	private void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			rb.velocity = new Vector2(rb.velocity.x, speed);
			birdAnimation.StartRotation();
		}
		birdAnimation.ApplyRotation(rb.velocity.x);
	}
}
