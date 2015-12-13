using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float maxSpeed;
    private Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        player.velocity = Vector3.right * Input.GetAxis("Horizontal") * maxSpeed;
    }
}
