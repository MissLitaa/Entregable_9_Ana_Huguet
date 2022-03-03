using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //Acceder a DataManager desde cualquier otro script.

    public static DataManager Llamada;
    public string LastSession;
    public static GameObject player;
    public float x;
    public float y;
    public float z;
   
    private void Awake()
    {
        //Miramos si ya hay Llamada en escena, si la hay, no sobreescribimos los datos.

        if (Llamada == null)
        {
            Llamada = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }

    public void Update()
    {
        x = player.transform.position.x;
        PlayerPrefs.SetFloat("x", x);
        y = player.transform.position.y;
        PlayerPrefs.SetFloat("y", y);
        z = player.transform.position.z;
        PlayerPrefs.SetFloat("z", z);
    }

 }
