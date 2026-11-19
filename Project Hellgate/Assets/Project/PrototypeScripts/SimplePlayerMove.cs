using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current == null)
        {
            return;
        }

        float moveX = 0f;
        float moveY = 0f;

        if(Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            moveX -= 1f;
        }


        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            moveX += 1f;
        }


        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            moveY += 1f;
        }

        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            moveY -= 1f;
        }

        Vector2 movement = new Vector2(moveX, moveY).normalized;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
