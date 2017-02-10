using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {

    public Camera finalCamera;

	void Start () {
        finalCamera.gameObject.SetActive(false);
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            finalCamera.gameObject.SetActive(true);
            collider.gameObject.SetActive(false);
        }
    }
}
