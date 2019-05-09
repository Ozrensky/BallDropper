using System.Collections;
using System.Collections.Generic;
using BallDropper;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject cannon;
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private GameObject projectileSpawn;
    [SerializeField]
    private int rotationArc;

    private Vector2 clickPos;
    private Vector2 mousePos;
    private bool flag = false;

    private Transform cannonTrans;

    private void Awake()
    {
        BallDropperManager.Player = this;
        cannonTrans = cannon.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flag = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            flag = false;
        }

        if (flag == true)
        {
            if (mousePos.x - Input.mousePosition.x >= 0.1 && (cannonTrans.eulerAngles.z < rotationArc / 2 + 2 || cannonTrans.eulerAngles.z > 360 - rotationArc / 2 + 2))
            {
                cannonTrans.eulerAngles = new Vector3(0, 0, cannonTrans.eulerAngles.z - 2f);
                mousePos = Input.mousePosition;
            }
            else if (Input.mousePosition.x - mousePos.x >= 0.1 && (cannonTrans.eulerAngles.z < rotationArc/2 - 2 || cannonTrans.eulerAngles.z > 360 - rotationArc / 2 - 2))
            {
                cannonTrans.eulerAngles = new Vector3(0, 0, cannonTrans.eulerAngles.z + 2f);
                mousePos = Input.mousePosition;
            }
        }
    }
}
