using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public CircleCollider2D cc;
    public int score;
    
    public GameObject coleta;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        cc = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            cc.enabled = false;
            coleta.SetActive(true);

            GameManager.instance.totalScore += score;
            
            Destroy(gameObject, 0.3f);
            

        }
    }
}
