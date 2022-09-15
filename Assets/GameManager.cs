using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject ball;
    public Canvas menu;
    public Canvas ajustesPausa;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        menu.gameObject.SetActive(false);
        ajustesPausa.gameObject.SetActive(false);
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
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
        } 
        else {
            Time.timeScale = 1;
            menu.gameObject.SetActive(false);
        } 
    }

    public void Restart() {
        score.text = "0 - 0";
        this.ResetBall();
        Pause();
    }

    public void ShowAjustes() {
        ajustesPausa.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }

    public void HideAjustes() {
        ajustesPausa.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }
}
