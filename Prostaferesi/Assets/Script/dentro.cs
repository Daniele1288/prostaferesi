using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dentro : MonoBehaviour
{
    SpriteRenderer render;
    public GameObject player;
    CircleCollider2D playerCollider;

    private void Awake() 
    {
        render = GetComponent<SpriteRenderer>();
        playerCollider = player.GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.name == "Player")
        {
                render.sortingOrder = 5;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.name == "Player")
        {
            render.sortingOrder = 3;
        }
    }
}
