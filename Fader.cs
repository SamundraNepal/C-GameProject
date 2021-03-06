﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour {


    public Image img;

    public void Start()
    {


        StartCoroutine(FadeIn());

    }



    public void FadeTo(string Scene)


    {


        StartCoroutine(FadeOut(Scene));
    }

    IEnumerator FadeIn()

    {

        float t = 1f;

        while (t > 0f)
        {
            t -= Time.deltaTime;

            img.color = new Color(0f, 0f, 0f, t);
            yield return 0;
        }

    }



    IEnumerator FadeOut(string Scene)

    {

        float t = 1f;

        while (t < 1f)
        {
            t += Time.deltaTime;

            img.color = new Color(0f, 0f, 0f, t);
            yield return 0;
        }


        SceneManager.LoadScene(Scene);
    }

}
