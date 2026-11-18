using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;

public class MidiReader : MonoBehaviour
{
    public string midiFileName = "";

    public List<MidiNoteData> notes = new List<MidiNoteData>();

    public bool LoadMidi()
    {
        string path = Path.Combine(
            Application.streamingAssetsPath,
            midiFileName
        );

        if (!File.Exists(path))
        {
            Debug.LogError("MIDI file not found: " + path);
            return false;
        }

        notes.Clear();

        MidiFile midiFile = MidiFile.Read(path);
        var tempoMap = midiFile.GetTempoMap();

        foreach (var note in midiFile.GetNotes())
        {
            double time = note.TimeAs<MetricTimeSpan>(tempoMap).TotalSeconds;

            notes.Add(new MidiNoteData
            {
                time = time,
                pitch = note.NoteNumber
            });
        }

        notes.Sort((a, b) => a.time.CompareTo(b.time));

        Debug.Log("MIDI loaded! Notes found: " + notes.Count);

        return true;
    }
}

[System.Serializable]
public class MidiNoteData
{
    public double time;
    public int pitch;
}
