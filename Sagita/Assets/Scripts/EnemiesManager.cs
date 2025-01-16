using System;
using System.Threading;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnTimer;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] GameObject player;
    [SerializeField] bool active;

    float timer;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && active)
        {
            SpawnEnemy();
            timer = spawnTimer;
        }
    }

    private void SpawnEnemy() //can still be improve, watch episode 6 later
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-spawnArea.x, spawnArea.x), UnityEngine.Random.Range(-spawnArea.y, spawnArea.y));

        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = spawnPosition;
        newEnemy.GetComponent<Enemy>().SetTarget(player);
    }
}
