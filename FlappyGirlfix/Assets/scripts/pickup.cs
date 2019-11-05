﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {


	public int scoreToGive;
	
	private ScoreManager theScoreManager;
    private AudioSource coinSound;

	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager>();
        coinSound = GameObject.Find("coin").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			theScoreManager.AddScore(scoreToGive);
			gameObject.SetActive(false);

            coinSound.Play();
		}
		
	}
	
}
