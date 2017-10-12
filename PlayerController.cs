using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

   

    public Text Score;

    public int Count;

    public AudioClip Impact;
    AudioSource audioSource;

    public GameObject GameOverUI;


  
	public float maxSpeed = 6f;
	public float jumpForce = 10f;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	public float verticalSpeed = 20;
	[HideInInspector]
	public bool lookingRight = true;
	bool doubleJump = false;
	public GameObject Boost;
	
	private Animator cloudanim;
	public GameObject Cloud;


	private Rigidbody2D rb2d;
	private Animator anim;
	private bool isGrounded = false;
    Rigidbody2D MyBody;



    // Use this for initialization
    void Start () {



        Count = 0;

        SetCountText();


        audioSource = GetComponent<AudioSource>();

        MyBody = GetComponent<Rigidbody2D>();
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		//cloudanim = GetComponent<Animator>();

		Cloud = GameObject.Find("Cloud");
  		cloudanim = GameObject.Find("Cloud(Clone)").GetComponent<Animator>();
	}


	void OnCollisionEnter2D(Collision2D collision2D) {
		
		if (collision2D.relativeVelocity.magnitude > 20){
			Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
			//cloudanim.Play("cloud");	

		}
	}



   // public void Jump()

    //{


      //  rb2d.velocity = new Vector2(0, jumpForce);

  //  }




   // public void JumpDown()

   // {


       // rb2d.velocity = new Vector2(0, -JumpdownForce);

   // }



    //public void Right()

   // {


      //  rb2d.velocity = new Vector2( maxSpeed , 0);

  //  }



  //  public void Left()

  //  {


       // rb2d.velocity = new Vector2(-maxSpeed, 0);
        
   // }





   // public void SetDeactivated()

  //  {

       // rb2d.velocity = new Vector2(0, 0);

  //  }


    // Update is called once per frame

    void Update () {




        if (Input.GetButtonDown("Jump") && (isGrounded || !doubleJump))
        {

            if (!doubleJump && !isGrounded)
            {
                doubleJump = true;
                Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
            cloudanim.Play("cloud");
            }
        }





        	if (Input.GetButtonDown("Vertical") && !isGrounded)
        {
        	rb2d.AddForce(new Vector2(0,-jumpForce));
        	Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
        cloudanim.Play("cloud");
        	}


        if (transform.position.y < -20)
        {

           
            GameOverUI.SetActive(true);

        }


        }


	void FixedUpdate()
	{

       if (isGrounded)
            doubleJump = false;


     float hor = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(hor));
   
        rb2d.velocity = new Vector2(hor * maxSpeed, rb2d.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15F, whatIsGround);

       anim.SetBool("IsGrounded", isGrounded);

      
       
   if ((hor > 0 && !lookingRight) || (hor < 0 && lookingRight))
         Flip();

       anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

      

   }





    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Coins")


        {

            Destroy(collision.gameObject);

            audioSource.PlayOneShot(Impact);


            Count = Count + 1;

            SetCountText();


        }

    }


    public void SetCountText()

    {

        Score.text = "SCORE : " + Count.ToString();


    }



   public void Flip()
	{
		lookingRight = !lookingRight;
		Vector3 myScale = transform.localScale;
		myScale.x *= -1;
	transform.localScale = myScale;

    }







}
