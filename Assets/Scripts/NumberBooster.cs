using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberBooster : MonoBehaviour
{
    public int value;
    public Type type;
    public enum Type { add, mul}
    public Player player;
    public TextMeshPro textMesh;
    bool calledOnce = false;
    private void Awake()
    {
        switch (type)
        {
            case Type.add:
                textMesh.text = "+" + value.ToString();
                break;
            case Type.mul:
                textMesh.text = "x" + value.ToString();
                break;
            default:
                break;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!calledOnce)
            {
                calledOnce = true;
                switch (type)
                {
                    case Type.add:
                        Player.currentValue += value;
                        break;
                    case Type.mul:
                        Player.currentValue *= value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
