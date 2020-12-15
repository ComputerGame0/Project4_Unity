﻿using UnityEngine;

/**
 * This component patrols between given points.
 */
public class Patroller: TargetMover, IState
{
    [SerializeField] Cycle patrolPath = null;

    [SerializeField] private int pointCount;
    [SerializeField] private int currentPointIndex;

    protected override void Start()  {
        base.Start();
        pointCount = patrolPath.transform.childCount;
        currentPointIndex = 0;
    }

    private void Update() {
        if (atTarget) {
            currentPointIndex = (currentPointIndex + 1) % pointCount;
        }
        SetTarget(patrolPath.transform.GetChild(currentPointIndex).position);
    }

    public void Enter()
    {
        Debug.Log("Enter p");
        this.enabled = true;
    }
    public void Exit()
    {
        Debug.Log("Exit p");
        this.enabled = false;
    }
}
 