using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metade : MonoBehaviour
{
    [Header("Metade dos numeros")]
    public int qntNum;

    void Start()
    {
        float metade;
       
        while (qntNum <= 0)
        {
            metade = qntNum/2f;
            print("a metade de: " + qntNum + " é: " + metade);
            qntNum--;  
        }
    }

}
