using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("Play Button �al��t�!");

        SceneManager.LoadScene("MainScene");
    }
        public void ObtionButtons()
    {
        Debug.Log("Obtion Button �al��t�!");

    }
    public void CreditsButton()
    {
        Debug.Log("Credits Button �al��t�!");

    }
    public void ExitButton()
    {
        Debug.Log("Exit Button �al��t�!");

    }
}

