﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour {

    public Wall wallPrefab;
    public GameObject wallParent;

    private void Update()
    {

    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnWall();
        }
    }


    private void SpawnWall()
    {
        Wall wallClone = (Wall)Instantiate(wallPrefab, transform.position, transform.rotation);
        float flySize = 1f;
        wallClone.transform.localScale = new Vector3(flySize, flySize, 0f);
        wallClone.transform.SetParent(wallParent.transform);
        wallClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-6f, 6f), wallParent.transform.position.y, 0f);
        wallClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-1, 1));
    }
}