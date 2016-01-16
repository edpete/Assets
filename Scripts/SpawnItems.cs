using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour 
{

	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f; 

	public GameObject kaiju;
	//public GameObject[] kaiju;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnKaiju", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnKaiju()
	{
		//DestroyScript is killing the object so... Need to clean this up. 
		if (kaiju != null) 
		
		{
			int spawnIndex = Random.Range (0, SpawnPoints.Length);
			Instantiate (kaiju, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
		}

	}
}
