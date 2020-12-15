using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Chaser))]
[RequireComponent(typeof(Guard))]
[RequireComponent(typeof(Change_the_world))]

public class EnemyControllerStateMashine : MonoBehaviour
{
    [SerializeField] float radiusToWatch = 5f;
    private Chaser chaser;
    private Guard dis;
    private Change_the_world change;
    private StateMachine states;
    private StateMachine states2;
    private StateMachine states3;
    private List<StateMachine> stateList;


    void Start()
    {
        stateList = new List<StateMachine>();
        chaser = GetComponent<Chaser>();
        dis = GetComponent<Guard>();
        change = GetComponent<Change_the_world>();
        states = new StateMachine(chaser);
        states2 = new StateMachine(dis);
        states3 = new StateMachine(change);
        stateList.Add(states);
        stateList.Insert(1,states2);
        stateList.Insert(2, states3);

        stateList[0].currentState.Exit();
        stateList[1].currentState.Exit();
        stateList[2].currentState.Exit();

    }

    private void Update()
    {
       
        float distanceToTarget = Vector3.Distance(transform.position, chaser.TargetObjectPosition());

        if (distanceToTarget <= radiusToWatch)   // chaser.enter- if in chaser class the player goes into the bushes, the changeworld.enter
        {
            Debug.Log("Enter from class enemy state mashine");
            stateList[0].currentState.Enter();
            stateList[1].currentState.Exit();
            stateList[2].currentState.Exit();
        }
        else
        {
            Debug.Log("Exit from class enemy state mashine");  //Guard.enter
            stateList[0].currentState.Exit();
            stateList[1].currentState.Enter();
            stateList[2].currentState.Exit();

        }

    }
}
