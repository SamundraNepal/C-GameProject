using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {



    public GameObject GameoverUI;

    public GameObject player;

    public AudioClip Gameovver;
    AudioSource audioSource;




    public void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }




    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")

        {


            audioSource.PlayOneShot(Gameovver);
            Destroy(player);
            GameoverUI.SetActive (true);


       


        }

    }



}
