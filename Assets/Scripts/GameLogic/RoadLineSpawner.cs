using UnityEngine;

public class RoadLineSpawner : MonoBehaviour
{
    public GameObject roadLine;

    public GameObject roadLineSpawner;

    float spawnInterval = 0.5f;

    void Update()
    {
        spawnInterval -= Time.deltaTime;
        if (spawnInterval <= 0)
            {
            SpawnRoadLine();
            spawnInterval = 0.5f;
        }
    }

    void SpawnRoadLine()
    {
        Instantiate(roadLine, roadLineSpawner.transform.position, Quaternion.identity);
    }
}
