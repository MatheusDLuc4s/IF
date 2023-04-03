using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabuada : MonoBehaviour
{
    public int numBase=5;
    
    void Start()
    {   
        for(int i=0; i <= 10; i++)
        {
            print(numBase + " x " + i + " = " + numBase*i);
        }

    } 
}
