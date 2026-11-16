using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    // Quit Button
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    // Play Button
    public void PlayButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
