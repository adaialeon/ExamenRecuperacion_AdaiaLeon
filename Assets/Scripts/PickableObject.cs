using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public ScripteableObject weapon;

    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        sRenderer.sprite = weapon.weaponSprite;
    }

}
