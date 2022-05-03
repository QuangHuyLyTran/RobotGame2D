using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] levels;
    int currentLevel = 0;
    GameObject currentLevelObject;
    private void Awake()
    {
        //currentLevelObject = Instantiate(levels[currentLevel], Vector3.zero, Quaternion.identity);
    }
    public void SpawnNewLevel()
    {
        currentLevel++;
        Destroy(currentLevelObject);
        currentLevelObject = Instantiate(levels[currentLevel], Vector3.zero, Quaternion.identity);
    }
}
