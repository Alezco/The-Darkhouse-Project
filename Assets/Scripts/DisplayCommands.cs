using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCommands : MonoBehaviour {
    public int displayTime;

    void Start () {
        StartCoroutine(handleText());
    }

    IEnumerator handleText()
    {
        GameObject.Find("Boat/Canvas/ReachBoundariesText").SetActive(false);
        this.gameObject.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        this.gameObject.SetActive(false);
    }
}
