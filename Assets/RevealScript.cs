using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealScript : MonoBehaviour
{
    public bool transparent = false;
    private MeshRenderer mesh;

    private void Start()
    {
        transparent = false;
        mesh = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        if (transparent)
        {
            mesh.enabled = true; //prite.color = new Color(0, 0, 0, 1);
            transparent = false;
        }
        else
        {
            mesh.enabled = true; //sprite.color = new Color(0, 0, 0, 0);
            transparent = true;
        }
    }
}
