using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] TilemapCaveGenerator tilemapCaveGenerator;

    void Start()
    {
        //tilemapCaveGenerator=GetComponent<TilemapCaveGenerator>();
        this.transform.position = new Vector3(tilemapCaveGenerator.getgrid() - 1, tilemapCaveGenerator.getgrid() - 1,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == triggeringTag)
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
    }
}