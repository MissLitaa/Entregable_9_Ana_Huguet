using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerGO : MonoBehaviour
{

    private UIManager UIControl;
    public static Vector3 playerPosition;
    public GameObject player;
    
    public void LastPosition()
    {
        playerPosition = player.transform.position;
    }

    public void LoadScene1()
    {
        LastPosition();
        player.transform.position = playerPosition;
        SceneManager.LoadScene(sceneName: "Scene_2");
        UIControl.UpdateTransicionScenes();
        UIControl.UpdateTransicionUltima();
        player.gameObject.transform.position = playerPosition;
    }

    public void LoadScene2()
    {
        LastPosition();
        player.transform.position = playerPosition;
        SceneManager.LoadScene(sceneName: "Scene_1");
        UIControl.UpdateTransicionScenes();
        UIControl.UpdateTransicionUltima();
        player.gameObject.transform.position = playerPosition;
    }




}
