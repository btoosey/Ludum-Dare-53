using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
	[SerializeField] private GameObject selectedGridTile;

	void OnMouseEnter()
	{
		selectedGridTile.SetActive(true);
	}

	void OnMouseExit()
	{
		selectedGridTile.SetActive(false);
	}
}
