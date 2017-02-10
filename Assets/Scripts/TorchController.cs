using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour {

    public Texture texture;

	void OnTriggerEnter(Collider other)
    {
        if (PlayerInventory.getInstance().getInventory().Contains("Lighter"))
            gameObject.GetComponent<Renderer>().material.mainTexture = texture;
    }
}
