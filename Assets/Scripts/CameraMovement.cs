using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 offset;
    [SerializeField] Transform player;
    Vector3 velocity = Vector3.zero;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player != null)
        {
            offset = transform.position - player.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, offset + player.position, ref velocity, 0);
    }
}
