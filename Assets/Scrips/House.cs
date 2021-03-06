﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class House : MonoBehaviour
{
    public Building building;
    private GameObject currentPrefab;

    void Start()
    {
        UpdatePrefab();
        
    }

    public void Reset() {
        building.Reset();
    }
    public void AddResouce(int amount)
    {
        building.AddResouce(amount: amount);
        UpdatePrefab();
    }

    void UpdatePrefab()
    {
        Destroy(currentPrefab);
        currentPrefab = Instantiate(building.GetPrefab(), position: transform.position, rotation: transform.rotation);
        currentPrefab.transform.localScale = new Vector3(x: 10, y: 10, z: 10);
    }
}