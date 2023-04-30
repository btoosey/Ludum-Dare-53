using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

	public Canvas levelEndPanel;
	public Boundary boundary;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		ScenesManager.Instance.canReset = false;
		levelEndPanel.transform.gameObject.SetActive(true);


	}
}
