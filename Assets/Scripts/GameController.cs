using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    void Awake()
    {
        Instance = this;
    }

    public GameObject winPanel;
    public Button levelSelectButton;

    private int correctCount = 0;
    public int totalItems = 9; // Kaç eþya varsa onu yaz

        void Start()
        {
            winPanel.SetActive(false); // baþlangýçta kapalý
            levelSelectButton.onClick.AddListener(GoToLevelSelection);
        }


        public void ItemPlacedCorrectly()
    {
        correctCount++;

        if (correctCount >= totalItems)
        {
            ShowWinPanel();
        }
    }

    void ShowWinPanel()
    {
        winPanel.SetActive(true); // direkt aç

        
        CanvasGroup cg = winPanel.GetComponent<CanvasGroup>();
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
        
    }


   public void GoToLevelSelection()
    {
        SceneManager.LoadScene("Scenes/Level2Scene");
    }
}
