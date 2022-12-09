using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public void LoadScene(string sceneName){
        RenderSettings.ambientLight = Color.white;
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame(){
        Application.Quit();
    }



}
