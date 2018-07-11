﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0.0f, -0.05f, 0.0f);

        if (this.transform.position.y < 0) {
            DecreaseHealth();
            Destroy(this.gameObject);
        }
        //TODO implement graceful destruction
    }

    void DecreaseHealth() {
        var scoreHandler = GameObject.FindObjectOfType<ScoreHandlerBehavior>();
        var test = GameObject.FindObjectsOfType<ScoreHandlerBehavior>();
        var shb = scoreHandler.GetComponent<ScoreHandlerBehavior>();
        shb.ChangeHealth(-1);
    }
}
