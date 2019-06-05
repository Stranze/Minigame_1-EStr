using System.Collections;
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
            yield return new WaitForSeconds(1);
            SpawnWall();
        }
    }

    private void SpawnWall()
    {
        Wall wallClone = (Wall)Instantiate(wallPrefab, transform.position, transform.rotation);
        float wallSize = Random.Range(1f, 3f);
        wallClone.transform.localScale = new Vector3(wallSize, 1f, 0f);
        wallClone.transform.SetParent(wallParent.transform);
        wallClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), wallParent.transform.position.y, 0f);
    }
}
