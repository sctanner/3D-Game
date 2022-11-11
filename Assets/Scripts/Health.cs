using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MAX_HEALTH = 100;
    public float currHealth;
    public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.transform.localScale = new Vector3((currHealth) / MAX_HEALTH, 1.0F, 1.0F);
        if(currHealth <= 0)
        {
            //add which scene
            SceneManager.LoadScene(sceneName: "");
        }
    }
}
