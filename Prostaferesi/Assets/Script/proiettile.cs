using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proiettile : MonoBehaviour
{
    public float velocita = 10;

    Transform playerPosition = generalInfo.playerPosition;
    Transform mirinoPosition = generalInfo.mirinoPosition;

    float vx;
    float vy;

    // Start is called before the first frame update
    void Start()
    {
        float difX = mirinoPosition.position.x - playerPosition.position.x; //distanza x tra mirino e player
        float difY = mirinoPosition.position.y - playerPosition.position.y; //distanza y tra mirino e player

        float rapporto = difY/difX; // rapporto tra distanza y e distanza x

        if(rapporto < 0)
        {
            rapporto = -rapporto;
        }

        if(mirinoPosition.position.x > playerPosition.position.x && mirinoPosition.position.y > playerPosition.position.y)
        {
            vy = (velocita * Time.deltaTime/(1+rapporto)) * rapporto;  // componenti x ed y della velocità del proiettile
            vx = (velocita * Time.deltaTime/(1+rapporto));
        }
        if(mirinoPosition.position.x < playerPosition.position.x && mirinoPosition.position.y > playerPosition.position.y)
        {
            vy = (velocita * Time.deltaTime/(1+rapporto)) * rapporto;  // componenti x ed y della velocità del proiettile
            vx = -(velocita * Time.deltaTime/(1+rapporto));
        }
        if(mirinoPosition.position.x < playerPosition.position.x && mirinoPosition.position.y < playerPosition.position.y)
        {
            vy = -(velocita * Time.deltaTime/(1+rapporto)) * rapporto;  // componenti x ed y della velocità del proiettile
            vx = -(velocita * Time.deltaTime/(1+rapporto));
        }
        if(mirinoPosition.position.x > playerPosition.position.x && mirinoPosition.position.y < playerPosition.position.y)
        {
            vy = -(velocita * Time.deltaTime/(1+rapporto)) * rapporto;  // componenti x ed y della velocità del proiettile
            vx = (velocita * Time.deltaTime/(1+rapporto));
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + vx, transform.position.y + vy);
    }
}
