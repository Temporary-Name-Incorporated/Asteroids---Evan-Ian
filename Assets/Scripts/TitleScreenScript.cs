using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Asteroids");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
