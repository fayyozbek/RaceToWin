using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] spawnCar;
    private float[] pos = { 1.59f, -1.59f, 0.51f, -0.51f };
    private void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            
            Instantiate(spawnCar[Random.Range(0, spawnCar.Length-1)], new Vector3(pos[Random.Range(0, 3)],6f,0), Quaternion.Euler(new Vector3(90,180,0)));
            yield return new  WaitForSeconds(2.5f);
        }
    }
}
