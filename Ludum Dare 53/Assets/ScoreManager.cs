using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager Instance;
	public int[] levelMaxBoxes = {3};
	public int[] levelMinBoxes = {1};
	public int currentBoxes = 0;


	private void Awake()
	{
		Instance = this;
	}

	public int GetMaxBoxes()
	{
		return levelMaxBoxes[ScenesManager.Instance.GetActiveScene()];
	}

	public void AddLevelBox()
	{
		currentBoxes += 1;
	}
}
