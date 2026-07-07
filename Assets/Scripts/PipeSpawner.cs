using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnTime = 2f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnTime);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            randomY,
            0
        );

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}