using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //Acceder a DataManager desde cualquier otro script.

    public static DataManager Llamada;
   

    private void Awake()
    {
        //Miramos si ya hay Llamada en escena, si la hay, no sobreescribimos los datos.

        if (Llamada !=null)
        {
            Destroy(gameObject);
            return;
        }

        Llamada = this;
        DontDestroyOnLoad(gameObject);
    }

    

}
