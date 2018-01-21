using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public GameObject Player;
	public GameObject Enemy;
    public float EnemySpeed = 0.01f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player.transform);
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
	}
}
