using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
	public Text countText;
	private int count;
	void OnTriggerEnter(Collider other)
	{
		// when the trigger is hit by something

		if (other.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene("_Game_Over");


		}
	}
	void GetCountText()
		{
			// Update the text field of our 'countText' variable
			countText.text = "Count: " + count.ToString();

			// Check if our 'count' is equal to or exceeded 12

		}
}
