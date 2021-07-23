using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MechanicsManager : MonoBehaviour
{
    public GameObject cameraGO;
    public GameObject personGO;
    public PlatformPooling platformPooling;
    public int blocksCount;
    public Vector3[] positions;
    [SerializeField]
    public List<GameObject> crowd;

    public int activeCount;
    private void Start()
    {
        for(int i = 0; i < activeCount; i++)
        {
            crowd[i].SetActive(true);
            print(i);
        }


        Sequence sq = DOTween.Sequence();
        sq.AppendInterval(2f);
        sq.Append(personGO.transform
            .DOMoveX(-20 * (blocksCount - 1), (blocksCount / 2))
            .SetEase(Ease.Linear));
        for (int i = 0; i < blocksCount; i++)
        {

            platformPooling.platforms[i].SetActive(true);
        }


        //StartCoroutine(platformRepeat());
    }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.I))
    //    {
    //        Instantiate(personGO.transform.GetChild(0), personGO.transform.GetChild(0).position + (Vector3.left * 2), Quaternion.identity, personGO.transform);
    //    }
    //}
    IEnumerator platformRepeat()
    {
        for (int i = 0; i < blocksCount; i++)
        {

            //Sequence sq = DOTween.Sequence();
            //sq.AppendInterval(2f);
            //sq.Append(personGO.transform
            //    .DOMoveX(-25 * i, 1f)
            //    .SetEase(Ease.Linear)
            //    .OnComplete(() => platformPooling.PoolPlatform()));
            yield return new WaitForSeconds(1f);
        }
    }
    
    public void UpdateCrowd(int num)
    {
        activeCount = num;
        for (int i = 0; i < activeCount; i++)
        {
            crowd[i].SetActive(true);
            print(i);
        }
    }

    public float x_Start, z_Start;
    public int ColumnLength;
    public int RowLength;
    public int x_Space, z_Space;

    [ContextMenu("MakeClones")]
    public void MakeClones()
    {
        for (int i = 0; i < ColumnLength * RowLength; i++)
        {
            Vector3 position;
            position = new Vector3(x_Start + (x_Space * (i % ColumnLength)), 0,  z_Start + (-z_Space * (i / ColumnLength)));
            Instantiate(personGO.transform.GetChild(0).gameObject, position, Quaternion.identity, personGO.transform);
        }
    }
}
