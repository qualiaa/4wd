﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour 
{
	public GameObject pickupPrefab;

	public PickupSpawnpoint[] pickupSpawnPoints;

	float timeForNextSpawn = -1f;

	// Use this for initialization
	public void SpawnFirstPickup()
	{
		SpawnPickup( false );
		GameManager.OnGameEndMethods += OnGameEnd;
	}

	public void StartContinuousSpawning()
	{
		SpawnPickupsAndSetNewTime();
	}

	void OnGameEnd()
	{
		GameManager.OnGameEndMethods -= OnGameEnd;
		timeForNextSpawn = -1f;
	}

	private float SpawnPickup( bool withTimer )
	{
		float destroyTime;
		if( withTimer )
			destroyTime = Random.Range( 10f, 15f );
		else
			destroyTime = -100f;
		GetRandomPickupToSpawnOn().SpawnPickup( pickupPrefab, destroyTime );
		return destroyTime;
	}

	private PickupSpawnpoint GetRandomPickupToSpawnOn()
	{
		List<PickupSpawnpoint> pickupSpawnPointsWithoutPickups = new List<PickupSpawnpoint>();

		for( int i = 0; i < pickupSpawnPoints.Length; i++ )
		{
			if( !pickupSpawnPoints[i].HasPickup() )
				pickupSpawnPointsWithoutPickups.Add( pickupSpawnPoints[i] );
		}

		return pickupSpawnPointsWithoutPickups[Random.Range( 0, pickupSpawnPointsWithoutPickups.Count )];
	}

	// Update is called once per frame
	void Update ()
	{
		if( timeForNextSpawn < 0f )
			return;

		bool pickupsAreSpawned = false;
		for( int i = 0; i < pickupSpawnPoints.Length; i++ )
		{
			if( pickupSpawnPoints[i].HasPickup())
				pickupsAreSpawned = true;
		}
		if( !pickupsAreSpawned )
		{
			SpawnPickupsAndSetNewTime();
			return;
		}

		if( timeForNextSpawn > Time.time )
			return;

		SpawnPickupsAndSetNewTime();
	}

	private void SpawnPickupsAndSetNewTime()
	{
		float longestDestroyTime = 0f;
		longestDestroyTime = SpawnPickup( true );
		float destroyTime = SpawnPickup( true );
		if( destroyTime > longestDestroyTime )
			longestDestroyTime = destroyTime;

		timeForNextSpawn = Time.time + longestDestroyTime;
	}
}
