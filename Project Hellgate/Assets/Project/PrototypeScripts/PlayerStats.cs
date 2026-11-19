using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100.0f;
    public float currentHealth;
    public float drainRate = 5.0f;
    public int soulCount = 0;
    public TMP_Text healthText;
    public TMP_Text soulCountText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        UpdateSoulUI();
    }

    // Update is called once per frame
    void Update()
    {
        drainHealth(drainRate);
        UpdateHealthUI();
    }

    public void drainHealth(float drainRate)
    {
        if (currentHealth > 0.0f)
        {
            currentHealth -= drainRate * Time.deltaTime;
            if (currentHealth < 0.0f)
            {
                currentHealth = 0.0f;
            }
        }
    }

    public void AddSoul(int amount)
    {
        soulCount += amount;
        UpdateSoulUI();
    }

    public void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + Mathf.CeilToInt(currentHealth);
        }
    }

    public void UpdateSoulUI()
    {
        if (soulCountText != null)
        {
            soulCountText.text = "Demon Souls: " + soulCount;
        }
    }
}
