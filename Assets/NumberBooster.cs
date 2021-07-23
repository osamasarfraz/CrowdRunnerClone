using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberBooster : MonoBehaviour
{
    public MechanicsManager mechanicsManager;
    bool calledOnce = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!calledOnce)
            {
                calledOnce = true;
                mechanicsManager.UpdateCrowd(mechanicsManager.activeCount + 10);
            }
        }
    }
}
