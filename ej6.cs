using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
{

    public GameObject cubo;
    public GameObject cilindro;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo"); // izquierda
        cilindro = GameObject.FindWithTag("cilindro"); // derecha
    }

    // Update is called once per frame
    void Update()
    {
        cilindro.transform.position = new Vector3(transform.position.x + 5, cilindro.transform.position.y, cilindro.transform.position.z);
        cubo.transform.position = new Vector3(transform.position.x - 5, cubo.transform.position.y, cubo.transform.position.z);
    }
}
