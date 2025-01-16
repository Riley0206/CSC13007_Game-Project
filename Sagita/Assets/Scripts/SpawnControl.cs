using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float spawnRate;
    [SerializeField][Range(0f, 1f)] float spawnChance;
    [SerializeField] Vector2 spawnArea;

    float timer;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnObject();
            timer = spawnRate;
        }
    }

    public void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-spawnArea.x, spawnArea.x), UnityEngine.Random.Range(-spawnArea.y, spawnArea.y));
        if (Random.value <= spawnChance)
        {
            GameObject go = Instantiate(spawnObject, spawnPosition, Quaternion.identity);
        }
    }
}
