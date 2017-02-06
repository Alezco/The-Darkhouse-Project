using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCommands : MonoBehaviour {
    public int displayTime;

    // Use this for initialization
    void Start () {
        StartCoroutine(handleText());
    }

    IEnumerator handleText()
    {
        this.gameObject.active = true;
        yield return new WaitForSeconds(displayTime);
        this.gameObject.active = false;
    }
}
