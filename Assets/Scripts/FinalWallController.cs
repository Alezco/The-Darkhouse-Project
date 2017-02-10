using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWallController : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().isTrigger = false;
    }
}
