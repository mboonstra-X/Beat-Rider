using UnityEngine;

public class NoteHit : MonoBehaviour
{
    public AudioClip NoteHitSound;
    // so its less disturbing when hitting note
    [Range(0f, 1f)]
    public float hitVolume = 0.5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddHit();

            AudioSource.PlayClipAtPoint(NoteHitSound, transform.position, hitVolume);

            Destroy(gameObject);
        }
    }
}