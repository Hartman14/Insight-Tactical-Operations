using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeapons : MonoBehaviour {

    public GameObject Rifle;
    public GameObject RifleBulletSpawner;
    public GameObject Pistol;
    public GameObject PistolBulletSpawner;

    bool Primary = false;
    bool Secondary = false;

    // Use this for initialization
    void Start()
    {
        Primary = true;
        Rifle.SetActive(true);
        RifleBulletSpawner.SetActive(true);
        Pistol.SetActive(false);
        PistolBulletSpawner.SetActive(false);
    }

    //------------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        /* checks if player is dead, to be added later in development
        if (isDead())
        {
            //Yup you Dead alright
        }*/

        ///else {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Rotate();

            }
            isActive();
        //}
    }

    //-----------------------------------------------------------------------------------------------------------

    void Rotate()
    {

        if (Primary)
        {
            Primary = false;
            Secondary = true;
        }

        else if (Secondary)
        {
            Secondary = false;
            Primary = true;
        }

    }

    //------------------------------------------------------------------------------------------------------------------

    void isActive()
    {

        if (Primary)
        {
            Rifle.SetActive(true);
            RifleBulletSpawner.SetActive(true);
            Pistol.SetActive(false);
            PistolBulletSpawner.SetActive(false);
        }

        else if (Secondary)
        {
            Rifle.SetActive(false);
            RifleBulletSpawner.SetActive(false);
            Pistol.SetActive(true);
            PistolBulletSpawner.SetActive(true);
        }

    }

    //---------------------------------------------------------------------------------------------------------------

    public GameObject getActiveGun()
    {
        if (Primary)
        {
            return Rifle.gameObject;
        }

        else
        {
            return Pistol.gameObject;
        }
    }

}
