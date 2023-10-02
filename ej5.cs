using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5 : MonoBehaviour
{

    public GameObject cubo;
    public GameObject cilindro;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo");
        cilindro = GameObject.FindWithTag("cilindro");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Distancia del cubo: {Vector3.Distance(transform.position, cubo.transform.position)}");
        Debug.Log($"Distancia del cilindro: {Vector3.Distance(transform.position, cilindro.transform.position)}");
    }
}
