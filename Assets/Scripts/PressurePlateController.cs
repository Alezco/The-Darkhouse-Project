using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateController : MonoBehaviour {
    private GameObject ironBar;
    private float y2;

    private bool cube;
    private bool player;

    void Start()
    {
        cube = false;
        player = false;
        ironBar = GameObject.Find("Room1/IronBars/IronBar2");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            player = true;
        if (other.gameObject.CompareTag("Cube"))
            cube = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            player = false;
        if (other.gameObject.CompareTag("Cube"))
            cube = false;
    }

    void Update()
    {
        if (cube || player)
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
