using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class MobileController : MonoBehaviour {




    public float JumpForce = 5f;

    Rigidbody2D MyBody;

	// Use this for initialization
	void Start () {


        MyBody = GetComponent<Rigidbody2D>();
		
	}

    public void FixedUpdate()
    {


        Vector2 moveHor = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis ("Vertical"));

        bool Jump = CrossPlatformInputManager.GetButton("Jump");


        MyBody.AddForce(moveHor * JumpForce);
     



    }
}
