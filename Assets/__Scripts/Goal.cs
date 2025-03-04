using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(Renderer))]
public class Goal : MonoBehaviour{
	static public bool 	goalMet = false;

	void OnTriggerEnter(Collider other) {
        // when the trigger is hit by something
        // check to see if it's a Projectile 
        PlayerController player = other.GetComponent<PlayerController>();
		if (other.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene("_Scene_0");


		}
    }
}
