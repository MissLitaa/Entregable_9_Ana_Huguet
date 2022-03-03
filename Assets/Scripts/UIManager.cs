using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text transicionesSesion;
    public TMP_Text transicionesUltimaSesion;
    public static UIManager UIManagerNoDelete;

    public float baseTransicion;
    private float sumaTransicion;
    public float totalTransiciones;

    private void Awake()
    {
        if (UIManagerNoDelete == null)
        {
            UIManagerNoDelete = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        string lastSessionTransitions = PlayerPrefs.GetString("LastSession");
        if (lastSessionTransitions != null)
        {
            transicionesUltimaSesion.GetComponent<TextMeshProUGUI>().text = lastSessionTransitions.ToString();
        }
    }


    public void UpdateTransicionScenes()
    {
        sumaTransicion++;
        totalTransiciones = baseTransicion + sumaTransicion;
        transicionesSesion.text = totalTransiciones.ToString();

    }

    public void UpdateTransicionUltima()
    {
        transicionesUltimaSesion.text = totalTransiciones.ToString();
    }

    public void SaveTransition()
    {
        //hacer placeholders de texto

        string LastSession = transicionesUltimaSesion.text.ToString();

        if (LastSession == "")
        {
            DataManager.Llamada.LastSession = transicionesUltimaSesion.GetComponent<TextMeshProUGUI>().text.ToString();
        }

        else
        {
            DataManager.Llamada.LastSession = transicionesUltimaSesion.text.ToString();
        }

        PlayerPrefs.SetString("LastSession", DataManager.Llamada.LastSession);
    }

}