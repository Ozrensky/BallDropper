using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallDropper
{
    public static class BallDropperManager
    {
        private static GameManager gameManager;
        public static GameManager GameManager
        {
            get
            {
                if (gameManager == null)
                {
                    Debug.Log("GameManager doesn't exist!");  
                }
                return gameManager;
            }
            set { gameManager = value; }
        }

        private static UIManager uiManager;
        public static UIManager UIManager
        {
            get
            {
                if (uiManager == null)
                {
                    Debug.Log("UIManager doesn't exist!");
                }
                return uiManager;
            }
            set { uiManager = value; }
        }

        private static SoundManager soundManager;
        public static SoundManager SoundManager
        {
            get
            {
                if (soundManager == null)
                {
                    Debug.Log("SoundManager doesn't exist!");
                }
                return soundManager;
            }
            set { soundManager = value; }
        }

        private static SaveManager saveManager;
        public static SaveManager SaveManager
        {
            get
            {
                if (saveManager == null)
                {
                    Debug.Log("SaveManager doesn't exist!");
                }
                return saveManager;
            }
            set { saveManager = value; }
        }
    }
}

