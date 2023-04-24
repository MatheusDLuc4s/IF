using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class maior : MonoBehaviour
{
    [Header("Setup")]
    public TMP_InputField Num1;
    public TMP_InputField Num2;
    public TMP_Text Maior;
    double num1;
    double num2;


    public void Verificar()
    {
        num1 = double.Parse(Num1.text);
        num2 = double.Parse(Num2.text);

        if(num1 > num2)
        {
            Maior.text = "O maior numero é " + num1;
                
        }

        else
        {
            Maior.text = "O maior numero é " + num2;
        }

        

    }
}
