using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI transicionesSesion;
    public TextMeshProUGUI transicionesUltimaSesion;
    public float baseTransicion;
    public float sumaTransicion = 1f;
    public float totalTransiciones;

    void UpdateTransicionScenes()
    {
        totalTransiciones = baseTransicion + sumaTransicion;
        transicionesSesion.text = $"Transiciones entre escenas: {totalTransiciones}";
        
    }

    void UpdateTransicionUltima()
    {
        transicionesUltimaSesion.text = $"Transiciones en la última sesión: {totalTransiciones}";
    }

}
