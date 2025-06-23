using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner  : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minhight = -1f;
    public float maxheight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minhight, maxheight);
    }
}
