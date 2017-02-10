using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpdateHUDGoal : MonoBehaviour {

    public Text goalText;
    public string newGoal;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            goalText.text = newGoal;
    }
}
