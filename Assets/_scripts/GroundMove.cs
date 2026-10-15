using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private float groundWidth;

    void Start()
    {
        groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;

    }

   
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -groundWidth)
        {
            transform.position = transform.position + new Vector3(groundWidth * 2, 0, 0);
        }
    }
}
