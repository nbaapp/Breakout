using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public GameLogicScript logic;
    public AudioSource blipSFX;
    public float speed = 200;
    public float speedIncrement = 5;
    public Vector2 ballVelocity;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<GameLogicScript>();

        ballVelocity = Random.onUnitSphere * speed * Time.deltaTime;
        MyRigidBody.velocity = ballVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -25)
        {
            Destroy(gameObject);
            Debug.Log("Ball Deleted");
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        blipSFX.Play();
        if (MyRigidBody.velocity.x >= 0 && MyRigidBody.velocity.y >= 0)
        {
            MyRigidBody.velocity += new Vector2(speedIncrement, speedIncrement);
        }
        else if (MyRigidBody.velocity.x >= 0 && MyRigidBody.velocity.y < 0)
        {
            MyRigidBody.velocity += new Vector2(speedIncrement, -speedIncrement);
        }
        else if (MyRigidBody.velocity.x < 0 && MyRigidBody.velocity.y < 0)
        {
            MyRigidBody.velocity += new Vector2(-speedIncrement, -speedIncrement);
        }
        else if (MyRigidBody.velocity.x < 0 && MyRigidBody.velocity.y >= 0)
        {
            MyRigidBody.velocity += new Vector2(-speedIncrement, speedIncrement);
        }
    }
}
