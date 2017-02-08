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

    void OnTriggerEnter(Collider other)
    {
        bc.isTrigger = false;
        isTouched = true;
        print("lol");
        
        Rigidbody rb = GetComponent<Rigidbody>();
        //rb.useGravity = true;
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
