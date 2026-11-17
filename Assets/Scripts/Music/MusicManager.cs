
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;
    public float bpm = 120f;

    public double SongTime
    {
        get
        {
            return music.time;
        }
    }

    public float BeatInterval
    {
        get
        {
            return 60f / bpm;
        }
    }

    void Start()
    {
        music.Play();
    }
}
