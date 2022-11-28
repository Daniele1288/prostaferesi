using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static float x;
    public static float y;


    private void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.position = new Vector2(transform.position.x + (5f * Time.deltaTime), transform.position.y);
        }

        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.position = new Vector2(transform.position.x - (5f * Time.deltaTime), transform.position.y);
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y+ (5f * Time.deltaTime));
        }

        if(Input.GetAxis("Vertical") < 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - (5f * Time.deltaTime));
        }

    }
}
