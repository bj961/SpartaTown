using System;
using UnityEngine;

// 클래스가 Serializable한 멤버로만 구성되어 있으면 [Serializable]을 붙여 에디터에서 확인 가능해요!
[Serializable]
public class CharacterInfoHandler
{
    public string Name { get { return Name; } set { ; } }
    public float moveSpeed { get; set; } = 10;

    public CharacterInfoHandler() { }


}