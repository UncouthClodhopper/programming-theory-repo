using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update




    public string playerName;
    public static GameManager Instance { get; private set; } // encapsulation
    public List<GameObject> SelectedShape;
    public bool isGameActive;
    public int ShapeProtag;
    private bool doSpawn = true;
    Vector3 spawnPosition = new Vector3(0, 10, 0);
    



    public void Awake()
    {
       if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Instance = this;
        
    }
   

    // Update is called once per frame
    void LateUpdate()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (doSpawn && isGameActive && sceneName == "Game")
        {
            Instantiate(SelectedShape[ShapeProtag - 1]);
            
            doSpawn = false;
            

            Debug.Log("It Worked!");
           

        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayAs()
    {
        SceneManager.LoadScene(2);
        isGameActive = true;
       
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        isGameActive = false;
        doSpawn = true;
    }
    public void UpdateShapeText(int numberOfText)
    {
        MainUIScripts.TextOnScripts.ShapeDesc.text = MainUIScripts.TextOnScripts.TextToDisplay[numberOfText];
    }
}
