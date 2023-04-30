using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	
	public static ScoreManager Instance;
	[System.NonSerialized] public int[] levelMaxBoxes = {0, 0, 1, 3, 4, 4, 5};
	[System.NonSerialized] public int[] twoStars = {0, 0, 1, 2, 3, 3, 4};
	[System.NonSerialized] public int[] threeStars = {0, 0, 1, 1, 2, 2, 3};
	public int currentBoxes = 0;
	public GameObject stars;
	public GameObject wizard;

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

	public void CalculateStars()
	{
		if (currentBoxes > threeStars[ScenesManager.Instance.GetActiveScene()])
		{
			DisableStar(2);
		}
		
		if (currentBoxes > twoStars[ScenesManager.Instance.GetActiveScene()])
		{
			DisableStar(1);
		}
	}

	private void DisableStar(int childNumber)
	{
		stars.transform.GetChild(childNumber).transform.GetChild(0).transform.gameObject.SetActive(false);
	}

	public int RemainingBoxes()
	{
		return GetMaxBoxes() - currentBoxes;
	}
}
