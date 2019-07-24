using UnityEngine;

public class MoveCars : MonoBehaviour
{
    public float speed = 2f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -5.5)
        {
            Destroy(gameObject);
        }
    }
}
