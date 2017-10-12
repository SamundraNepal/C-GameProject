using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {


    public GameObject UI;


    public void Retry()

    {

        SceneManager.LoadScene("Game");
    }



    public void Menu()

    {

        SceneManager.LoadScene("MENU");
    }


}
