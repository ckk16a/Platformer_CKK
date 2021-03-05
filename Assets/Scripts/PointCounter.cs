using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;
    public Text livesCounter;

    GameManager manny;

    // Start is called before the first frame update
    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        pointScoreCounter.text = "Score: " + manny.highScore;
        livesCounter.text = "Lives: " + manny.numLivesLeft;
    }
}
