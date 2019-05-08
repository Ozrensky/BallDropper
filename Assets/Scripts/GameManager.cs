using System.Collections;
using System.Collections.Generic;
using BallDropper;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        BallDropperManager.GameManager = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
