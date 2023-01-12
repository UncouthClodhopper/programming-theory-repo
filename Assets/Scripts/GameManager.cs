using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text PlayerName;
    void Start()
    {
        PlayerName.text = "Player: " + MainManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
