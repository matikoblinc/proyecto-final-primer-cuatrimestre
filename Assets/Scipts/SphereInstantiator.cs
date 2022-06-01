using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInstantiator : MonoBehaviour
{
    public GameObject Sphere1;
    int CantSpheres;

    void Start()
    {
        
    }


    void Update()
    {
        if (CantSpheres < 4)
        {
            Instantiate(Sphere1, new Vector3(Random.Range(-14, 14), Random.Range(19, -19), Random.Range(50, 10)), Quaternion.Euler(Random.Range(0, 360), 0, 0));
            CantSpheres++;
        }
    }
}
