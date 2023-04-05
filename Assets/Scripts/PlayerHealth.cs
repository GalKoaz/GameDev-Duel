using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    [SerializeField] private int currentHealth = 3;
    [SerializeField] private GameObject[] hearts;
    
    public int TakeDamage() {
        if (currentHealth == 1) {
            Destroy(gameObject);
            hearts[0].GetComponent<Renderer>().enabled = false;
        }
        currentHealth--;
        return currentHealth;
    }

    private void Update()
    {
        for (var i = 0; i < hearts.Length; i++)
        {
            if (i >= currentHealth)
            {
                hearts[i].GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
