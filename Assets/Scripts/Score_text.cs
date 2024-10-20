using UnityEngine;
using UnityEngine.UI;


public class Score_text : MonoBehaviour
{
    public static int score = 0;
		public Text ScoreText;

		private void Start() {
			ScoreText = GetComponent<Text>();
		}

		public void ScoreChange() {
			score += 1;
			ScoreText.text = score.ToString();
		}
}
