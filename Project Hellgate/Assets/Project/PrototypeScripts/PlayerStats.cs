using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100.0f;
    public float currentHealth;
    public float drainRate = 5.0f;
    public TMP_Text healthText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 0.0f)
        {
            currentHealth -= drainRate * Time.deltaTime;
            if (currentHealth < 0.0f)
            {
                currentHealth = 0.0f;
            }
        }

        if(healthText != null)
        {
            healthText.text = "Health: " + Mathf.CeilToInt(currentHealth);
        }
        
    }
}
