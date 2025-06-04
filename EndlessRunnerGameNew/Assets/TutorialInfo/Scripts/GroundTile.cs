using UnityEngine;

public class GroundTile : MonoBehaviour 
{
    private GroundSpawner groundspawner;
    
    public GameObject[] obstaclePrefabs;
    public Transform[] spawnpoints;

    private void Awake()
    {
        groundspawner = GameObject.FindFirstObjectByType<GroundSpawner>();
    }
    void Start()
    {
        SpawnObs();
    }
  

    private void OnTriggerExit(Collider other)
    {
        groundspawner.spawnTile();

        Destroy(gameObject, 5f);
    }

    public void SpawnObs()
    {
        int ChooseSpawnPoint = Random.Range(0, spawnpoints.Length);
        int SpawnPrefab = Random.Range(0, obstaclePrefabs.Length);

        Instantiate(obstaclePrefabs[SpawnPrefab], spawnpoints[ChooseSpawnPoint].transform.position, Quaternion.identity, transform);

    }
}
