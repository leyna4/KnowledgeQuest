using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
