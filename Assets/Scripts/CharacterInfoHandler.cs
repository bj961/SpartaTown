using System;
using UnityEngine;

// Ŭ������ Serializable�� ����θ� �����Ǿ� ������ [Serializable]�� �ٿ� �����Ϳ��� Ȯ�� �����ؿ�!
[Serializable]
public class CharacterInfoHandler
{
    public string Name { get { return Name; } set { ; } }
    public float moveSpeed { get; set; } = 10;

    public CharacterInfoHandler() { }


}