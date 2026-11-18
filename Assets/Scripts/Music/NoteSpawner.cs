using UnityEngine;
using System.Collections;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;

    public float startDelay = 0.5f;

    public Transform[] lanes;

    public IEnumerator SpawnNote()
    {
        yield return new WaitForSeconds(startDelay);
            int randomLane = Random.Range(0, lanes.Length);

            Instantiate(
                notePrefab,
                lanes[randomLane].position,
                lanes[randomLane].rotation
            );
    }
}
