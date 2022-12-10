using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadMultipleScenes : MonoBehaviour
{
    // The name of the scene to load
    public string sceneName;
    public int currentWaypoint;
    // The path to the file that contains the dialogue lines
    public string fileName;
    public string currentScene;
    // Called when the scene is loaded
    void Start()
    {
        var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        op.completed += (x) => {
            GameObject dialogueCanvas = GameObject.Find("DialogueCanvas");
            DialogueUI dialogueUI = dialogueCanvas.GetComponent<DialogueUI>();
            dialogueUI.filePath = fileName;
            dialogueUI.currentScene = currentScene;
        };
    }
}

