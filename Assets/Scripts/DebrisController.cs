using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisController : MonoBehaviour {
    public float speed;
    private Transform playerTransform;
    private BoxCollider bc;
    private bool isTouched;

    void Start()
    {
        playerTransform = GameObject.FindWithTag("WellPlanks").transform;
        bc = GetComponent<BoxCollider>();
        isTouched = false;
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.CompareTag("Player") && PlayerInventory.getInstance().getInventory().Contains("Crowbar"))
        {
            bc.isTrigger = false;
            isTouched = true;
            GameObject.Find("Player/Canvas/HUDCrowbar").SetActive(false);
            Rigidbody rb = GetComponent<Rigidbody>();
        }
   
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("WellPlanks"))
        {
            Destroy(GameObject.Find("Island/Well/WellPlanks"));
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (isTouched)
        {
            transform.LookAt(playerTransform);
            if (Vector3.Distance(transform.position, playerTransform.position) >= 0)
                transform.position += transform.forward * speed;
        }
    }
}
