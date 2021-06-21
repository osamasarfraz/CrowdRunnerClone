using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject platformPrefab;
    public int count;
    [ContextMenu("GenerateNow")]
    public void GenerateNow()
    {
        for(int i = 0; i < count; i++)
            Instantiate(platformPrefab, Vector3.left * i * 20, Quaternion.identity, transform);
    }
}
