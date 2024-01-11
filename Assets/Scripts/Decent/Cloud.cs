using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 1f;
    public float boundary = -10f;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        if (transform.position.x < boundary)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
    }
}