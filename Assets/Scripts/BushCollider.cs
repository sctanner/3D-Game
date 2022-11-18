using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {

        int randomNumber = Random.Range(0,20);
        if(randomNumber == 1)
        {
            gameObject.GetComponent<changeScene>().LoadScene("Battle");
        }

    }
}
