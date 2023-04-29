using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
	[SerializeField] private GameObject selectedGridTile;
	public BoxPlacement boxPlacement;
	private GameObject player;
	private GameObject finish;

	private void Start()
	{
		player = GameObject.FindWithTag("Player");
		finish = GameObject.FindWithTag("Finish");
	}

	void OnMouseEnter()
	{
		if (!DistanceOkay())
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
		if (!DistanceOkay())
		{
			selectedGridTile.SetActive(false);
		} else
		{
			selectedGridTile.SetActive(true);
		}
	}

	private void OnMouseDown()
	{
		if (!DistanceOkay())
		{
			return;
		}
		Destroy(gameObject);
		boxPlacement.PlaceBox(new Vector3Int((int)gameObject.transform.position.x, (int)gameObject.transform.position.y));
	}
	
	private bool DistanceOkay()
	{
		if ((PlayerDistance() > 1 && PlayerDistance() < 3) && FinishDistance() > 2)
		{
			return true;
		}
		else
		{
			return false;
		}	
		;
	}
	private float PlayerDistance()
	{
		return Vector3.Distance(gameObject.transform.position, player.transform.position);
	}
	private float FinishDistance()
	{
		return Vector3.Distance(gameObject.transform.position, finish.transform.position);
	}
}
