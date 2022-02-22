using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGO : MonoBehaviour
{
    public GameObject UIControl;
    public static Vector3 playerPosition;

    void Start()
    {
        
    }
    void LastPosition()
    {
        playerPosition = transform.position;
    }

    void LoadScene1()
    { 
        Invoke("LastPosition", 1);
        SceneManager.LoadScene(sceneName: "Scene_2");
        Invoke("UpdateTransicionScenes", 1);
        transform.position = playerPosition;
    }

    void LoadScene2()
    {
        Invoke("LastPosition", 1);
        SceneManager.LoadScene(sceneName: "Scene_1");
        Invoke("UpdateTransicionScenes", 1);
        transform.position = playerPosition;
    }

    

  
}
