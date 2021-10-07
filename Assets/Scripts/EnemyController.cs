using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    const string PluginName = "UnityPlugin";

    [DllImport(PluginName)]
    private static extern int GetID();

    [DllImport(PluginName)]
    private static extern void SetID(int id);

    [DllImport(PluginName)]
    private static extern Vector3 GetPosition();

    [DllImport(PluginName)]
    private static extern void SetPosition(float x, float y, float z);

    [DllImport(PluginName)]
    private static extern Vector3 GenerateRandomPosition(int min, int max);

    // Start is called before the first frame update
    private void Awake()
    {
        InitEnemy();
    }

    private void InitEnemy()
    {
        SetPosition(GetID(), 2, 0);
        transform.position = GetPosition();
    }

    public void SetEnemyID(int _id)
    {
        SetID(_id);
    }
}
