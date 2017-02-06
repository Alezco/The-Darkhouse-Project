using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour {
    public int displayTime;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(handleText());
    }

    IEnumerator handleText()
    {
        GameObject.Find("Player/Canvas/JumpText").active = true;
        yield return new WaitForSeconds(displayTime);
        GameObject.Find("Player/Canvas/JumpText").active = false;
    }
}
