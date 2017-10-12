using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {


    public Fader fader;

    public GameObject UI;

    public void Play()
    {

        fader.FadeTo("Game");
        Time.timeScale = 1f;

    }

    public void Quit()

    {

        Application.Quit();
    }



}
