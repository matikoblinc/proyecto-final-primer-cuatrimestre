using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public int FOV1;
    int Hits1;

    public Image imagen;

    public GameObject Arma;
    public GameObject camara;

    public Text LavelHists;
    public Text MissHit;

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
            if (Physics.Raycast(transform.position, camara.transform.forward, out Adestruir, 70))
            {
                string nombre = Adestruir.collider.gameObject.name;
                if (Adestruir.collider.gameObject.tag == "Esfera")
                {
                    Destroy(Adestruir.collider.gameObject);
                    SphereInstantiator.CantSpheres--;

                    Hits1++;

                    MissHit = GetComponent<Text>();
                    MissHit.color = Color.green;
                    MissHit.text = ("HIT!!");
                }
                else
                {
                    MissHit = GetComponent<Text>();
                    MissHit.color = Color.red;
                    MissHit.text = ("MISS");
                }
                Debug.Log(nombre);

                LavelHists.text = Hits1.ToString();
            }

        }

    }
}
