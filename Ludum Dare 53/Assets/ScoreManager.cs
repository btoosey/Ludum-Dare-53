using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager Instance;
	public int[] levelMaxBoxes = {3};
	public int[] twoStars = {2};
	public int[] threeStars = {1};
	public int currentBoxes = 0;
	public GameObject stars;

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
		CalculateStars();
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
}
