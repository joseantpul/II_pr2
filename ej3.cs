using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?app=desktop&v=zJvVhwaPT1g&ab_channel=LessBoringLectures
// https://docs.unity3d.com/ScriptReference/Vector3.html
public class ej3 : MonoBehaviour
{

    [SerializeField]
    public Vector3 vector1 = new Vector3(0.0f, 1.0f, 0.0f);

    [SerializeField]
    public Vector3 vector2 = new Vector3(1.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(vector1, vector2);
        float angle = Vector3.Angle(vector1, vector2);
        string msg = "Magnitud del vector 1: " + vector1.magnitude + "\nMagnitud del vector 2: " + vector2.magnitude;
        Debug.Log(msg);
        Debug.Log($"Distancia: {distance}");
        Debug.Log($"Ángulo: {angle}");
        if (vector1.y > vector2.y) {
            Debug.Log("el vector 1 esta a una altura mayor");
        } else {
            Debug.Log("el vector 2 esta a una altura mayor");
        }
    }
}
