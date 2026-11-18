using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Load the Easy Scene
    public void EasyButton()
    {
        SceneManager.LoadScene("EasyScene");
    }
    // Load the Medium Scene
    public void MediumButton()
    {
        SceneManager.LoadScene("MediumScene");
    }

    // Load the Pretty Hard Scene
    public void PrettyHardButton()
    {
        SceneManager.LoadScene("PrettyHardScene");
    }
    // Load the Hard Scene
    public void HardButton() 
    {
        SceneManager.LoadScene("HardScene");
    }
}