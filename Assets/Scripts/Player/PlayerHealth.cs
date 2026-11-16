using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Car 20% loss, Note miss 5% HP loss
    [SerializeField] private int playerHealth = 100;
    [SerializeField] private int currentHealth;


    void Start()
    {
        currentHealth = playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = currentHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            //Die();
        }
    }
}
