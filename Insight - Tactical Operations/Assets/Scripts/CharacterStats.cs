using UnityEngine;
using System.Collections;

public class CharacterStats : MonoBehaviour
{

    //variables
    public int maxHealth;
    public int maxAmmo;
    public double healthRegenRate;
    //private double manaRegenPerLevel; //not used atm
    //private double healthRegenPerLevel;  //not used atm
    public int AP;
    public int AD;
    public int Armor;
    public int AmmoCount;
    public float moveSpeed = 10;
    public CharacterController controller;

    private int Health;
    private int Ammo;
    /* No mob character created currently / avalible plug-ins for mob when created
    public AnimationClip death;
    */

    //-----------------------------------------------------------------------------------------------------------

    // Use this for initialization
    void Start()
    {
        Health = maxHealth;
        Ammo = maxAmmo;
    }

    //-----------------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {

        statUpdateSequence();

    }

    //--------------------------------------------------------------------------------------------------------------

    //mob takes damage
    public void damageHealth(int damage)
    {
        Health = Health - damage;
        //Debug.Log(gameObject.name);
        //Debug.Log(Health + ". " + damage);
    }

    //---------------------------------------------------------------------------------------------------------------

    void statUpdateSequence()
    {
        if (Dead())
        {
            Death();
        }

        else
        {
            passiveRegen(healthRegenRate, incomingAmmo());
        }
    }

    //----------------------------------------------------------------------------------------------------

    public Transform getPosition()
    {
        return controller.transform;
        
    }

    //-------------------------------------------------------------------------------------------------

    public bool getGameObject(GameObject input)
    {
        if(input == controller.gameObject)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    //--------------------------------------------------------------------------------------------------------

    public void UpdateAmmo(int input)
    {
        Ammo = Ammo - input;
    }

    //----------------------------------------------------------------------------------------------------------

    public void passiveRegen(double healthRegen, int AmmoPickUP)
    {
        if (Ammo < maxAmmo)
        {
            if ((Ammo + AmmoPickUP) > maxAmmo)
            {
                Ammo = maxAmmo;
            }
            else
            {
                Ammo += AmmoPickUP;
            }
        }

        if (Health < maxHealth)
        {
            if((Health + healthRegen) > maxHealth)
            {
                Health = maxHealth;
            }
            else
            {
                Health += (int)healthRegen;
            }
        }

    }

    //--------------------------------------------------------------------------------------------------------

    void Death()
    {
        //not yet created, as no mob character has been made yet
        //GetComponent<Animation>().Play(death.name);

        Destroy(gameObject);

    }

    //----------------------------------------------------------------------------------------------------------

    //checks if dead
    bool Dead()
    {
        if (Health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //---------------------------------------------------------------------------------------------------------

    public int getAD()
    {
        return AD;
    }

    //------------------------------------------------------------------------------------------------------------

    public float getPercentHealth()
    {
        float output = (float)Health / (float)maxHealth;
        return output;
    }

    //------------------------------------------------------------------------------------------------------------

    public int getAmmoCount()
    {
        int output;
        if (Ammo > 0)
        {
            output = Ammo;
        }
        else
        {
            output = 0;
        }


        return output;
    }

    //------------------------------------------------------------------------------------------------------------

    public float getMoveSpeed()
    {
        return moveSpeed;
    }

    //------------------------------------------------------------------------------------------------------------

    public void Slow(float input)
    {
        moveSpeed = moveSpeed * input;
    }

    //--------------------------------------------------------------------------------------------------------------

    private int incomingAmmo()
    {
        return 0;
    }


}
