using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tv : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    [Header("Setup")]
    public TMP_InputField Tv;
    public TMP_Text Pesquisa;

    int ctv;

    public void Canais()
    {
        clicSFX.Play();
        ctv = int.Parse(Tv.text); 

        switch (ctv)
        {
            case 2:
                Pesquisa.text = "SBT";
                break;
            case 4:
                Pesquisa.text = "Band";
                break;
            case 6:
                Pesquisa.text = "RedeTV";
                break;
            case 9:
                Pesquisa.text = "Record";
                break;
            case 13:
                Pesquisa.text = "Globo";
                break;
            default:
                Pesquisa.text = "Canal Invalido";
                break;
        }
    }
}
