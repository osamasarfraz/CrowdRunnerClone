using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshPro textMesh;
    public static int currentValue = 1;
    private void Update()
    {
        textMesh.text = currentValue.ToString();
    }
}
