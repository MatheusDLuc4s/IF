using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class intervalo : MonoBehaviour
{
    [Header("Setup")]
    public TMP_InputField NumE;
    public TMP_InputField NumD;
    public TMP_Text Intervalo;
    public float delay = 10f;
    int numE;
    int numD;
 
    public void inter()
    {
        numE = int.Parse(NumE.text);
        numD = int.Parse(NumD.text);
        
        for(int i = numE + 1; i < numD; i++)
        {
            print(" " + i);
        } 
        
    }
}
