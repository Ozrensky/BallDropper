using System.Collections;
using System.Collections.Generic;
using BallDropper;
using UnityEngine;

public class UIManager : MonoBehaviour
{
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
}
