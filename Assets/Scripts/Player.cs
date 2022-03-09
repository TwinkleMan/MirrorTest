using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    private void HandleMovement()
    {
        if (!isLocalPlayer)
            return;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float speed = 5f * Time.deltaTime;


        transform.Translate(new Vector2(moveHorizontal * speed, moveVertical*speed));
    }

    void Update()
    {
        HandleMovement();
    }

}
