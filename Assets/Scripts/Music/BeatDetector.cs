
using UnityEngine;

public class BeatDetector : MonoBehaviour
{
    public MusicManager musicManager;
    public GameObject obstacleSpawner;

    public float spikeThreshold = 0.12f;
    public float spikeCooldown = 0.25f;

    private float[] spectrum = new float[1024];

    private double nextBeat;
    private float previousBass;
    private float cooldown;

    void Start()
    {
        nextBeat = musicManager.BeatInterval;
    }

    void Update()
    {
        if (!musicManager.music.isPlaying)
            return;

        cooldown -= Time.deltaTime;

        double time = musicManager.SongTime;

        // BPM detection
        if (time >= nextBeat)
        {
            spawner.SpawnObstacle(false);

            nextBeat += musicManager.BeatInterval;
        }

        // Bass spike detection
        musicManager.music.GetSpectrumData(
            spectrum, 0, FFTWindow.Blackman
        );

        float bass = 0f;

        for (int i = 1; i < 20; i++)
        {
            bass += spectrum[i];
        }

        float spike = bass - previousBass;

        if (spike > spikeThreshold && cooldown <= 0)
        {
            obstacleSpawner.GetComponent<ObstacleSpawner>().SpawnObstacle(true);
            cooldown = spikeCooldown;
        }

        previousBass = bass;
    }
}
