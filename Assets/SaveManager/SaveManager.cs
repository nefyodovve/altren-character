using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[CreateAssetMenu]
public class SaveManager : ScriptableObject
{
    public IntVariable HP;
    public IntVariable HP_max;
    public IntVariable MP;
    public IntVariable MP_max;
    public IntVariable Toughness;
    public IntVariable Money;

    readonly string filename = "data";
    string filepath;
    bool isInitialized = false;
    private void OnEnable()
    {
        if (!isInitialized)
            Initialize();
        isInitialized = true;
    }

    private void Initialize()
    {
        filepath = Path.Combine(Application.persistentDataPath, filename);
        if (!File.Exists(filepath))
            return;
        FileStream file = File.Open(filepath, FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();
        SaveData sd = (SaveData)bf.Deserialize(file);
        file.Close();

        HP.SetValue(sd.HP);
        HP_max.SetValue(sd.HP_max);
        MP.SetValue(sd.MP);
        MP_max.SetValue(sd.MP_max);
        Toughness.SetValue(sd.Toughness);
        Money.SetValue(sd.Money);
    }

    public void Save()
    {
        SaveData sd = new SaveData
        {
            HP = HP.Value,
            HP_max = HP_max.Value,
            MP = MP.Value,
            MP_max = MP_max.Value,
            Toughness = Toughness.Value,
            Money = Money.Value
        };
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filepath);
        bf.Serialize(file, sd);
        file.Close();
    }

    [Serializable]
    private class SaveData
    {
        public int HP;
        public int HP_max;
        public int MP;
        public int MP_max;
        public int Toughness;
        public int Money;
    }
}
