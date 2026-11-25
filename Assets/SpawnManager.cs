
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;

    public float spawnInterval = 2f;

    private float timer = 0f;

    void Update()
    {
        // 시간 누적
        timer += Time.deltaTime;

        // 설정한 시간이 지나면 적 생성
        if (timer >= spawnInterval)
        {
            SpawnEnemy();

            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        if (enemyPrefabs.Length == 0 ||
            spawnPoints.Length == 0)
        {
            return;
        }

        // 적 종류 랜덤 선택
        int enemyIndex =
            Random.Range(0, enemyPrefabs.Length);

        // 생성 위치 랜덤 선택
        int pointIndex =
            Random.Range(0, spawnPoints.Length);

        // 적 생성
        Instantiate(
            enemyPrefabs[enemyIndex],
            spawnPoints[pointIndex].position,
            Quaternion.identity
        );
    }
}
