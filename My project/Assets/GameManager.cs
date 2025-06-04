using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(){
        score++;
        UIManager.instance.UpdateScore();
        Debug.Log("Score added.");
    }
}
