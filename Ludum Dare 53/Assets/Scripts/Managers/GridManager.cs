using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
	[SerializeField] private int _width, _height;

	[SerializeField] private GridTile gridTile;
	[SerializeField] private Tilemap tilemap;
	[SerializeField] private Transform _cam;
	[SerializeField] private BoxPlacement boxPlacement;



	void Start()
    {
		GenerateGrid();
    }

    void GenerateGrid()
	{
		for (int x = 0; x < _width; x++)
		{
			for (int y = 0; y < _height; y++)
			{
				if (tilemap.GetTile(new Vector3Int(x,y)))
				{
					continue;
				}
				var spawnedGridTile = Instantiate(gridTile, new Vector3(x, y), Quaternion.identity);
				spawnedGridTile.name = $"Tile {x} {y}";
				spawnedGridTile.boxPlacement = boxPlacement;
			}
		}

		_cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
	}
}
