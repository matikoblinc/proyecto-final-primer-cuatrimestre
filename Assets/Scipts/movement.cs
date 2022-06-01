using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public int FOV1;

    public Image imagen;
    public GameObject Arma;

    void Start()
    {
        imagen.gameObject.SetActive(false);
    }

 
    void Update()
    {
        RaycastHit Adestruir; 

        if (Input.GetMouseButton(1))
        {
            Camera.main.fieldOfView = FOV1;
            imagen.gameObject.SetActive(true);
            Arma.gameObject.SetActive(false);
        }
        else
        {
            Camera.main.fieldOfView = 60;
            imagen.gameObject.SetActive(false);
            Arma.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
           if (Physics.Raycast(transform.position, transform.forward, out Adestruir, 70))
            {
                string nombre = Adestruir.collider.gameObject.name;
            }

        }

    }
}
