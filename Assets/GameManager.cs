using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        this.ResetBall();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {
            Pause();
        }   
    }

    public void ResetBall() {
        this.ball = GameObject.FindGameObjectWithTag("ball");
        this.ball.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
        rb.gravityScale = 0;
    }

    public void Pause() {
        if(Time.timeScale == 1) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
