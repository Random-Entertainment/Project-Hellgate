using UnityEngine;
using UnityEngine.InputSystem;
public class DebugSoulSpawner : MonoBehaviour
{
    public GameObject soulPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current != null && Keyboard.current.kKey.wasPressedThisFrame)
        {
            float randomX = Random.Range(-4f, 4f);
            float randomY = Random.Range(-3f, 3f);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);
            if(soulPrefab != null)
            {
                Instantiate(soulPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
