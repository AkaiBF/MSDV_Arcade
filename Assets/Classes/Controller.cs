using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private bool left = false;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.name == "LPad")
        {
            this.left = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int direction = 0;
        string player = "Player 1";
        if (!left) player = "Player 2";
        direction = Input.GetAxis(player) > 0 ? 1 : Input.GetAxis(player) < 0 ? -1 : 0;
        this.GetComponent<Transform>().Translate(direction * speed * Vector3.up);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Upgrade") {
            Debug.Log(col.gameObject.GetComponent<Upgrade>().assignedUpgrade);
            col.gameObject.GetComponent<Upgrade>().Activate();
            Destroy(col.gameObject);
        }
    }
}
