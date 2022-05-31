using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movimientoWASD;
    public Vector2 RotarMouse;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate (0, 0, movimientoWASD);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate (0, 0, -movimientoWASD);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate (movimientoWASD, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate (-movimientoWASD, 0, 0);
        }

        RotarMouse.x += Input.GetAxis("Mouse X");
        RotarMouse.y += Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(-RotarMouse.y, RotarMouse.x, 0);
    }
}
