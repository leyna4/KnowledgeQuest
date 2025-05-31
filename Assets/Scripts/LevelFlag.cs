using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelFlag: MonoBehaviour
{
    public Button levelButton; // Level 1 butonu gibi

    private void Start()
    {
        levelButton.interactable = false; // Baþta týklanamasýn
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelButton.interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelButton.interactable = false;
        }
    }
}
