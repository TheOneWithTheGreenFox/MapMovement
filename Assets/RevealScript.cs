using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealScript : MonoBehaviour
{
    public bool transparent = false;
    private SpriteRenderer sprite;

    private void Start()
    {
        transparent = false;
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (transparent)
        {
            sprite.color = new Color(0, 0, 0, 1);
            transparent = false;
        }
        else
        {
            sprite.color = new Color(0, 0, 0, 0);
            transparent = true;
        }
    }
}
