using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{

    public GameObject[] esferas;
    public int posMinDistancia = -1;
    // Start is called before the first frame update
    void Start()
    {
        esferas = GameObject.FindGameObjectsWithTag("esfera_2");
        float[] distancias = new float[esferas.Length];
        float maxDistancia = -1;
        float minDistancia = 10000;
        int posMaxDistancia = -1;
        for (int i = 0; i < esferas.Length; i++) {
          distancias[i] = Vector3.Distance(transform.position, esferas[i].transform.position);
          if (distancias[i] > maxDistancia) {
            maxDistancia = distancias[i];
            posMaxDistancia = i;
          }
          if (distancias[i] < minDistancia) {
            minDistancia = distancias[i];
            posMinDistancia = i;
          }
        }
        esferas[posMaxDistancia].transform.position = new Vector3(esferas[posMaxDistancia].transform.position.x, 
                esferas[posMaxDistancia].transform.position.y + 0.5f, esferas[posMaxDistancia].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
            Color randomColor = new Color(randomRed, randomGreen, randomBlue);
            esferas[posMinDistancia].GetComponent<Renderer>().material.color = randomColor;
        }
    }
}
