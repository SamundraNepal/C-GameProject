using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRender : MonoBehaviour {


    public Renderer rend;

    public AudioClip Show;
    AudioSource audioSource;



    public void Start()
    {


        audioSource = GetComponent<AudioSource>();

        rend.enabled = false;

    }


 
    



    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")

        {


            

            rend.enabled = true;



            audioSource.PlayOneShot(Show);


            if (rend.enabled == true)
            {

                Destroy(audioSource, 0.1f);
                
            }



        }

    }


    




}
