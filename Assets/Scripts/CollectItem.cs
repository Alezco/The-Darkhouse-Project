using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

    public int rotationSpeed;
    public string path;
    public string item;

    void Start()
    {
        GameObject.Find(path).SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject.Find(path).SetActive(true);
        PlayerInventory.getInstance().getInventory().Add(item);
    }

    void Update()
    {
        gameObject.transform.Rotate(0, rotationSpeed, 0);
    }
}
