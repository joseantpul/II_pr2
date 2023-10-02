using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    private int[] randomValues = new int[10];

    private System.Random random = new System.Random();

    [SerializeField]
    public int minRange = 0;

    [SerializeField]
    public int maxRange = 25;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < randomValues.Length; i++) {
            randomValues[i] = random.Next(minRange, maxRange);
        }


    }

    // Update is called once per frame
    void Update()
    {
        int randomPos = random.Next(0, randomValues.Length - 1);

        randomValues[randomPos] = random.Next(minRange, maxRange + 1);

        for (int i = 0; i < randomValues.Length; i++)
        {
            if (randomValues[i] > 15) Debug.Log(randomValues[i]);
        }

    }
}