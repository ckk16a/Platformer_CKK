using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int highScore = 0;
    
    public int numLivesLeft = 3;


    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("MrManager");

        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
