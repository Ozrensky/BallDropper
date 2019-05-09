using System.Collections;
using System.Collections.Generic;
using BallDropper;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cannonPrefab;
    [SerializeField]
    private GameObject cannonSpawn;

    private GameObject cannonInstance;

    private enum GameState { MainMenu, Settings, Play, Pause};

    private GameState currentState;

    private void Awake()
    {
        BallDropperManager.GameManager = this;
        currentState = GameState.MainMenu;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPlay()
    {
        cannonPrefab = Instantiate(cannonPrefab, cannonSpawn.transform);
        currentState = GameState.MainMenu;
        BallDropperManager.UIManager.HideMainMenu();
        BallDropperManager.UIManager.ShowPlay();
    }
}
