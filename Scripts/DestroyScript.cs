﻿using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour 
{
	public float destroyTime = 3.0f;

    // Use this for initialization
    void Start ()
	{

            //Destroy (this.gameObject, destroyTime);
            Destroy(gameObject.GetComponent<SpawnItems>().kclone, destroyTime);

    }

}
