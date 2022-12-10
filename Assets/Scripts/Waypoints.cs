using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    public int currentDialogueLine;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {   
        GameObject waypoint = GameObject.Find("AddDialogue");
        waypoint.GetComponent<loadMultipleScenes>().currentWaypoint = current;
        if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            if((current==1 || current == 5) && GameObject.Find("DialogueCanvas")!=null){
                GameObject dialogue = GameObject.Find("DialogueCanvas");
                dialogue.GetComponent<Canvas>().enabled = true;
            }
            current++;
            if(current >= waypoints.Length)
            {
                current--;
            }
        }
        if(GameObject.Find("DialogueCanvas")!=null && GameObject.Find("DialogueCanvas").GetComponent<Canvas>().enabled == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        }
    }
}
