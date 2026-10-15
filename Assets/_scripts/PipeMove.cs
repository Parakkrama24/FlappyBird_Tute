using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    [SerializeField] private float destroyXPos = -20f;
    
    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x <= destroyXPos)
        {
            Destroy(this.gameObject);
        }
    }
}
