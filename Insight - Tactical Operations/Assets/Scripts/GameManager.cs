using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool is2DPlayer;
    bool isVRPlayer;
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPlayerType2D()
    {
        is2DPlayer = true;
        isVRPlayer = false;
    }

    public void setPlayerTypeVR()
    {
        is2DPlayer = false;
        isVRPlayer = true;
    }

    public bool is2DPlayerType()
    {
        return is2DPlayer;
    }

    public bool isVRPlayerType()
    {
        return isVRPlayer;
    }

}
