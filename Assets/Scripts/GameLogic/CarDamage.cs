using UnityEngine;

public class CarDamage : MonoBehaviour
{
    [SerializeField] private int carDMG = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(carDMG);
                BoxCollider boxCollider = GetComponent<BoxCollider>();
                boxCollider.enabled = false;
            }
        }
    }
}
