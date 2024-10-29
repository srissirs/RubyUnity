using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public float fixedEnemies;

    private void Awake()
    {
        Instance = this;
        fixedEnemies = 0;
        DontDestroyOnLoad(gameObject);
    }

    // Add an enemy to the list when instantiated
    public void FixedEnemy()
    {
        MainManager.Instance.fixedEnemies += 1.0f;
        Debug.Log(fixedEnemies);
    }

    // Check if all enemies are dead
    public bool AreAllEnemiesFixed()
    {
        Debug.Log(this.fixedEnemies);
        return fixedEnemies == 2.0f; // At least one enemy is still unfixed
    }
}

