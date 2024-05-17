using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/Food")]
public class Foods : ScriptableObject
{
    public string foodName;
    public Sprite foodImage;
    public bool cutable;
    
}
