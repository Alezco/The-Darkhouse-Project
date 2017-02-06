using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceKey : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        PlayerInventory.getInstance().getInventory().Add("FenceKey");
    }
}
