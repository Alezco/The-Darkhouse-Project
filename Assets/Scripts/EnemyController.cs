using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float speed;

    private Transform playerTransform;

    // Use this for initialization
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        catchPlayer();
    }

    void catchPlayer()
    {
        transform.LookAt(playerTransform);
        if (Vector3.Distance(transform.position, playerTransform.position) >= 0)
        {
            transform.position += transform.forward * speed;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Scenes/BoatScene");
        }
        
    }
}
