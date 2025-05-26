using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeakRefTracker : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform targetPos;

    [Header("UI References")]
    [SerializeField]
    private TMP_Text ObjNullText;
    [SerializeField]
    private TMP_Text UnityObjNullText;

    private GameObject _target;

    private void Awake()
    {
    }

    void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        ObjNullText.text = IsObjNull() ? "Yes" : "No";
        UnityObjNullText.text = IsUnityObjNull() ? "Yes" : "No";
    }

    private bool IsObjNull()
    {
        return _target is null;
    }

    private bool IsUnityObjNull()
    {
        return _target == null;
    }
}
