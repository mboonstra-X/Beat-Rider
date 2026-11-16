using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private int hits = 0;
    [SerializeField] private TextMeshProUGUI hitsText;

    private void Awake()
    {
        instance = this;
    }

    public void AddHit()
    {
        hits++;
        hitsText.text = "Hits: " + hits;
    }
}