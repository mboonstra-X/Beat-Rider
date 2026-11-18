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

    private void Awake()
    {
        instance = this;
    }

    public void AddHit()
    {
        hits++;
        combo++;

        hitsText.text = "Hits: " + hits;
        comboText.text = "Combo: " + combo;

        AddScore();
    }

    public void AddScore()
    {
        // combo cap at MAX 50 score per hit, so multiplier is capped at 6 (1 + 50/10)

        int multiplier = 1 + Mathf.Min(combo, 50) / 10;
        score += 10 * multiplier;

        scoreText.text = "Score: " + score;
    }

    public void ResetCombo()
    {
        combo = 0;
        comboText.text = "Combo: " + combo;
    }
}