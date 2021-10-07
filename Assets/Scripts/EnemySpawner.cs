// Arthiran Sivarajah - 100660300 : PluginTester.cs

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
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
    void Start()
    {
        SetPosition(0,0,0);
        //Vector3 RandomPosition = GenerateRandomPosition(0, 100);

        Debug.Log("Generated Random Position: (" + GetPosition().x + ", " + GetPosition().y + ", " + GetPosition().z + ")");
    }
}

