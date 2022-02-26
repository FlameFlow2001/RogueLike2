using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemies;
    public float spawnCooldown;
    public float spawnXRange;
    public float spawnYRange;
    public int spawnEnemiesAmount;

    private void Start()
    {
        StartCoroutine(SpawnTestEnemy());
    }
    IEnumerator SpawnTestEnemy()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x += Random.Range(-spawnXRange, spawnXRange);
        spawnPos.y += Random.Range(-spawnYRange, spawnYRange);
        Instantiate(enemies[Random.Range(0, enemies.Count)], spawnPos, Quaternion.identity);
        spawnEnemiesAmount--;
        yield return new WaitForSeconds(spawnCooldown);
        if (spawnEnemiesAmount > 0)
            StartCoroutine(SpawnTestEnemy());
        else
            GameObject.Destroy(gameObject);
    }
}
