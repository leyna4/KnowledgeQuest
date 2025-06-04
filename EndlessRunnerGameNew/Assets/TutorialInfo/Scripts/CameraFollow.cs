using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
    public Transform player;
    Vector3 offset;

    private void Awake()
    {
        player = FindFirstObjectByType<PlayerController>().transform;
    }

    void Start()
    {
        offset = transform.position - player.position;
    }

    void Update()
    {
        Vector3 targetpos = player.position + offset;
        targetpos.x = 0;
        transform.position = targetpos;
    }
}
