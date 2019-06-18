﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public SceneLoader sceneLoader;

    private const string AXIHORIZONTAL = "Horizontal";
    private float moveSpeed = 5.0f;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXIHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, -300f, 300f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("wall " + collision.name);
        if (collision.name == "Wall")
        {
            sceneLoader.BadEnd();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
