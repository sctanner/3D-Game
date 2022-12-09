using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerNearDoor : MonoBehaviour
{
    // The name of the scene to load
    public string sceneName;

    // The key that the player must press to change scenes
    public KeyCode keyToPress = KeyCode.Space;

    // The distance at which the prompt to press the key will appear
    public float promptDistance = 5.0f;

    // The UI text element that will display the prompt
    public TMP_Text promptText;

    public Canvas promptCanvas;

    private Transform player;

    void Start()
    {
        // Get the player's transform component
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        
        Debug.Log(player);
        // Set the initial text of the prompt to an empty string
        promptText.text = "Press \'E\' to exit the facility";
    }

    void Update()
    {
        // Calculate the distance between the player and this game object
        float distance = Vector3.Distance(player.position, transform.position);
        //Debug.Log("Distance: "+ distance);

        // Check if the player is within the prompt distance
        if (distance <= promptDistance)
        {
            // Display the prompt to press the key
            promptCanvas.enabled = true;
            
            // Check if the player is pressing the correct key
            if (Input.GetKeyDown(keyToPress))
            {
                // Load the scene with the specified name
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            // Clear the prompt text
            promptCanvas.enabled = false;
        }
    }
}