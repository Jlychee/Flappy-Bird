using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Score_text _actionTarget;
	[SerializeField] private GameObject ScoreObj;

	private void Start() {
		_actionTarget = ScoreObj.GetComponent<Score_text>();
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name != "score_block") {
			SceneManager.LoadScene("GameOver");
		}
		else if (other.gameObject.name == "Character") {
			SceneManager.LoadScene("GameOver");
		}
		else {
			_actionTarget.ScoreChange();
		}
	}
}
