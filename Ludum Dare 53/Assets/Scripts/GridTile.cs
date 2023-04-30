using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
	[SerializeField] private GameObject selectedGridTile;
	public BoxPlacement boxPlacement;
	private GameObject player;
	private GameObject finish;
	private GameObject respawn;


	private void Start()
	{
		player = GameObject.FindWithTag("Player");
		finish = GameObject.FindWithTag("Finish");
		respawn = GameObject.FindWithTag("Respawn");
	}

	void OnMouseEnter()
	{
		if (!DistanceOkay() || !BoxesRemaining() || ScenesManager.Instance.canReset == false)
		{
			return;
		}
		selectedGridTile.SetActive(true);
	}

	void OnMouseExit()
	{
		selectedGridTile.SetActive(false);
	}

	private void OnMouseOver()
	{
		if (!DistanceOkay() || !BoxesRemaining() || ScenesManager.Instance.canReset == false)
		{
			selectedGridTile.SetActive(false);
		} else
		{
			selectedGridTile.SetActive(true);
		}
	}

	private void OnMouseDown()
	{
		if (!DistanceOkay() || !BoxesRemaining() || ScenesManager.Instance.canReset == false)
		{
			return;
		}
		Destroy(gameObject);
		boxPlacement.PlaceBox(new Vector3Int((int)gameObject.transform.position.x, (int)gameObject.transform.position.y));
		ScoreManager.Instance.AddLevelBox();
	}
	
	private bool DistanceOkay()
	{
		if (PlayerDistance() > 1 && PlayerDistance() < 3 && FinishDistance() > 1.5 && RespawnDistance() > 1)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	private float PlayerDistance()
	{
		return Vector3.Distance(gameObject.transform.position, player.transform.position);
	}
	private float FinishDistance()
	{
		return Vector3.Distance(gameObject.transform.position, finish.transform.position);
	}

	private float RespawnDistance()
	{
		return Vector3.Distance(gameObject.transform.position, respawn.transform.position);
	}

	private bool BoxesRemaining()
	{
		if (ScoreManager.Instance.GetMaxBoxes() > ScoreManager.Instance.currentBoxes)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
