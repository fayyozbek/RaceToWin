using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class MoveAndSpawn : MonoBehaviour
{
    public float speed = 2f;
    public GameObject road;
    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -8)
        {
            Instantiate(road, new Vector3(0 ,8.44f, 0 ), Quaternion.identity);
            //EditorApplication.isPaused = true;
            Destroy(gameObject);
        }
    }

}
