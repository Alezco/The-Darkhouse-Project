using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellHoleController : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Scenes/UndergroundScene");
    }
}
