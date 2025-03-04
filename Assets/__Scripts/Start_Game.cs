using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Start_Game : MonoBehaviour
{
    public void StartButton()
    {

        SceneManager.LoadScene("_Scene_0");

    }
    public void ResetButton()
    {

        SceneManager.LoadScene("_Start");

    }
}
