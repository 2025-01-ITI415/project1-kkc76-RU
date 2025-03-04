using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(Renderer))]
public class Goal : MonoBehaviour{


	void OnTriggerEnter(Collider other) {
        // when the trigger is hit by something

        if (other.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene("_Finish");


		}
    }
}
