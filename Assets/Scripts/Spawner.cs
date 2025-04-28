using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject dartboardSpawn;
    [SerializeField] private GameObject dartboard;

    private float spawnTimer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer >= 5)
        {
            Spawn();
            spawnTimer = 0;
        }
        spawnTimer += Time.deltaTime;

    }

    void Spawn()
    {
        Instantiate(dartboard, dartboardSpawn.transform.position, Quaternion.identity);
    }
}
