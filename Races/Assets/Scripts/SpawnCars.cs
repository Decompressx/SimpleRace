using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { -1.16f, -0.41f, 0.39f, 1.17f };
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, positions.Length)], 6f, 1f),
                Quaternion.Euler(new Vector3(90, 180, 0))
                ) ;
            yield return new WaitForSeconds(1.5f);
        }
    }
}
