using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour {

    

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

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
        {
            //fireGun.PlayOneShot(gunFireSound, 1f);
            Attack();
        }

        if (!InAction)
        {
            InAction = false;
        }

        if (/*!GetComponent<Animation>().isPlaying && gunFireAnim*/ gunFiring)
        {
            gunFiring = false;
            InAction = false;
            bullet.SetActive(false);
            needReload = true;
            FireProjectile();
        }

        if (needReload)
        {
            Reload();
        }

    }

    void Attack()
    {
        //InAction = true;
        gunFiring = true;
        /*for later use if time presents itself
        GetComponent<Animation>().CrossFade(gunFire.name);
        */

    }

    void FireProjectile()
    {

        projectile = (GameObject)Instantiate(bullet, ShotSpawn.transform.position, ShotSpawn.gameObject.transform.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Debug.Log("show spawn reached");
    }

    public GameObject getProjectile()
    {
        return projectile;
    }

    void Reload()
    {
        

    }
}
