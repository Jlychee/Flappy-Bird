using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame() {
			SceneManager.LoadScene("Game");
		}

		public void GoToMenu() {
			SceneManager.LoadScene("StartMenu");
		}
}
