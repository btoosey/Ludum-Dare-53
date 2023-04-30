using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRestartLevel : MonoBehaviour
{
    [SerializeField] Button restartLevel;

    void Start()
    {
        restartLevel.onClick.AddListener(RestartLevel);
    }

    private void RestartLevel()
    {
        ScenesManager.Instance.ReloadScene();
    }
}
