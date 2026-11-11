using UnityEngine;

public class NoteHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddHit();

            Destroy(gameObject);
        }
    }
}