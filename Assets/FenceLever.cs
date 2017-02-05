using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceLever : MonoBehaviour {
    //private GameController gameController;

    void Start()
    {
        /*GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        if (gameController == null)
            Debug.Log("Cannot find 'GameController' script");*/
    }

    void OnTriggerEnter(Collider other)
    {
        print("Enter !");
        if (other.CompareTag("Lever"))
        {
            //Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //gameController.GameOver();
            print("LOLOLOLOL");
        }
        //gameController.AddScore(scoreValue);
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    }
}
