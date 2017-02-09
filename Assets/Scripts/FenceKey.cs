using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceKey : MonoBehaviour {
    public int rotationSpeed;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject.Find("Player/Canvas/HUDKey").SetActive(true);
        PlayerInventory.getInstance().getInventory().Add("FenceKey");
    }

    void Update()
    {
        gameObject.transform.Rotate(0, rotationSpeed, 0);
    }
}
