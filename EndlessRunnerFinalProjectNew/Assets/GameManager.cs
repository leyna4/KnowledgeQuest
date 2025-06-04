using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

    void Awake()
    {
        instance = this;
    }
    public GameObject gameOverPanel;

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   

    public void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0f; 
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }


    public void ChangePlayerSpeed(float amount)
    {
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        if (player != null)
        {
            player.ChangeSpeed(amount);
        }
    }

    public void AddScore(){
        score++;
        UIManager.instance.UpdateScore();
        Debug.Log("Score added.");
    }



}
