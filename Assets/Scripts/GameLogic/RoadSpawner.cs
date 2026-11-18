using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPref;

    public GameObject roadSpawnerPos;

    float SpawnTime = 0f;

    void Update()
    {
        SpawnTime -= Time.deltaTime;
        if (SpawnTime <= 0)
            {
            SpawnRoad();
            SpawnTime = 0.5f;
        }
    }

    void SpawnRoad()
    {
        Instantiate(roadPref, roadSpawnerPos.transform.position, Quaternion.identity);
    }
}
