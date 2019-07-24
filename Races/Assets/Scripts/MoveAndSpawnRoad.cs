using UnityEngine;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed = 3f;
    public GameObject road;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -6.5f)
        {
            Instantiate(road, new Vector3(0, 8.1f, 12f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
