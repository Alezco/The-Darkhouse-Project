using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Scenes/LighthouseScene");
    }
}
