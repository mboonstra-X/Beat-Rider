
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [Header("Hits")]
    [SerializeField] private int hits = 0;
    [SerializeField] private TextMeshProUGUI hitsText;

    [Header("Score")]
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Combo")]
    public int combo = 0;
    [SerializeField] private TextMeshProUGUI comboText;

    private int highestCombo = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddHit()
    {
        hits++;
        combo++;

        if (combo > highestCombo)
        {
            highestCombo = combo;
        }

        hitsText.text = "Hits: " + hits;
        comboText.text = "Combo: " + combo;

        AddScore();
    }

    public void AddScore()
    {
        int multiplier = 1 + Mathf.Min(combo, 50) / 10;
        score += 10 * multiplier;

        scoreText.text = "Score: " + score;
    }

    public void ResetCombo()
    {
        combo = 0;
        comboText.text = "Combo: " + combo;
    }

    public void SaveResults()
    {
        GameResults.Score = score;
        GameResults.Hits = hits;
        GameResults.HighestCombo = highestCombo;
    }
}
