using UnityEngine;

public class NoteHit : MonoBehaviour
{
    public AudioClip NoteHitSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddHit();

            AudioSource.PlayClipAtPoint(NoteHitSound, transform.position);

            Destroy(gameObject);
        }
    }
}