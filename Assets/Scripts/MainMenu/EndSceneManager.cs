
using TMPro;
using UnityEngine;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI hitsText;
    [SerializeField] private TextMeshProUGUI highestComboText;

    void Start()
    {
        scoreText.text = "Score: " + GameResults.Score;
        hitsText.text = "Hits: " + GameResults.Hits;
        highestComboText.text = "Highest Combo: " + GameResults.HighestCombo;
    }
}
