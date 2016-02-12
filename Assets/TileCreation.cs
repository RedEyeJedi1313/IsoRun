using UnityEngine;
using System.Collections;

public class TileCreation : MonoBehaviour {

  
    public GameObject currentTile;
    public GameObject[] tilePrefabs;
	// Use this for initialization
	void Start ()
    {
        
        for (int i = 0; i <1000; i++)
        {
            spawnTile();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawnTile()
    {
        int randomIndex = Random.RandomRange(0, 2);
        currentTile = (GameObject)Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }
}
