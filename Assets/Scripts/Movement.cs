
using UnityEngine;
using UnityEngine.InputSystem;

public class BikeMovement : MonoBehaviour
{
    public float WegBreedte = 10f;
    public float MaxBikeMove = 0.8f;

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
            float maxX = WegBreedte / 2 - MaxBikeMove;
            float targetX = Mathf.Clamp(targetPosition.x, -maxX, maxX);

            // Move bike horizontally
            Vector3 newPosition = transform.position;


            newPosition.z = startZ;

            transform.position = newPosition;
        }
    }
}
