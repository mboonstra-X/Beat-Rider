using UnityEngine;

public class CarDamage : MonoBehaviour
{
    [SerializeField] private int carDMG = 20;

    private BoxCollider boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        Collider[] hits = Physics.OverlapBox(
            boxCollider.bounds.center,
            boxCollider.bounds.extents,
            Quaternion.identity,
            Physics.AllLayers,
            QueryTriggerInteraction.Collide
        );

        foreach (Collider hit in hits)
        {
            if (hit.gameObject.CompareTag("Note") ||
                hit.transform.root.CompareTag("Note"))
            {
                Destroy(gameObject);
                return;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(carDMG);
                playerHealth.UpdateHealthColor();

                ScoreManager.instance.ResetCombo();

                boxCollider.enabled = false;
            }
        }
    }
}