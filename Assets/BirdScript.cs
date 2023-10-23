using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // Connect with Rigidbody 2D
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Game Object (Bird) bypasses for each new pipe with tag 'Logic'???
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; // Game Object will go by vector x
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Pipe is solid object and not set to be triggered
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
