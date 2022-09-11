using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goals : MonoBehaviour
{
    private bool Player1 = false;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        this.Player1 = gameObject.name == "LGoal";
        
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.name == "Ball") {
            int a = int.Parse(score.text.Split(' ')[0]);
            int b = int.Parse(score.text.Split(' ')[2]);
            if(Player1) {
                a++;
            } else {
                b++;
            }
            score.text = (a + " - " + b);
            if(a == 21 || b == 21) GameObject.FindGameObjectWithTag("Respawn").GetComponent<GameManager>().Pause();
            else GameObject.FindGameObjectWithTag("Respawn").GetComponent<GameManager>().ResetBall();
        }
        if(col.gameObject.tag == "Upgrade") {
            Destroy(col.gameObject);
        }
    }
}
