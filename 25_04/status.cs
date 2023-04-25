using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class status : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    [Header("setup")]
    public GameObject points;
    public GameObject energy;
    public GameObject health;
    public Slider pointBar;
    public Slider energyBar;
    public Slider healthBar;
    public TMP_InputField Pontos;
    public TMP_InputField Energia;
    public TMP_InputField Vida;
    float pontos = 0f;
    float energia = 0f;
    float vida = 0f;

    void Start()
    {
        points.SetActive(false);
        energy.SetActive(false);
        health.SetActive(false);
    }

    void Update()
    {      
        pointBar.value = pontos;
        energyBar.value = energia;
        healthBar.value = vida;
    }

    public void Stats()
    {
        clicSFX.Play();
        pontos = float.Parse(Pontos.text);
        energia = float.Parse(Energia.text);
        vida = float.Parse(Vida.text);
        points.SetActive(true);
        energy.SetActive(true);
        health.SetActive(true);
    }
}
