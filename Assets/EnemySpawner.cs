
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public float spawnInterval = 2f;
    public float spawnOffset = 2f;
    public float sideMargin = 1f;

    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;

        InvokeRepeating(
            nameof(SpawnEnemy),
            0f,
            spawnInterval
        );
    }

    void SpawnEnemy()
    {
        if (enemyPrefabs.Length == 0)
            return;

        float camHeight = mainCam.orthographicSize;
        float camWidth = camHeight * mainCam.aspect;

        float minX = mainCam.transform.position.x
                     - camWidth + sideMargin;

        float maxX = mainCam.transform.position.x
                     + camWidth - sideMargin;

        float spawnX = Random.Range(minX, maxX);

        float spawnY = mainCam.transform.position.y
                       + camHeight + spawnOffset;

        Vector3 spawnPosition =
            new Vector3(spawnX, spawnY, 0f);

        int index = Random.Range(0, enemyPrefabs.Length);

        Instantiate(
            enemyPrefabs[index],
            spawnPosition,
            Quaternion.identity
        );
    }
}
