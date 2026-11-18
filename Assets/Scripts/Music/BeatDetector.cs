using UnityEngine;

public class BeatDetector : MonoBehaviour
{
    public MusicManager musicManager;
    public MidiReader midiReader;

    public NoteSpawner noteSpawner;
    public ObstacleSpawner obstacleSpawner;

    private float carSpawnTimer = 0f;
    public float carSpawnInterval = 3f;

    private int nextNoteIndex = 0;

    void Start()
    {
        if (!midiReader.LoadMidi())
        {
            enabled = false;
        }
    }

    void Update()
    {
        double time = musicManager.SongTime;

        while (nextNoteIndex < midiReader.notes.Count)
        {
            MidiNoteData note = midiReader.notes[nextNoteIndex];

            if (time < note.time)
                break;

            StartCoroutine(noteSpawner.SpawnNote());

            nextNoteIndex++;
        }

        if (musicManager.music.isPlaying)
        {
            carSpawnTimer += Time.deltaTime;

            if (carSpawnTimer >= carSpawnInterval)
            {
                obstacleSpawner.SpawnCar();
                carSpawnTimer = 0f;
            }
        }
    }
}
