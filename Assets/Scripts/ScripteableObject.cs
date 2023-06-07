using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/New Weapon")]
public class ScripteableObject : ScriptableObject
{
    //nombre
    public string weaponName;
    //descripcion
    public string weaponDescription;
    //Sprite
    public Sprite weaponSprite;
    //Daño
    public float weaponDamage;
    //Daño Magico
    public float weaponMagicDamage;
    //Tipo de arma 0 espada o 1 escudo (doble inventario)
    public float weaponType;
}
