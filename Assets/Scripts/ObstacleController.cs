using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{ 
    [SerializeField]
    private int points;
    [SerializeField]
    private TextMeshPro pointsText;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Projectile")
        {
            ReducePoints();
        }
    }

    private void ReducePoints()
    {
        points -= 1;
        if (points == 0)
        {
            Destroy(this.gameObject);
        }
        pointsText.text = points.ToString();
    }
}
