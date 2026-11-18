using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    // Return to Menu Button
    public void Return2Menu()
    {
        SceneManager.LoadScene("StartScene");
    }


    // Quit Button
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    // Play Button
    public void PlayButton()
    {
        SceneManager.LoadScene("SceneLoader");
    }
}