using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        print("test");
        PlayerInventory.getInstance().getInventory().Add("Lighter");
        Destroy(gameObject);
    }

	void Update () {
        transform.Rotate(0, 2, 0);
	}
}
