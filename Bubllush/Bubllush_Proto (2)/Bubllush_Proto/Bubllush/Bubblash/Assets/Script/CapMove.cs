using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapMove : MonoBehaviour
{
    public GameObject Player;
    bool PlayerCollision;
    public GameObject objTarget;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 衝突時
    void OnCollisionEnter(Collision col)
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }
}
