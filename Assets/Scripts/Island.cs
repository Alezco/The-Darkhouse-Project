using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour {
	void Start () {
        GameObject.Find("Player/Canvas/JumpText").SetActive(false);
        GameObject.Find("Player/Canvas/CrouchText").SetActive(false);
        GameObject.Find("Player/Canvas/HUDKey").SetActive(false);
    }
}
