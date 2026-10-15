using UnityEngine;

public class PipSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private float offcet = 0.5f;


    private Vector3 pipPosition;

    private float timer = 0f;

    void Start()
    {
        SpawnPipe();
    }


    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    public void SpawnPipe()
    {
        float randomYvalue= Random.Range(offcet, -offcet);
        pipPosition= new Vector3(transform.position.x, randomYvalue, transform.position.z);
        Instantiate(pipePrefab, pipPosition, Quaternion.identity);
    }
}
