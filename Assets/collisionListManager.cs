using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionListManager : MonoBehaviour
{
    public MechanicsManager mechanicsManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            mechanicsManager.crowd.Add(other.gameObject);
    }
}
