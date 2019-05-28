using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private const string AXIHORIZONTAL = "Horizontal";
    private float moveSpeed = 3.0f;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXIHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, -300f, 300f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
