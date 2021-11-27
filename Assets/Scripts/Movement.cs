using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public int blocksCount;
    public PlatformPooling platformPooling;
    private void Start()
    {
        Sequence sq = DOTween.Sequence();
        sq.AppendInterval(2f);
        sq.Append(player.transform
            .DOMoveX(-20 * (blocksCount - 1), (blocksCount / 2))
            .SetEase(Ease.Linear));
        for (int i = 0; i < blocksCount; i++)
        {

            platformPooling.platforms[i].SetActive(true);
        }
    }
}
