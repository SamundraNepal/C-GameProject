using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public Fader fader;





    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))

        {
          fader.FadeTo("Level2");

        }

    }



}
