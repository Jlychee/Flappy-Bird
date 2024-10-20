using UnityEngine;
using UnityEngine.UI;

public class LoseScore : MonoBehaviour
{
		private int score;
    private Text ScoreText;

		private void Start() {
			score = Score_text.score;
			ScoreText = GetComponent<Text>();
			ScoreText.text = "Score " + score.ToString();
			Score_text.score = 0;
		}
}
