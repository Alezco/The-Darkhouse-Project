using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour {
    public int displayTime;
    public string text;

    void Start()
    {
        GameObject.Find(text).SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(handleText());
    }

    IEnumerator handleText()
    {
        GameObject.Find(text).SetActive(true);
        yield return new WaitForSeconds(displayTime);
        GameObject.Find(text).SetActive(false);
    }
}
