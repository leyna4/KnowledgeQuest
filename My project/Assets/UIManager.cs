using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }
    public void UpdateScore(){
        scoreText.SetText("Score: " + GameManager.instance.score.ToString());
    }
}
