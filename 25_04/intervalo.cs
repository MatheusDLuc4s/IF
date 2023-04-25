using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class intervalo : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    [Header("Setup")]
    public TMP_InputField NumE;
    public TMP_InputField NumD;
    public TMP_Text Intervalo;
    int numE;
    int numD;
 
    public void inter()
    {
        clicSFX.Play();
        numE = int.Parse(NumE.text);
        numD = int.Parse(NumD.text);
        
        for(int i = numE + 1; i < numD; i++)
        {
            print(" " + i);
        } 

    }
}
