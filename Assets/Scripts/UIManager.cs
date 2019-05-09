using System.Collections;
using System.Collections.Generic;
using BallDropper;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenuPanel;
    [SerializeField]
    private GameObject playPanel;
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private GameObject exitConfirmPanel;
    [SerializeField]
    private GameObject pauseMenuPanel;
    [SerializeField]
    private GameObject winScreenPanel;

    private void Awake()
    {
        BallDropperManager.UIManager = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPlay()
    {
        playPanel.SetActive(true);
    }

    public void HidePlay()
    {
        playPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
    }

    public void HideMainMenu()
    {
        mainMenuPanel.SetActive(false);
    }
}
