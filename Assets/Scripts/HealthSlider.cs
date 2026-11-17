using UnityEngine;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Update()
    {
        GetComponent<UnityEngine.UI.Slider>().value = player.GetComponent<PlayerHealth>().currentHealth;
    }
}
