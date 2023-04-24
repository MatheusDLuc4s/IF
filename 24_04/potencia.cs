using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class potencia : MonoBehaviour
{
    [Header("Setup")]
    public TMP_InputField Base;
    public TMP_InputField Expoente;
    public TMP_Text Conta;
    double x;
    double y;
    double results;

    public void Potencial()
    {
        x = double.Parse(Base.text);
        y = double.Parse(Expoente.text);
        results = x;

        if(y == 0)
        {
            results = 1;
            Conta.text = "O numero " + x + " elevado a " + y + " é : " + results;
        }

        else
        {
           if(y == 1)
           {
                results = x;
                Conta.text = "O numero " + x + " elevado a " + y + " é : " + results;
           }
           else
                for(int i = 1; i < y; i++)
                {
                    results = results * x;
                }

            Conta.text = "O numero " + x + " elevado a " + y + " é : " + results; 

        } 
    }
}
