using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject carPrefab;

    public Transform[] lanes;

    public void SpawnCar()
    {
        int randomLane = Random.Range(0, lanes.Length);

        Instantiate(
            carPrefab,
            lanes[randomLane].position,
            lanes[randomLane].rotation
        );
    }
}
