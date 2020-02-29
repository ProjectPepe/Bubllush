using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour
{
    private GameObject Player;//プレイヤー

    private Vector2 PlayerPos;
    private Vector2 JetPos;
    private Vector2 MoveVec;
    public bool RockMove;

    // Start is called before the first frame update
    void Start()
    {
        Player = transform.root.gameObject;//プレイヤーを捜査
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(RockMove)
        {
            PlayerPos = Player.transform.position;
            JetPos = this.transform.position;

            MoveVec = PlayerPos - JetPos;

            Player.GetComponent<Rigidbody>().AddForce(MoveVec * 2);


            //Debug.Log(MoveVec);
        }
    }

    
}
