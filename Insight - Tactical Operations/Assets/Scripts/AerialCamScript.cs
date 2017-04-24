using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AerialCamScript : NetworkBehaviour {

    public GameObject SingleEnemy;

    public GameObject SpawnButton1;
    public GameObject SpawnButton2;
    public GameObject SpawnButton3;
    public GameObject SpawnButton4;
    public GameObject SpawnButton5;
    public GameObject SpawnButton6;
    public GameObject SpawnButton7;
    public GameObject SpawnButton8;
    public GameObject SpawnButton9;
    public GameObject SpawnButton10;
    public GameObject SpawnButton11;
    public GameObject SpawnButton12;
    public GameObject SpawnButton13;
    public GameObject SpawnButton14;
    public GameObject SpawnButton15;
    public GameObject SpawnButton16;
    public GameObject SpawnButton17;

    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;
    public GameObject SpawnPoint4;
    public GameObject SpawnPoint5;
    public GameObject SpawnPoint6;
    public GameObject SpawnPoint7;
    public GameObject SpawnPoint8;
    public GameObject SpawnPoint9;
    public GameObject SpawnPoint10;
    public GameObject SpawnPoint11;
    public GameObject SpawnPoint12;
    public GameObject SpawnPoint13;
    public GameObject SpawnPoint14;
    public GameObject SpawnPoint15;
    public GameObject SpawnPoint16;
    public GameObject SpawnPoint17;

    private bool singleTargetSpawn1 = false;

    public void SingleTroopSpawning()
    {
        SpawnButton1.SetActive(true);
        SpawnButton2.SetActive(true);
        SpawnButton3.SetActive(true);
        SpawnButton4.SetActive(true);
        SpawnButton5.SetActive(true);
        SpawnButton6.SetActive(true);
        SpawnButton7.SetActive(true);
        SpawnButton8.SetActive(true);
        SpawnButton9.SetActive(true);
        SpawnButton10.SetActive(true);
        SpawnButton11.SetActive(true);
        SpawnButton12.SetActive(true);
        SpawnButton13.SetActive(true);
        SpawnButton14.SetActive(true);
        SpawnButton15.SetActive(true);
        SpawnButton16.SetActive(true);
        SpawnButton17.SetActive(true);
        singleTargetSpawn1 = true;
    }


    void Start()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        singleTargetSpawn1 = false;
    }

    //------------------------------------------------------------------------------------------------------------------------------------

    void Update()
    {
        checkActiveButton();
    }

    //-------------------------------------------------------------------------------------------------------------------------------------

    private void locationGrab()
    {
        
        Vector3 ray = Input.mousePosition;
        Debug.Log(ray);
        if (ray.x != 0)
        {
            Vector3 targetLocation = new Vector3(ray.x, ray.y + 5, ray.z);
            Spawn(SingleEnemy, targetLocation);
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------------

    public void SpawnAtButton1()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint1.transform.position);
        
    }

    public void SpawnAtButton2()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint2.transform.position);

    }

    public void SpawnAtButton3()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint3.transform.position);

    }

    public void SpawnAtButton4()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint4.transform.position);

    }

    public void SpawnAtButton5()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint5.transform.position);

    }

    public void SpawnAtButton6()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint6.transform.position);

    }

    public void SpawnAtButton7()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint7.transform.position);

    }

    public void SpawnAtButton8()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint8.transform.position);

    }

    public void SpawnAtButton9()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint9.transform.position);

    }

    public void SpawnAtButton10()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint10.transform.position);

    }

    public void SpawnAtButton11()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint11.transform.position);

    }

    public void SpawnAtButton12()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint12.transform.position);

    }

    public void SpawnAtButton13()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint13.transform.position);

    }

    public void SpawnAtButton14()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint14.transform.position);

    }

    public void SpawnAtButton15()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint15.transform.position);

    }

    public void SpawnAtButton16()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint16.transform.position);

    }

    public void SpawnAtButton17()
    {
        SpawnButton1.SetActive(false);
        SpawnButton2.SetActive(false);
        SpawnButton3.SetActive(false);
        SpawnButton4.SetActive(false);
        SpawnButton5.SetActive(false);
        SpawnButton6.SetActive(false);
        SpawnButton7.SetActive(false);
        SpawnButton8.SetActive(false);
        SpawnButton9.SetActive(false);
        SpawnButton10.SetActive(false);
        SpawnButton11.SetActive(false);
        SpawnButton12.SetActive(false);
        SpawnButton13.SetActive(false);
        SpawnButton14.SetActive(false);
        SpawnButton15.SetActive(false);
        SpawnButton16.SetActive(false);
        SpawnButton17.SetActive(false);
        Spawn(SingleEnemy, SpawnPoint17.transform.position);

    }

    //----------------------------------------------------------------------------------------------------------------------------------------

    void checkActiveButton()
    {
        if (!singleTargetSpawn1)
        {
            SpawnButton1.SetActive(false);
        }
    }


    private void Spawn(GameObject mob, Vector3 locVec)
    {
        GameObject Enemy = (GameObject)Instantiate(mob, locVec, Quaternion.identity);
    }
}
