using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartGame : MonoBehaviour
{
    [SerializeField] Button startGame;

    void Start()
    {
        startGame.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }
}
