using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        count++;
        if(count == 1000) {
            GameObject ball = GameObject.FindWithTag("ball");
            GameObject upgradeBall = Instantiate(ball);
            upgradeBall.tag = "Upgrade";
            upgradeBall.GetComponent<Transform>().position = new Vector2(0f, 0f);
            Rigidbody2D rb = upgradeBall.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)));
            rb.gravityScale = 0;
            upgradeBall.AddComponent(typeof(Upgrade));
            count = 0;
        }
    }
}
