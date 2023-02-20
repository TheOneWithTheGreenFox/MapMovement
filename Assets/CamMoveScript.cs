using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveScript : MonoBehaviour
{
    public float moveAmount;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //up
            transform.localPosition += new Vector3(0, moveAmount);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //down
            transform.localPosition += new Vector3(0, -moveAmount);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            //left
            transform.localPosition += new Vector3(-moveAmount, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //right
            transform.localPosition += new Vector3(moveAmount, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //counter clockwise
            transform.Rotate(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //clockwise
            transform.Rotate(0, 0, -90);
        }
    }
}
