using UnityEngine;

public class TestScript : MonoBehaviour
{
    int x;
    void FixedUpdate()
    {
        x++;
        Debug.Log("Called total times: " + x.ToString());

    }

}
