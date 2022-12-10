using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string currentScene;
    public void LoadScene(string sceneName){
        GameObject player = GameObject.Find("Player");
        Debug.Log(player);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(player,SceneManager.GetSceneByName(sceneName));
        SceneManager.MoveGameObjectToScene(GameObject.Find("CameraHolder"),SceneManager.GetSceneByName(sceneName));
        SceneManager.UnloadScene("Facility");
        player.transform.position = new Vector3(617.2f, 10.89f, 306.5f);

    }
    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadScene(sceneName);
    }
    public void quitGame(){
        Application.Quit();
    }

}
