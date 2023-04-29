using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoxPlacement : MonoBehaviour
{
	public int gridWidth;
	public int gridHeight;

	public Tile boxTile;
	public Vector3Int position;
	public Tilemap tilemap;

	void GenerateGrid()
	{
		for (int x = 0; x < gridWidth; x++)
		{
			for (int y = 0; y < gridHeight; y++)
			{

			}
		}
	}


	[ContextMenu("Paint")]

	void PlaceBox()
	{
		tilemap.SetTile(position, boxTile);
	}
}
