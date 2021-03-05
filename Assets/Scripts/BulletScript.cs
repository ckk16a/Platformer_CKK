using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameManager manny;

    // Start is called before the first frame update
    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BadGuy")
        {
            manny.highScore++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
