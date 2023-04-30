using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UINextLevel : MonoBehaviour
{
    [SerializeField] Button nextLevel;

    void Start()
    {
        nextLevel.onClick.AddListener(StartNextLevel);
    }

    private void StartNextLevel()
    {
        ScenesManager.Instance.LoadNextScene();
    }
}
