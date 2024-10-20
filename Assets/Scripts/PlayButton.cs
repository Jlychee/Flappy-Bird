using UnityEngine;

public class PlayButton : MonoBehaviour
{
		[SerializeField] private Behaviour[] FloorMove;
    [SerializeField] private GameObject character;
		[SerializeField] private GameObject score_text;
		[SerializeField] private GameObject move_script;
		[SerializeField] private GameObject pause_button;
		[SerializeField] private Behaviour bg;
		[SerializeField] private GameObject spawner;


		public void OnButtonPlay() {
			score_text.gameObject.SetActive(true);
			character.gameObject.SetActive(true);
			move_script.gameObject.SetActive(true);
			spawner.gameObject.SetActive(true);
			pause_button.gameObject.SetActive(false);
			bg.enabled = true;
			FloorMove[0].enabled = true;
			FloorMove[1].enabled = true;
		}
}
