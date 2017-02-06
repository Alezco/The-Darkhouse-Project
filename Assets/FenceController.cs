using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceController : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (PlayerInventory.getInstance().getInventory().Contains("FenceKey"))
            Destroy(GameObject.Find("Island/Lighthouse/Fence"));
    }
}