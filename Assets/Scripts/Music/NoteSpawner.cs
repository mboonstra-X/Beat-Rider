using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;

    public Transform[] lanes;

    public void SpawnNote()
    {
        int randomLane = Random.Range(0, lanes.Length);

        Instantiate(
            notePrefab,
            lanes[randomLane].position,
            lanes[randomLane].rotation
        );
    }
}
