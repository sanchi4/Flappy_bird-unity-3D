using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public MoveGround Ground;
    public PipeSpawner PipeSpawner;
    public GameObject flappy;
    public float force=10f;
    
    void ChangeSpeed(float speed)
    {
        Ground.speed = speed;
        PipeSpawner.speed = speed;
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var rb = flappy.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
