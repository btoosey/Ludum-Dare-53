using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoxPlacement : MonoBehaviour
{
	public Tile boxTile;
	public Tilemap tilemap;

	public void PlaceBox(Vector3Int position)
	{
		tilemap.SetTile(position, boxTile);
	}
}
