using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorchController : MonoBehaviour {

    public Texture texture;
    public Text remaining;

	void OnTriggerEnter(Collider other)
    {
        if (PlayerInventory.getInstance().getInventory().Contains("Lighter") && gameObject.GetComponent<Renderer>().material.mainTexture != texture)
        {
            int count = Int32.Parse(remaining.text);
            count--;
            remaining.text = count.ToString();
            gameObject.GetComponent<Renderer>().material.mainTexture = texture;
        }
    }
}
