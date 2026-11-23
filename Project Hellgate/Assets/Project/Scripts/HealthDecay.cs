using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDecay : MonoBehaviour
{
    [SerializeField] Image HPFill;
    [SerializeField] TextMeshProUGUI playerHealthText;
    public float playerHealth;
    public float decayAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HPFill.fillAmount = playerHealth / 100;
        playerHealthText.SetText(playerHealth.ToString());
        StartCoroutine(Decay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Decay()
    {
        yield return new WaitForSecondsRealtime(1f);
        while (playerHealth >0)
        {
            playerHealth -= decayAmount;
            HPFill.fillAmount = playerHealth / 100;
            playerHealthText.SetText(playerHealth.ToString());
            yield return new WaitForSecondsRealtime(1f);
        }
    }
}
