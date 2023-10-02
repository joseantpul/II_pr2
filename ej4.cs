using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform tf = GetComponent<Transform>();
        Debug.Log(tf.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
