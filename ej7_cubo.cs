using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7_cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
            Color randomColor = new Color(randomRed, randomGreen, randomBlue);
            GetComponent<Renderer>().material.color = randomColor;
        }
    }
}
