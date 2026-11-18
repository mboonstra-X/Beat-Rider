using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;
    public float startDelay = 0f;

    public double SongTime
    {
        get
        {
            return Time.timeSinceLevelLoad;
        }
    }

    void Start()
    {
        StartCoroutine(StartMusic());
    }

    IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(startDelay);

        music.volume = 1f;
        music.Play();

        yield return new WaitWhile(() => music.isPlaying);

        SceneManager.LoadScene("EndScene");
    }
}