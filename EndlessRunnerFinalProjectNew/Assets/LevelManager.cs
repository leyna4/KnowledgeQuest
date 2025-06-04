using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform player;
    public GameObject[] tilePrefabs;
    public float tileLength = 30f;

    public float spawnDistance;
    private float spawnZ;
    private List<GameObject> spawnedtiles = new List<GameObject>();

    void SpawnTile(){
        int index = Random.Range(0, tilePrefabs.Length);
        GameObject tile = Instantiate(tilePrefabs[index], Vector3.forward * spawnZ, Quaternion.identity);
        spawnedtiles.Add(tile);
        spawnZ += tileLength;
    }

    void Start()
    {
        SpawnTile();
        GameManager.instance.AddScore();
    }

    void Update()
    {
        float characterDistance = player.position.z;
        if(characterDistance + spawnDistance > spawnZ ){
            SpawnTile();
        }
    }
}
