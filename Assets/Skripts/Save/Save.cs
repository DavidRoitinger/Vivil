using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{
    private string path = "Savefile1.txt";

    public void Saving()
    {
            File.WriteAllText(path, Serialisieren());
    } 
     
    public void Loading()
    {
        if (File.Exists(path))
        {
           Deserialisieren(File.ReadAllLines(path)[0]);
        }
        
    }

    public string Serialisieren()
    {
        string line = Stats.maxHealth + ";" + Stats.currentHealth + ";" + Stats.money + ";" + Stats.damage + ";" +
                      Stats.range + ";" + Stats.plBulletSpeed + ";" + Stats.moveSpeed + ";" + Stats.plCooldown + ";" + Stats.exL;


        return line;
    }
    public void Deserialisieren(string line)
    {
        string[] parts = line.Split(';');
        
        Stats.maxHealth = int.Parse(parts[0]);
        Stats.currentHealth = int.Parse(parts[1]);
        Stats.money = int.Parse(parts[2]);
        Stats.damage = int.Parse(parts[3]);
        Stats.range = float.Parse(parts[4]);
        Stats.plBulletSpeed = float.Parse(parts[5]);
        Stats.moveSpeed = float.Parse(parts[6]);
        Stats.plCooldown = float.Parse(parts[7]);
        Stats.exL = int.Parse(parts[8]);
    }
}
