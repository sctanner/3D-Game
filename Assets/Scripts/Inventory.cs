using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    string insectosaur;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setInsectosaur(string insectosaur)
    {
        this.insectosaur = insectosaur;
    }
    string getInsectosaur()
    {
        return this.insectosaur;
    }

}
