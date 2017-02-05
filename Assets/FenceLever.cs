using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceLever : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        print("Enter !");
        Destroy(gameObject);
        Destroy(GameObject.Find("Island/Lighthouse/Fence"));
    }
}
