using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameOver(); 
        }
    }


}
