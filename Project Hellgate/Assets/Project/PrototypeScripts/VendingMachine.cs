using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class VendingMachine : MonoBehaviour
{
    private PlayerStats nearbyPlayer = null;
    public int soulCost = 3;
    public float healAmount = 30.0f;
    public TMP_Text feedbackText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nearbyPlayer != null && Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            if(nearbyPlayer.soulCount >= soulCost)
            {
                nearbyPlayer.SpendSouls(soulCost);
                nearbyPlayer.Heal(healAmount);
                SetFeedback("Dispensed Demon Cola! +" + healAmount + " Health");
            }
            else
            {
                SetFeedback("Need more Demon Souls to make that drink!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerStats player = other.GetComponent<PlayerStats>();

        if(player != null)
        {
            nearbyPlayer = player;
            SetFeedback("Press E to Dispense Demon Cola (Cost: " + soulCost + ")");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.GetComponent<PlayerStats>() != null)
        {
            nearbyPlayer = null;
            SetFeedback(string.Empty);
        }
    }

    private void SetFeedback(string message)
    {
        if(feedbackText != null)
        {
            feedbackText.text = message;
        }
    }
}
