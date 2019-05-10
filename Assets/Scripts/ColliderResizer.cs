using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderResizer : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D collider;
    
    void Start()
    {
        collider = gameObject.GetComponent<BoxCollider2D>();
        collider.size = new Vector2(gameObject.GetComponent<RectTransform>().rect.width, gameObject.GetComponent<RectTransform>().rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
