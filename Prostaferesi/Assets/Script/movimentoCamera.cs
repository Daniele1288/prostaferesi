using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCamera : MonoBehaviour
{
    public float scostamentoX = 3;
    public float scostamentoY = 2;


    public GameObject player;

    Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
       playerPosition = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPosition.position.x + scostamentoX * 10 * Input.GetAxis("Mouse X") , playerPosition.position.y - scostamentoY * 10 * Input.GetAxis("Mouse Y"), -1 );

    }
}
