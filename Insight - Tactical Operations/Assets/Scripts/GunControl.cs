using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class GunControl : NetworkBehaviour {

    

    /* //sound plug-ins
    public AudioClip gunFireSound;
    private AudioSource fireGun;
    */
    public GameObject Gun;
    public GameObject bullet;
    public GameObject ShotSpawn;
    GameObject projectile;
    

    private GameObject PlayerObj;

    public Transform Player;
    private Camera PlayersCamera;

    /* //gun fire animation plug-ins
    public AnimationClip gunFireAnim;
    public AnimationClip reloadAnim;
    */

    public float Damage;
    public float bulletSpeed;
    public int AmmoCount;

    bool InAction = false;
    bool gunFiring = false;
    bool needReload = false;

    // Use this for initialization
    void Start()
    {
        //fireGun = GetComponent<AudioSource>();
    }

    //-----------------------------------------------------------------------------------------------------------


    // Update is called once per frame
    void Update()
    {
        if (ActiveGun())
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
            {
                //fireGun.PlayOneShot(gunFireSound, 1f);
                Attack();
            }

            if (/*!GetComponent<Animation>().isPlaying && gunFireAnim*/ gunFiring)
            {
                gunFiring = false;
                InAction = false;

                needReload = true;
                CmdFireProjectile();
            }


            if (!InAction)
            {
                InAction = false;
            }


            if (needReload)
            {
                Reload();
            }
        }

    }

    //-------------------------------------------------------------------------------------------------------------------

    void Attack()
    {
        //InAction = true;
        gunFiring = true;
        /*for later use if time presents itself
        GetComponent<Animation>().CrossFade(gunFire.name);
        */

    }

    //-------------------------------------------------------------------------------------------------------------------------
    [Command]
    void CmdFireProjectile()
    {

        projectile = (GameObject)Instantiate(bullet, ShotSpawn.transform.position, ShotSpawn.gameObject.transform.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

        //spawns network bullets
        NetworkServer.Spawn(projectile);

        Debug.Log("show spawn reached");
    }

    //---------------------------------------------------------------------------------------------------------------------

    public GameObject getProjectile()
    {
        return projectile;
    }

    void Reload()
    {
        

    }

    //------------------------------------------------------------------------------------------------------------------

    private bool ActiveGun()
    {
        if(GetComponent<SwapWeapons>().getActiveGun() == Gun.gameObject)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

}
