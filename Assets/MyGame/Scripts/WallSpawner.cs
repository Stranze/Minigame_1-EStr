using System.Collections;
using UnityEngine;

public class WallSpawner : MonoBehaviour {

    public Wall wallPrefab;
    public GameObject wallParent;

    private float minSize = 0.1f;
    private float maxSize = 2.0f;
    private float ySize = 1.0f;
    private float zSize = 0f;
    private float minPos = -5.0f;
    private float maxPos = 5.0f;

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
        float wallSize = Random.Range(minSize, maxSize);
        wallClone.transform.localScale = new Vector3(wallSize, ySize, zSize);
        wallClone.transform.SetParent(wallParent.transform);
        wallClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(minPos, maxPos), wallParent.transform.position.y, ySize);
    }
}
