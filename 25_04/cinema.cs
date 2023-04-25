using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cinema : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    [Header("Setup")]
    public TMP_InputField Dia;
    public TMP_InputField Idade;
    public TMP_InputField Preco;
    public TMP_Text Resultado;
    double dia;
    double idade;
    double preco;
    double desconto;

    public void Desconto()
    {
        clicSFX.Play();
        dia = double.Parse(Dia.text);
        idade = double.Parse(Idade.text);
        preco = double.Parse(Preco.text);

        if(dia == 3)
        {
            if(idade<15 && idade>0)
            {
                desconto = preco * 0.25;
                Resultado.text = "seu ingresso custa " + desconto + " reais";
                
            }

            else
            {
                desconto = preco * 0.5;
                Resultado.text = "seu ingresso custa " + desconto + " reais";
            }

        }
        
        else
        {
            if(idade<15)
            {
                desconto = preco * 0.5;
                Resultado.text = "seu ingresso custa " + desconto + " reais";
            }

            else
            {
                desconto = preco;
                Resultado.text = "seu ingresso custa " + desconto + " reais";
            }
        }

    }



}
