
using UnityEngine;
using UnityEngine.InputSystem;

public class BikeMovement : MonoBehaviour
{
    public float roadWidth = 10f;
    public float maxBikeMovement = 0.8f;

    private float startZ;

    void Start()
    {
        startZ = transform.position.z;
    }

    void Update()
    {
        // Get mouse position
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // Convert mouse position to world position
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        Plane ground = new Plane(Vector3.up, Vector3.zero);

        if (ground.Raycast(ray, out float distance))
        {
            Vector3 targetPosition = ray.GetPoint(distance);

            // Keep bike inside the road
            float maxX = roadWidth / 2 - maxBikeMovement;
            float targetX = Mathf.Clamp(targetPosition.x, -maxX, maxX);

            // Bike Movement (L > R)
            Vector3 newPosition = transform.position;

            newPosition.x = Mathf.Lerp(
                transform.position.x,
                targetX,
                2
            );

            newPosition.z = startZ;

            transform.position = newPosition;
        }
    }
}
