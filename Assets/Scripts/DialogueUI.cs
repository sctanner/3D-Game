using UnityEngine;
using TMPro;
using System.IO;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private string[] dialogueLines;
    public string filePath;
    private int dialogueIndex = 0;
    private GameObject target;
    public string nextScene;
    private void Start() {

        dialogueLines = File.ReadAllLines(filePath);
        GetComponent<TypewriterEffect>().Run(dialogueLines[0], textLabel);
        dialogueIndex++;
        target = GameObject.Find("SceneControl");
    }

    void Update()
    {
        // Check if the space key has been pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if there are more dialogue lines to display

            if(dialogueIndex < dialogueLines.Length && string.IsNullOrEmpty(dialogueLines[dialogueIndex]))
            {
                dialogueIndex++;
            }
            if (dialogueIndex < dialogueLines.Length)
            {
                GetComponent<TypewriterEffect>().Run(dialogueLines[dialogueIndex], textLabel);
                // Increment the dialogue index
                dialogueIndex++;
            }
            if(dialogueIndex==dialogueLines.Length)
            {
                target.GetComponent<changeScene>().LoadScene(nextScene);
            }
        }
    }
}
