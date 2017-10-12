using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {


    public Transform coins;


    public Text Score;

    public int Count;




    public void Start()
    {

        Count = 0;
      
       SetCountText();

    }



    public void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.tag == "Player")

        {



            Destroy(gameObject);

            Count = Count + 1;

            SetCountText();
            

        }
    }


    public void SetCountText()

    {

        Score.text = "SCORE : " + Count.ToString();


    }


}
