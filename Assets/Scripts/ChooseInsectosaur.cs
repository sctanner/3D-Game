using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseInsectosaur : MonoBehaviour
{
    // The key that the player must press to change scenes
    public KeyCode keyToPress = KeyCode.Space;

    // The distance at which the prompt to press the key will appear
    public float promptDistance = 5.0f;

    // The UI text element that will display the prompt
    public TMP_Text promptText;

    public Canvas promptCanvas;

    private Transform player;

    public string info;

    public string insectosaur;

    void Start()
    {
        // Get the player's transform component
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        
        // Set the initial text of the prompt to an empty string
        promptText.text = "Press 'G' ";
    }
    void Update()
    {
        if(GameObject.FindWithTag("PlayerWithInsectosaur") == null)
        {
            // Calculate the distance between the player and this game object
            float distance = Vector3.Distance(player.position, transform.position);
            // Check if the player is within the prompt distance
            if (distance <= promptDistance)
            {
                promptText.text = info;
                // Display the prompt to press the key
                promptText.enabled = true;
                
                // Check if the player is pressing the correct key
                if (Input.GetKeyDown(keyToPress))
                {
                    GameObject.Find("Click").GetComponent<AudioSource>().Play();
                    player.tag = "PlayerWithInsectosaur";
                    promptText.text = "You have chosen " + insectosaur + "! Exit the building";
                    gameObject.SetActive(false);
                    
                }
            }
            else
            {
                // Clear the prompt text
                promptText.enabled = false;
            }
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3.0f);
    }
}
