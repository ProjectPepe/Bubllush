using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 3.0f;
    public Rigidbody rb;
    public bool RightRockFlag = false, LeftRockFlag = false, UpRockFlag = false, DownRockFlag = false;
    Vector3[] MoveVector = new Vector3[4];
    float[,] MatRot = new float[3, 3];
    float Angle = 90.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        MoveVector[0].x = 1; MoveVector[0].y = 0;                    // 左上の面
        MoveVector[1].x = -1; MoveVector[1].y = 0;                   // 右上の面
        MoveVector[2].x = 0; MoveVector[2].y = -1;                     // 下の面
        MoveVector[3].x = 0; MoveVector[3].y = 1;                     // 下の面
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            MoveVector[0].x = 0; MoveVector[0].y = 0;
        }
        if (Input.GetKeyDown("d"))
        {
            MoveVector[1].x = 0; MoveVector[1].y = 0;
        }
        if (Input.GetKeyDown("w"))
        {
            MoveVector[2].x = 0; MoveVector[2].y = 0;
        }
        if (Input.GetKeyDown("s"))
        {
            MoveVector[3].x = 0; MoveVector[3].y = 0;
        }
 

        //if (Angle > 360.0f)
        //{
        //    Angle = 0.0f;
        //}
        //MatRot[0, 0] = -Mathf.Cos(Angle * (3.14f / 180)); MatRot[0, 1] = Mathf.Sin(Angle * (3.14f / 180)); MatRot[0, 2] = 0;
        //MatRot[1, 0] = -Mathf.Sin(Angle * (3.14f / 180)); MatRot[1, 1] = -Mathf.Cos(Angle * (3.14f / 180)); MatRot[1, 2] = 0;
        //MatRot[2, 0] = 0; MatRot[2, 1] = 0; MatRot[2, 2] = 1;


        //for (int x = 0; x < 3; x++)
        //{
        //    Rotation(x);
        //}

        // ベクトルの足し算
        Vector3 TempVector = new Vector3(MoveVector[0].x + MoveVector[1].x + MoveVector[2].x + MoveVector[3].x,
            MoveVector[0].y + MoveVector[1].y + MoveVector[2].y + MoveVector[3].y,
            MoveVector[0].z + MoveVector[1].z + MoveVector[2].z + MoveVector[3].z);

        rb.AddForce(TempVector.x* Speed, TempVector.y* Speed, 0);
        if (Input.GetKeyDown("r"))
        {
            Debug.Log(MoveVector[0].x); Debug.Log(MoveVector[1].x); Debug.Log(MoveVector[2].x); Debug.Log(MoveVector[3].x);
            Debug.Log(MoveVector[0].y); Debug.Log(MoveVector[1].y); Debug.Log(MoveVector[2].y); Debug.Log(MoveVector[3].y);
            Debug.Log(MoveVector[0].z); Debug.Log(MoveVector[1].z); Debug.Log(MoveVector[2].z); Debug.Log(MoveVector[3].z);
        }
    }

    void FixedUpdate()
    {
    }

    void Rotation(int _Num)
    {
        // 回転行列
        MoveVector[_Num].x = ((MoveVector[_Num].x * MatRot[0, 0]) + (MoveVector[_Num].x * MatRot[0, 1]) + (MoveVector[_Num].x * MatRot[0, 2]));
        MoveVector[_Num].y = ((MoveVector[_Num].y * MatRot[1, 0]) + (MoveVector[_Num].y * MatRot[1, 1]) + (MoveVector[_Num].y * MatRot[1, 2]));
        MoveVector[_Num].z = ((MoveVector[_Num].z * MatRot[2, 0]) + (MoveVector[_Num].z * MatRot[2, 1]) + (MoveVector[_Num].z * MatRot[2, 2]));
    }
}
