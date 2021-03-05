using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicFail : MonoBehaviour
{
    GameManager manny;

    // Start is called before the first frame update
    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            //Deduct a life
            manny.numLivesLeft--;
            manny.highScore = 0;

            if(manny.numLivesLeft < 0){
                SceneManager.LoadScene("GameOver");
            } else {
                // use SceneManager to load the CURRENT scene again (a reset)
                // the LoadScene function just wants a NUMBER of the scene to load
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
