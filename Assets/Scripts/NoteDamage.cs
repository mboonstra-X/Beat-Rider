using UnityEngine;

public class NoteDamage : MonoBehaviour
{
    [SerializeField] private int noteDMG = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Wall"))
        {
            return;
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Debug.LogWarning("No GameObject with the Player tag was found.");
            return;
        }

        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth == null)
        {
            Debug.LogWarning("The Player object does not have a PlayerHealth component.");
            return;
        }

        playerHealth.TakeDamage(noteDMG);
        Destroy(gameObject);

        Debug.Log("Note hit wall, player took damage: " + noteDMG);
    }
}