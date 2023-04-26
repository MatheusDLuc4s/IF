using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class media : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    [Header("Setup")]
    public TMP_InputField Num;
    public TMP_Text Med;
    double num;
    double med;

    public void Media()
    {
        clicSFX.Play();
        med = 0;
        num = double.Parse(Num.text);
        for(int i = 0; i <= num; i++)
        {
            med = med + i;
        }

        med = med / num;
        Med.text = "A media da soma dos numeros de 0 até " + num + " é " + med;
    }
}
