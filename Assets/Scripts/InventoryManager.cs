using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public static InventoryManager Instance;

    public ScripteableObject[] weapons;
    public ScripteableObject[] shields;
    //imagen y sprite arma
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
    //imagen y sprite escudo
    public Text[] shieldNames;
    public Image[] shieldSprites;

    void Awake() 
    {
        Instance = this;
    }
    //array
    public void AddWeapon(ScripteableObject weapon)
    {
        //variable para recorrer la array
        for( int i = 0; i < weapons.Length; i++)
        {
            //diferenciar el inventario al que va
            //invetario de las armas
            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.weaponName;
                    weaponsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
            //inventario de los escudos
            if(weapon.weaponType == 1)
            {
                if(shields[i] == null)
                {
                    shields[i] = weapon;
                    shieldNames[i].text = weapon.weaponName;
                    shieldSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
        }
    }
}

//wepons arrray y wepon el objeto