using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    Button button;

    GameManager gameManager;

    public int difficulty;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void SetDifficulty()
    {
        Debug.Log("Clicked");
        gameManager.StartGame(difficulty);
    }
}
