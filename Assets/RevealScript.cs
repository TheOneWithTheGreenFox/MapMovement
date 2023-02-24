using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealScript : MonoBehaviour
{
    public bool transparent = false;
    [SerializeField] private MeshRenderer mesh;
    public Material solidMat;
    public Material transMat;


    private void Start()
    {
        transparent = false;
        mesh = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        if (transparent)
        {
            mesh.material = solidMat;
            transparent = false;
        }
        else
        {
            mesh.material = transMat;
            transparent = true;
        }
    }
}
