using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Card : MonoBehaviour
{
    public void OnCardClicked()
    {
        Debug.Log("Kart týklandý!");

    }

    public Image frontImage;   
    public GameObject front;  
    public GameObject back;    

    public GameManager gameManager; 
    public string cardName;

   

    public void OnClick()
    {
        if (front.activeSelf) return; 
        ShowFront(); 
        gameManager.CardRevealed(this); 
    }

    public void ShowFront()
    {
        front.SetActive(true);
        back.SetActive(false);
    }

    public void HideFront()
    {
        front.SetActive(false);
        back.SetActive(true);
    }

   
}

