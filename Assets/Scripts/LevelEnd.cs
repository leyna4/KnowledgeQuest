using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public string levelSelectionSceneName = "LevelSelection"; // Sahne adýný yaz
    public float delayBeforeReturn = 2f; // Bekleme süresi

    public GameObject gameOverUI; // Ekrana "Oyun Bitti" yazýsý göstermek için

    private bool levelEnded = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player girdi, oyun bitti!");
            // Panel gösterme vs.
        }
    }


    void ReturnToLevelSelect()
    {
        SceneManager.LoadScene(levelSelectionSceneName);
    }

}
