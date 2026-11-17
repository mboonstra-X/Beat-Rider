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
            return;
        }

        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth == null)
        {
            return;
        }

        playerHealth.TakeDamage(noteDMG);
        ScoreManager.instance.ResetCombo();

        Destroy(gameObject);

        Debug.Log("Note hit wall, player took damage: " + noteDMG);
    }
}
