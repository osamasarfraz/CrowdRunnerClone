using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPooling : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> platforms;

    void Start()
    {
        //StartCoroutine(platformPooling());
    }
    IEnumerator platformPooling()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject go = platforms[0];
        go.transform.position = platforms[platforms.Count - 1].transform.position + Vector3.left * 20f;
        platforms.Add(go);
        platforms.RemoveAt(0);
        print("here");
        StartCoroutine(platformPooling());
    }

    public void PoolPlatform()
    {
        GameObject go = platforms[0];
        go.transform.position = platforms[platforms.Count - 1].transform.position + Vector3.left * 20f;
        platforms.Add(go);
        platforms.RemoveAt(0);
        print("here");
    }
    
    [ContextMenu("AddPlatforms")]
    public void AddPlatforms()
    {
        foreach (Transform childs in transform.GetComponentsInChildren<Transform>())
            platforms.Add(childs.gameObject);
    }
}
