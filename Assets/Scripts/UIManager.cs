using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("Play Button Çalýþtý!");

        SceneManager.LoadScene("MainScene");
    }
        public void ObtionButtons()
    {
        Debug.Log("Obtion Button çalýþtý!");

    }
    public void CreditsButton()
    {
        Debug.Log("Credits Button çalýþtý!");

    }
    public void ExitButton()
    {
        Debug.Log("Exit Button çalýþtý!");

    }
}

