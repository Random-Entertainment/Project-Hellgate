using UnityEngine;

public class SoulPickup : MonoBehaviour
{
    public int soulValue = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerStats player = other.GetComponent<PlayerStats>();

        if(player != null )
        {
            player.AddSoul(soulValue);
            Destroy(gameObject);
        }
    }
}
