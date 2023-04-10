using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundsController : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    private Vector2 cameraBounds;

    void Start()
    {
        cameraBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        // Get the size of the screen in world space
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == player1 || other.gameObject == player2)
        {
            Vector3 playerPosition = other.gameObject.transform.position;
            // Get the player's current position
            playerPosition.x = Mathf.Clamp(playerPosition.x, -cameraBounds.x, cameraBounds.x);
            playerPosition.y = Mathf.Clamp(playerPosition.y, -cameraBounds.y, cameraBounds.y);
            // Restrict the player's position to stay within the camera bounds
            other.gameObject.transform.position = playerPosition;
            // Set the player's new position
        }
    }
}