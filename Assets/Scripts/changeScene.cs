using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadScene(sceneName);
    }
    public void quitGame(){
        Application.Quit();
    }



}
