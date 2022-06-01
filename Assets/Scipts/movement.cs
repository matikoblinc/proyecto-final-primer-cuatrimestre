using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movimientoWASD;
    Vector2 RotarMouse;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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

        Mathf.Clamp(RotarMouse.y, -45, 45);
        transform.localRotation = Quaternion.Euler(-RotarMouse.y * 2.5f, RotarMouse.x * 2.5f, 0);
       
    }
}
