using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shapes : MonoBehaviour
{
    
    public int CurrentText = 0;
    private GameManager gameManager;
    public int shapeValue;
    public static Shapes ShapeSelected;
    public Rigidbody playerRb;
    public int speed = 5;
    public GameObject plane;
    public string sceneName;
    

    // Start is called before the first frame update
    void Start()
    {
       
        ShapeSelected = this;

    }

    // Update is called once per frame
    void Update()
    {

        GetCurrentScene();
        playerRBFinder();
        MakeShapeMove();
    }

    

    private void OnMouseDown()
    {
        CurrentText = shapeValue;
        GameManager.Instance.UpdateShapeText(CurrentText); // Abstraction
        GameManager.Instance.ShapeProtag = CurrentText;

    }
    
   public void playerRBFinder()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    
    public virtual void MakeShapeMove()
    {
        
        if (GameManager.Instance.isGameActive && sceneName == "Game")
        {
            plane = GameObject.Find("Plane");
            float forwardinput = Input.GetAxis("Vertical");
            playerRb.AddForce(plane.transform.forward * forwardinput * speed);
        }
    }

    public void GetCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene(); // this is already done in GameManager, Possible to simplify?
        sceneName = currentScene.name;
    }
    
   
}
