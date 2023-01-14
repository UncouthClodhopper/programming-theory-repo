using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : Shapes // Inheritance
{
    private int jumpForce = 50;
    

   
    // Start is called before the first frame update
    void Start()
    {
        playerRBFinder();
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentScene();
        JumpUp();
        MakeShapeMove();
    }
    void JumpUp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    public override void MakeShapeMove() // Polymorphism
    {
        if (GameManager.Instance.isGameActive && sceneName == "Game")
        {
            plane = GameObject.Find("Plane");
            float forwardinput = Input.GetAxis("Vertical") * 15;
            playerRb.AddForce(plane.transform.forward * forwardinput * speed);
        }
    }
}
