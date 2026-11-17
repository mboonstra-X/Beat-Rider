
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject normalObstacle;
    public GameObject spikeObstacle;

    public Transform spawnPoint;

    public void SpawnObstacle(bool isSpike)
    {
        GameObject prefab = isSpike
            ? spikeObstacle
            : normalObstacle;

        Instantiate(
            prefab,
            spawnPoint.position,
            spawnPoint.rotation
        );
    }
}
