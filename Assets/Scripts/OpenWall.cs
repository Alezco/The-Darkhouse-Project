using System;

using UnityEngine;
using UnityEngine.UI;

public class OpenWall : MonoBehaviour {

    public Text remaining;
	
	void Update()
    {
        int count = Int32.Parse(remaining.text);
        if (count <= 0)
            gameObject.SetActive(false);
	}
}