using UnityEngine;

public class Enemy_Spawn_Script : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    float timer;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = spawnTimer;
            SpawnEnemy();
        }

    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-spawnArea.x, spawnArea.x), Random.Range(-spawnArea.y, spawnArea.y), 0f);

        GameObject newEnemy = Instantiate(enemy);

        newEnemy.transform.position = position;


    }
}
