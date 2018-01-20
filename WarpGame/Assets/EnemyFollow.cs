using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public GameObject Player;
	public GameObject Enemy;
	public float EnemySpeed;

	// Use this for initialization
	void Start () {
		EnemySpeed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
	}
}
