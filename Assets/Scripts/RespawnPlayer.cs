using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    Transform respawnTransform;
    [SerializeField] Transform playerTransform;
    private void Start()
    {
        respawnTransform = GameObject.FindGameObjectWithTag("Respawn Position").transform;
    }
    public void Respawn()
    {
        playerTransform.gameObject.SetActive(true);
        playerTransform.position = respawnTransform.position + new Vector3(3, 2, 0);
    }
}
