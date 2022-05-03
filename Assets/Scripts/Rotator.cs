using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum move
{
    Move,
    Rotate,
    Scale,
}
public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3[] limits;
    [SerializeField] move move;
    [SerializeField] float speedMove;
    [SerializeField] float speedrotate;
    new Transform trans;
    float time;
    private void Start()
    {
        trans = transform;
        if (move == move.Move)
        {
            trans.position = limits[0];
        }
    }
    private void Update()
    {
        switch (move)
        {
            case move.Move:
                {
                    time += Time.deltaTime * speedMove;
                    Vector3 value = Vector3.Lerp(limits[0], limits[1], time);
                    if (time >= 1)
                    {
                        time = 0;
                        Vector3 tmp = limits[0];
                        limits[0] = limits[1];
                        limits[1] = tmp;
                    }
                    transform.position = value;
                    break;
                }
            case move.Rotate:
                {
                    float zValue = trans.rotation.eulerAngles.z +1 * Time.deltaTime * speedrotate;
                    trans.rotation = Quaternion.Euler(new Vector3(0, 0, zValue));
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}
