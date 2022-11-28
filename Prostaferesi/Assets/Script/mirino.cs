using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirino : MonoBehaviour
{
    public float scostamentoX = 3;
    public float scostamentoY = 2;

    public float incrementoDistanzaMirino = 2.5f;

    public GameObject player;

    Transform playerPosition;

    float spostamentoX;
    float spostamentoY;

    // Start is called before the first frame update
    void Start()
    {
       playerPosition = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        spostamentoX = ((generalInfo.mouseX - generalInfo.width/2)/(generalInfo.width/2)) * scostamentoX; 
        spostamentoY = ((generalInfo.mouseY - generalInfo.height/2)/(generalInfo.height/2)) * scostamentoY; 

        if(generalInfo.controller)
        {
            transform.position = new Vector2(playerPosition.position.x + scostamentoX * 10 * Input.GetAxis("Mouse X") * incrementoDistanzaMirino ,
                                            playerPosition.position.y - scostamentoY * 10 * Input.GetAxis("Mouse Y") * incrementoDistanzaMirino);
        }

        else
        {

            transform.position = new Vector2(playerPosition.position.x + (spostamentoX * incrementoDistanzaMirino),
                                            playerPosition.position.y + (spostamentoY * incrementoDistanzaMirino));
        }
    }
}
