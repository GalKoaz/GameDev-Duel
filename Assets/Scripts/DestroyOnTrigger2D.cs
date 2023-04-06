using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */

public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private GameObject canvas; 
    void Start()
    {
        canvas = GameObject.Find("Canvas");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(triggeringTag) && enabled)
        {
            if (this.CompareTag("player1"))
            {
                int h1 = FindObjectOfType<PlayerHealth>().TakeDamage();
                if (h1 == 0)
                {
                    canvas.transform.GetChild(0).gameObject.SetActive(true); 
                    Debug.Log("player2 is the winner!");
                }
            }else if(this.CompareTag("player2"))
            {
                int h2 = FindObjectOfType<PlayerHealth2>().TakeDamage();
                if (h2 == 0)
                {
                    canvas.transform.GetChild(1).gameObject.SetActive(true);  
                    Debug.Log("player1 is the winner!");
                }
            }
            Destroy(other.gameObject);
            //Destroy(gameObject);
        }
    }
}