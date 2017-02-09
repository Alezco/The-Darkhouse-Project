using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceController : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (PlayerInventory.getInstance().getInventory().Contains("FenceKey"))
        {
            GameObject.Find("Player/Canvas/HUDKey").SetActive(false);
            Destroy(GameObject.Find("Island/Lighthouse/Fence"));
        }
            
    }
}