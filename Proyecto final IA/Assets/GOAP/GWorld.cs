using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    private static Queue<GameObject> trees;
    private int numTrees = 0;
    private static float health;
    private bool maxHealth = false;


    static GWorld()
    {
        world = new WorldStates();

        trees = new Queue<GameObject>();

        health = Random.Range(40,80);
        Time.timeScale = 2;

    }

    private GWorld()
    {
    }

    public void AddTree(GameObject p)
    {
       trees.Enqueue(p);
       incrementNumTrees();
    }
    public GameObject RemoveTree()
    {
        if (trees.Count <= 0) return null;
        decrementNumTrees();
        return trees.Dequeue();
    }

    public int getNumTrees(){
        return numTrees;
    }

    private void decrementNumTrees(){
        if(numTrees > 0)
            numTrees--;
    }

    private void incrementNumTrees(){
        numTrees++;
    }

    public void incrementHealth(){
        if(health < 100f)
            health += 0.1f;
        else
            maxHealth = true;
    }

    public bool GetBoolMaxHealth(){
        return maxHealth;
    }

    public void SetBoolMaxHealth(bool b){
        maxHealth = b;
    }

    public void Defeated(){
        health = Random.Range(15,40);
        maxHealth = false;
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}
