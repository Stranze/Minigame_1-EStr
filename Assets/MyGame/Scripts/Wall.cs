using UnityEngine;

public class Wall : MonoBehaviour {

    Rigidbody2D rb;
    float moveSpeed = 2.0f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DestroyLine")
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
