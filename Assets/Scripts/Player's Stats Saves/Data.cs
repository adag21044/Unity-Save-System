using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    
    public string name;
    public int age;
    public float weight;
    public float honor;
    
    public float positionX;
    public float positionY;
    public float positionZ;

    public bool isSick;
    public bool isArmed;
    public bool isAlive;

    public float speed;
    public float health;
    
    public Vector3 position;

    
    public Data()
    {
        
    }
    public Data(string name, int age, float weight, float honor, float positionX, float positionY, float positionZ, bool isSick, bool isArmed, bool isAlive, float speed, float health)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
        this.honor = honor;
        this.positionX = positionX;
        this.positionY = positionY;
        this.positionZ = positionZ;
        this.isSick = isSick;
        this.isArmed = isArmed;
        this.isAlive = isAlive;
        this.speed = speed;
        this.health = health;
    }
}
