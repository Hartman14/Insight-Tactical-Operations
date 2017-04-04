using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {
    
    private float PercentHealth; //current progress
    private int AmmoCount;
    public bool isFixed = false;
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60, 20);
    public Vector2 healthPos = new Vector2(20, 40);
    //public Texture2D Hud;
    public GUIStyle hudStyle;
    public Texture2D hpBar;
    public GameObject Character;

    void Start()
    {
        
    }

    //---------------------------------------------------------------------------------------------------------------------------------

    void OnGUI()
    {
        if (isFixed)
        {
            //GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
            //GUI.Box(new Rect(pos.x, pos.y, size.x, size.y), Hud, hudStyle);
            //draw the background:


            //draw the filled-in part:
            GUI.BeginGroup(new Rect(healthPos.x, healthPos.y, (float)((size.x * 0.435f) * PercentHealth), size.y * 0.1f));
            GUI.Box(new Rect(0, 0, size.x * 0.435f, size.y), hpBar, hudStyle);
            GUI.EndGroup();
            
            
            //GUI.EndGroup();
        }

        else
        {
            //GUI.Box(new Rect(Screen.width/3, Screen.height-125f, size.x, size.y), Hud, hudStyle);
            //draw the background:


            //draw the filled-in part:
            GUI.BeginGroup(new Rect((Screen.width/3) + 127, (Screen.height - 37), (float)((size.x * 0.435f) * PercentHealth), size.y * 0.1f));
            GUI.Box(new Rect(0, 0, size.x * 0.435f, size.y), hpBar, hudStyle);
            GUI.EndGroup();
            
            
        }

    }


    //--------------------------------------------------------------------------------------------------------------------------------

    void Update()
    {
        //for this example, the bar display is linked to the current time,
        //however you would set this value based on your desired display
        //eg, the loading progress, the player's health, or whatever.
        try
        {
            PercentHealth = Character.GetComponent<CharacterStats>().getPercentHealth();
            AmmoCount = Character.GetComponent<CharacterStats>().getAmmoCount();
            //Debug.Log(PercentHealth + ", " + PercentMana);
        }
        catch
        {

        }

        //barDisplay = MyControlScript.staticHealth;
    }
}
