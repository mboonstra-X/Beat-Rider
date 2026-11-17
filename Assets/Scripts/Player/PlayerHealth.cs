using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //Car 20% loss, Note miss 5% HP loss
    [SerializeField] private int playerHealth = 100;
    [SerializeField] public int currentHealth;
    [SerializeField] private Image healthPanel;
    [SerializeField] private Image ScorePanel;

    private Color green = new Color(0f, 1f, 0f);
    private Color orange = new Color(1f, 0.5f, 0f);
    private Color red = new Color(1f, 0f, 0f);

    void Start()
    {
        currentHealth = playerHealth;
        UpdateHealthColor();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, playerHealth);

        UpdateHealthColor();

        Debug.Log("Player Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }

    public void UpdateHealthColor()
    {
        float healthPercentage = (float)currentHealth / playerHealth;

        if (healthPercentage > 0.5f)
        {
            healthPanel.color = Color.Lerp(orange, green, (healthPercentage - 0.5f) * 2);
            ScorePanel.color = Color.Lerp(orange, green, (healthPercentage - 0.5f) * 2);
        }
        else
        {
            healthPanel.color = Color.Lerp(red, orange, healthPercentage * 2);
            ScorePanel.color = Color.Lerp(red, orange, healthPercentage * 2);
        }
    }
}
