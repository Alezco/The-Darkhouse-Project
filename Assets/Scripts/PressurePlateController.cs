using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateController : MonoBehaviour {
    private bool isPushed;
    private GameObject ironBar;
    private float y2;

    void Start()
    {
        isPushed = false;
        ironBar = GameObject.Find("Room1/IronBars/IronBar2");
    }

    void OnTriggerEnter(Collider other)
    {
        isPushed = true;
    }

    void OnTriggerExit(Collider other)
    {
        isPushed = false;
    }

    void Update()
    {
        if (isPushed)
        {
            ironBar.GetComponent<MeshCollider>().enabled = false;
            ironBar.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            ironBar.GetComponent<MeshCollider>().enabled = true;
            ironBar.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
