using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text PlayerName;
    public List<string> TextToDisplay = new List<string>();
    public static MainUIScripts TextOnScripts;
    public TextMeshProUGUI ShapeDesc;

    void Start()
    {
        TextOnScripts = this;
        PlayerName.text = "Player: " + GameManager.Instance.playerName;
        TextToDisplay.Add("");
        TextToDisplay.Add("The cube is a three dimensional shape with 6 flat faces");
        TextToDisplay.Add("The sphere is a perfectly round, 3d, no corners shape");
        TextToDisplay.Add("The sphere is the best of both worlds, with a round exterior but two flat faces");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAs()
    {
        GameManager.Instance.PlayAs(); //   Abstraction
    }
    public void ExitGame()
    {
        GameManager.Instance.ExitGame(); // Abstraction
    }
}
