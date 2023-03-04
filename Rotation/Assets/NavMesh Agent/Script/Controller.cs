using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke() : 특정한 시간에 함수를 호출하도록 설정하는 함수
        // 함수의 이름 : "Move"
        // 함수를 몇 초 후 뒤에 실행시킬 시간 : 1
        // 함수가 몇 초마다 반복하는 시간 : 5

        InvokeRepeating("Move", 1, 5);
    }

    public void Move()
    {
        if(navMeshAgent.velocity == Vector3.zero)
        {
            if (point.Length <= count)
            {
                count = 0;
            }

            navMeshAgent.SetDestination(point[count++].position);           
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
