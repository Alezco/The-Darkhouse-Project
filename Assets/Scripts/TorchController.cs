using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        Texture3D texture = (Texture3D) Resources.Load("Textures/fire");
        gameObject.GetComponent<Renderer>().material.mainTexture = texture;
    }
}
