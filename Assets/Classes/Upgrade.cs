using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum IUpgrades {
    Interfaz,
    Accelerator,
    Inverter,
    Cannon,
    Gravity,
    Clones
}




public class Upgrade : MonoBehaviour
{
    public GameObject ball;
    public IUpgrades assignedUpgrade;
    public Sprite acceleratorSprite;
    public Sprite gravitySprite;

    // Start is called before the first frame update
    void Start()
    {
        IUpgrades[] allUpgrades = (IUpgrades[])IUpgrades.GetValues(typeof(IUpgrades));
        assignedUpgrade = allUpgrades[UnityEngine.Random.Range(0, allUpgrades.Length)];
        Debug.Log("Balls/" + assignedUpgrade);
        Sprite sprite = Resources.Load<Sprite>("Balls/" + assignedUpgrade);
        Debug.Log("Sprite -> " + sprite);
        Debug.Log("Lanzando " + assignedUpgrade);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    public void Activate() {
        ball = GameObject.FindWithTag("ball");
        switch(assignedUpgrade) {
            case IUpgrades.Interfaz:
            break;
            case IUpgrades.Accelerator:
                ball.GetComponent<Rigidbody2D>().AddForce(ball.GetComponent<Rigidbody2D>().velocity.normalized);
            break;
            case IUpgrades.Inverter:
                ball.GetComponent<Rigidbody2D>().velocity = (-1) * ball.GetComponent<Rigidbody2D>().velocity;
            break;
            case IUpgrades.Cannon:
                Vector2 velocity = ball.GetComponent<Rigidbody2D>().velocity;
                ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocity.x, 0).normalized);
            break;
            case IUpgrades.Gravity:
                ball.GetComponent<Rigidbody2D>().gravityScale = 1f;
            break;
            case IUpgrades.Clones:
            break;
        }
    }
}
