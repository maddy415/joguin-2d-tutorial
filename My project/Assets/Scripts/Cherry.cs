using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    public GameObject coleta;

    private SpriteRenderer sr;

    private CircleCollider2D circle;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            circle.enabled = false;
            sr.enabled = false;
            coleta.SetActive(true);
            
            Destroy(gameObject, 0.5f);
        }
            
    }
}
