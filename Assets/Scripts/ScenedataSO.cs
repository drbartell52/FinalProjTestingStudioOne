using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScenedataSO",menuName = "ScriptableObjects/SceneInfoSO")]
public class ScenedataSO : ScriptableObject
{
   public int sceneSelect;
   public int sceneCount;
   public int currentPop;
}
