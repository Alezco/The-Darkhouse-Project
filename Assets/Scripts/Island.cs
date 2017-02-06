using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour {
	void Start () {
        GameObject.Find("Player/Canvas/JumpText").active = false;
        GameObject.Find("Player/Canvas/CrouchText").active = false;
    }
}
