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
    [SerializeField]
    private int forceMin;
    [SerializeField]
    private int forceMax;
    [SerializeField]
    private GameObject maskResizer;

    private Vector2 mousePos;
    private bool holdFlag = false;
    private int force;
    private float startMaskXScale;
    private float startMaskYScale;

    private Transform cannonTrans;
    private Transform maskTrans;
    private GameObject projectileInstance;

    private void Awake()
    {
        BallDropperManager.Player = this;
        cannonTrans = cannon.transform;
        force = forceMin;
        maskTrans = maskResizer.transform;
        startMaskXScale = maskTrans.localScale.x;
        startMaskYScale = maskTrans.localScale.y;
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
            holdFlag = true;
            maskResizer.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            holdFlag = false;
            projectileInstance = Instantiate(projectile, projectileSpawn.transform);
            projectileInstance.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(force, 0));
            force = forceMin;
            projectileInstance.transform.parent = BallDropperManager.UIManager.GetPlayPanel().transform;
            maskTrans.localScale = new Vector2(startMaskXScale, startMaskYScale);
            maskResizer.SetActive(false);
        }

        if (holdFlag == true)
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

            if (mousePos.y - Input.mousePosition.y >= 0.1 && force < forceMax)
            {
                force += 10;
                maskTrans.localScale = new Vector2(maskTrans.localScale.x + 40, startMaskYScale);
            }
            else if ((Input.mousePosition.y - mousePos.y >= 0.1 && force > forceMin))
            {
                force -= 10;
                maskTrans.localScale = new Vector2(maskTrans.localScale.x - 40, startMaskYScale);
            }

        }
    }
}
