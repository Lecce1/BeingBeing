using UnityEngine;
using Random = UnityEngine.Random;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float length;
    [SerializeField] 
    private bool direction;

    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = transform.GetComponent<Rigidbody2D>();
        speed = Random.Range(1f, 5f);
        length = Random.Range(0.5f, 1.5f);
        rigid.gravityScale = Random.Range(1f, 3f);
        direction = Random.Range(0, 2) != 0;
    }

    void FixedUpdate()
    {
        float data = Mathf.Sin(Time.time * length) * speed;
        rigid.velocity = direction ? Vector3.right * data : Vector3.left * data;
    }
}
