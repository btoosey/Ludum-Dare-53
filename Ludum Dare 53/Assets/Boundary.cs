using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
	public GameObject player;
	public GameObject respawnPoint;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		player.transform.position = respawnPoint.transform.position;
	}
}
