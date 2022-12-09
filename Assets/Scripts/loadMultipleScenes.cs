using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadMultipleScenes : MonoBehaviour
{
// The names of the scenes to load
    public string scene2Name;

    void Start()
    {
        // Load the second scene in the foreground
        SceneManager.LoadScene(scene2Name, LoadSceneMode.Additive);

        // Set the second scene as the active scene
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(scene2Name));
    }
}
