using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuUIScriptRe : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;

    // Start is called before the first frame update


   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    


    public void SaveName()
    {
        playerName = inputField.text;
        GameManager.Instance.playerName = playerName;
    }

    public void StartGameDos()
    {
        GameManager.Instance.StartGame();
    }
}
