using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  [SerializeField] string _nextLevelName;
  private Monster[] _monsters;

  void OnEnable()
  {
    _monsters = FindObjectsOfType<Monster>();
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (MonstersAreAllDead())
      GoToNextLevel();
  }

  bool MonstersAreAllDead()
  {
    foreach (var monster in _monsters)
    {
      if (monster.gameObject.activeSelf)
        return false;
    }

    return true;
  }

  void GoToNextLevel()
  {
    Debug.Log("Go to level " + _nextLevelName);
    SceneManager.LoadScene(_nextLevelName);
  }
}
