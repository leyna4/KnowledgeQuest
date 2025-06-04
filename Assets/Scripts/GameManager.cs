using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private Card firstCard, secondCard;

    [Header("Kart Ayarlarý")]
    public List<GameObject> cards;         
    public Transform cardParent;           

    void Start()
    {
        ShuffleAndPlaceCards();
    }

    public void CardRevealed(Card card)
    {
        if (firstCard == null)
        {
            firstCard = card;
        }
        else if (secondCard == null)
        {
            secondCard = card;
            StartCoroutine(CheckMatch());
        }
    }

    IEnumerator CheckMatch()
    {
        yield return new WaitForSeconds(1f);

        if (firstCard.cardName == secondCard.cardName)
        {
            
        }
        else
        {
            
            firstCard.HideFront();
            secondCard.HideFront();
        }

        firstCard = null;
        secondCard = null;
    }

    void ShuffleAndPlaceCards()
    {
       
        for (int i = 0; i < cards.Count; i++)
        {
            GameObject temp = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }

        
        foreach (GameObject card in cards)
        {
            card.transform.SetParent(cardParent, false);
        }
    }
}
