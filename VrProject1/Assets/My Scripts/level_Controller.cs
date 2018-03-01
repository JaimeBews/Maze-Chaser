using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class level_Controller : MonoBehaviour {
public Transform[] tiles;
public Transform startTile;
public Transform endTile;
public Transform player;
	// Use this for initialization
	void Start () {
		 spawnGrid();
		 chooseStart();
	}
	private void chooseStart(){
		int index = Random.Range (0, 3);
		int randomChoice =(Random.Range(0, 9)*16);
		switch (index)
        {
        case 0:
            Instantiate(startTile, new Vector3(-16,0,randomChoice),Quaternion.identity);
			player.position =new Vector3(-16,1,randomChoice);
			Instantiate(endTile, new Vector3(160,0,Random.Range(0, 9)*16),Quaternion.identity);
            break;
		case 1:
		    Instantiate(startTile, new Vector3(160,0,randomChoice),Quaternion.identity);
			player.position =new Vector3(160,1,randomChoice);
			Instantiate(endTile, new Vector3(-16,0,Random.Range(0, 9)*16),Quaternion.identity);
            break;
		case 2:
		    Instantiate(startTile, new Vector3(randomChoice,0,-16), Quaternion.identity);
			player.position =new Vector3(randomChoice,1,-16);
			Instantiate(endTile, new Vector3((Random.Range(0, 9)*16),0,160),Quaternion.identity);
            break;
		case 3:
		    Instantiate(startTile, new Vector3(randomChoice,0,160),Quaternion.identity);
			player.position =new Vector3(randomChoice,1,160);
			Instantiate(endTile, new Vector3((Random.Range(0, 9)*16),0,-16), Quaternion.identity);

            break;
		}
	}
	
	void spawnGrid(){
		for(int i = 0; i<10;i++){
			for(int j=0;j<10;j++){
				Instantiate(getRandomTile(), new Vector3(i*16,0,j*16),Quaternion.identity);
			}
		}		
	}
	public Transform getRandomTile(){
		int index = Random.Range (0, tiles.Length);
        return tiles[index];
	}
	// Update is called once per frame
	void Update () {
		
	}
}
