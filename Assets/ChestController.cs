using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {

    public Camera finalCamera;

	// Use this for initialization
	void Start () {
        finalCamera.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
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
