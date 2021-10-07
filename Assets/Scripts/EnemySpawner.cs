// Arthiran Sivarajah - 100660300 : PluginTester.cs

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    [SerializeField]
    private int NumEnemies;

    // Start is called before the first frame update
    private void Awake()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < NumEnemies; i++)
        {
            GameObject NewEnemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            NewEnemy.GetComponent<EnemyController>().SetEnemyID(i);
        }
    }
}

