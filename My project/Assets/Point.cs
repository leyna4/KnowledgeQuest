using UnityEngine;

public class Point : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameManager.instance.AddScore();
        Destroy(this.gameObject);
    }
}
