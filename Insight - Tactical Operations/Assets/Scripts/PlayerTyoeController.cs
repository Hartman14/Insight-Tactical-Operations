using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTyoeController : MonoBehaviour {

    public GameObject VRPlayer;
    public GameObject TwoDPlayer;
    private GameObject managerObject;

	// Use this for initialization
	void Start () {
        managerObject = GameObject.Find("Main Game Manager");
        Debug.Log(managerObject.name);
	}
	
	// Update is called once per frame
	void Update () {
        if (managerObject.GetComponent<GameManager>().is2DPlayerType())
        {
            TwoDPlayer.SetActive(true);
            VRPlayer.SetActive(false);
        }

        else if (managerObject.GetComponent<GameManager>().isVRPlayerType())
        {
            TwoDPlayer.SetActive(false);
            VRPlayer.SetActive(true);
        }
    }
}
