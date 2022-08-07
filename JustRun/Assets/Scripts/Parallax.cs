using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float depth = 1;
    PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float realVelocity = player.velocity.x / depth;
        
        Vector2 pos = transform.position;
        
        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -50)
        {
            pos.x = 50;
        }
        
        transform.position = pos;
    }
}
