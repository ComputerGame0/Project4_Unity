using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * In this class the enemy goes back to its place .
 */
public class Guard : MonoBehaviour,IState
{
    
    [Tooltip("The object that we try to chase")]
    [SerializeField] int x=0;
    [SerializeField] int y=0;
    [SerializeField] int z=0;


    public void Enter()
    {
        Debug.Log("Enter dis");
        this.transform.position = new Vector3(x,y,z);
    }
    public void Exit()
    {
        Debug.Log("Exit dis");
    }
}
