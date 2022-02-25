using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI transicionesSesion;
    public TextMeshProUGUI transicionesUltimaSesion;
    public static UIManager UIManagerNoDelete;

    public float baseTransicion;
    public float sumaTransicion = 1f;
    public float totalTransiciones;
    
    private void Awake()
    {
        //Miramos si ya hay Llamada en escena, si la hay, no sobreescribimos los datos.

        if (UIManagerNoDelete != null)
        {
            Destroy(gameObject);
            return;
        }

        UIManagerNoDelete = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateTransicionScenes()
    {
        sumaTransicion++;
        totalTransiciones = baseTransicion + sumaTransicion;
        transicionesSesion.text = $"Transiciones entre escenas: {totalTransiciones.ToString()}";
        
    }

     public void UpdateTransicionUltima()
    {
        transicionesUltimaSesion.text = $"Transiciones en la última sesión: {totalTransiciones.ToString()}";
    }

}
