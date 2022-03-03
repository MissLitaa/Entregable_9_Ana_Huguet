using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerGO : MonoBehaviour
{
    public static SceneManagerGO sceneMan;
    public  GameObject player;
    public Vector3 playerPos;
    public float x;
    public float y;
    public float z;

    private void Awake()
    {
        
        if (sceneMan == null)
        {
            sceneMan = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }
    public void LoadScene1()
    {
        playerPosition();
        SceneManager.LoadScene(sceneName: "Scene2");
    }

    public void LoadScene2()
    {
        playerPosition();
        SceneManager.LoadScene(sceneName: "Scene1");

    }

    public void playerPosition()
    {

       x = PlayerPrefs.GetFloat("x");
       y = PlayerPrefs.GetFloat("y");
       z = PlayerPrefs.GetFloat("z");
        playerPos = new Vector3(x, y, z);
    }
}
