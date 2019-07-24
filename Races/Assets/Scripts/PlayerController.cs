using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public Transform menu;
    int score;
    public Text scoreText;

    private void Awake()
    {
        score = 0;
        scoreText.text = "Score:" + score.ToString();
    }

    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToViewportPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y,transform.position.z);
        
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 direction = new Vector3(horizontal, 0, 0);
        transform.Translate(direction.normalized * Time.deltaTime * speed);

        UpdateScore();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
        }
    }

    void UpdateScore()
    {
        if (Time.timeScale!=0)
        {
            score += 1;
            scoreText.text = "Score:" + score.ToString();
        }        
    }
}
