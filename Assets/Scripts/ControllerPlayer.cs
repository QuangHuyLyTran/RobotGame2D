using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    private Animator ani;
    private Rigidbody2D rg;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        ani = Player.GetComponent<Animator>();
        rg = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("Nhan phim right");
            ani.SetInteger("Start", 1);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //Debug.Log("Nhan phim right");
            ani.SetInteger("Start", 0);
        }
    }
}
