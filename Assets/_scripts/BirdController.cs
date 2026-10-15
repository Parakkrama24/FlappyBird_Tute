using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float jumpVelocityForce = 5f;
    [SerializeField] private GameObject GameOverPanal;

    private Rigidbody2D rb2d;

    bool isMouseClicked = false;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isMouseClicked = Input.GetMouseButtonDown(0);

        if (isMouseClicked)
        {
            rb2d.linearVelocity = new Vector2(0,jumpVelocityForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ScoreTrigger"))
        {
            Debug.Log("Score");
            GameManger.instance.AddPoint();
        }
        else
        {
            Debug.Log("Game Over");
           GameManger.instance.GameOver();
        }
    }
}
