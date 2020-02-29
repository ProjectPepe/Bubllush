using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] objTarget = new GameObject[4];
    private Rigidbody Rigidbody;
    private bool[] Flag = new bool[4];

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int Cnt = 0; Cnt < 4; Cnt++)
        {
            if(Flag[Cnt]==true)
            {
                this.transform.position = new Vector3(objTarget[Cnt].transform.position.x, objTarget[Cnt].transform.position.y, 0);
                Debug.Log(Cnt);
            }
        }
    }

    // 衝突時
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤー当たり");
            //Rigidbody.constraints = RigidbodyConstraints.None;

            // Rigidbody.isKinematic = true;
            // this.transform.parent = Player.transform;
        }

        for (int Cnt = 0; Cnt < 4; Cnt++)
        {
            if (col.gameObject == objTarget[Cnt])
            {
                Flag[Cnt] = true;
                Debug.Log(objTarget[Cnt]);
                Debug.Log("当たり");
            }
        }

        if (col.gameObject.tag == "Untagged")
        {
           
            Debug.Log("当たり");
        }
    }
}
