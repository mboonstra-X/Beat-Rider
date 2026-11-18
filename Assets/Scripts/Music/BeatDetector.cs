using UnityEngine;

public class BeatDetector : MonoBehaviour
{
    public MusicManager musicManager;
    public GameObject obstacleSpawner;
    public MidiReader midiReader;

    private ObstacleSpawner spawner;
    private int nextNoteIndex = 0;

    void Start()
    {
        spawner = obstacleSpawner.GetComponent<ObstacleSpawner>();

        if (!midiReader.LoadMidi())
        {
            enabled = false;
        }
    }

    void Update()
    {
        if (!musicManager.music.isPlaying)
            return;

        double time = musicManager.SongTime;

        while (nextNoteIndex < midiReader.notes.Count)
        {
            MidiNoteData note = midiReader.notes[nextNoteIndex];

            if (time < note.time)
                break;

            // Pitch 38 = spike, pitch 37 = normal
            bool isSpike = note.pitch == 38;

            spawner.SpawnObstacle(isSpike);

            nextNoteIndex++;
        }
    }
}
