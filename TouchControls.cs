using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

    public static int playerTurnAxisTouch = 0;
    public static int playerMoveAxsisTouch = 0;

    // Use this for initialization
    void Start () {

        playerTurnAxisTouch = 0;
        playerMoveAxsisTouch = 0;

    }

    //Left Button Down
    public void playerLeftUIPointerDown()
    {
        playerTurnAxisTouch = -1;
    }

    //Left Button Up
    public void playerLeftUIPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    //Right Button Down
    public void playerRightUIPointerDown()
    {
        playerTurnAxisTouch = 1;
    }

    //Right Button Down
    public void playerRightUIPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    //Player Move Down
   // public void playerMoveUIPointerDown()
   // {
       // playerMoveAxsisTouch = 1;
   /// }

    //Player Move Up
   // public void playerMoveUIPointerUp()
  //  {
  //      playerMoveAxsisTouch = 0;
   // }


    // Update is called once per frame
  //  void Update () {
		
	//}
}
