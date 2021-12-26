using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        //Move pipes
        transform.position += Vector3.left * speed * Time.deltaTime;
        //Destroys game object when out of sight
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
