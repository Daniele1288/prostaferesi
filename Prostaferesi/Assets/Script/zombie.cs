using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public float velocita = 2.5f;
    public bool allerta = false;

    float vx;
    float vy;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!allerta && time >= 1)
        {
            vx = Random.Range(0, velocita);
            vy = velocita-vx;
            time = 0;

            float quadrante = Random.Range(0,5);
            if(quadrante <= 1)
            {
                vx = vx * (-1);
                vy = vy * (-1);
            }
            else if(quadrante <= 2)
            {
                vx = vx * (-1);
            }
            else if(quadrante <= 3)
            {
                vy = vy * (-1);
            }
        }

        if(time < 1)
        {
            time += Time.deltaTime;
        }

        transform.position = new Vector2(transform.position.x + (vx * Time.deltaTime), transform.position.y + (vy * Time.deltaTime));

        allerta = false;
    }

    private void OnTriggerStay2D(Collider2D other)  // modificare la funzione in quanto il GameObject  non prende bene la direzione corretta
    {
        allerta = true;
        float playerx = player.x;
        float playery = player.y;

        float x = transform.position.x;
        float y = transform.position.y;

        vx = velocita / (1 + Mathf.Abs((playery - y))/Mathf.Abs((playerx - x)));
        vy = (velocita / (1 + Mathf.Abs((playery - y))/Mathf.Abs((playerx - x)))) * Mathf.Abs((playery - y))/Mathf.Abs((playerx - x));

        if(playerx < x)
        {
            vx = vx * (-1);
        }

        if(playery < y)
        {
            vy = vy * (-1);
        }
    }
}
