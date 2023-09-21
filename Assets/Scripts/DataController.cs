using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    public Data data = new Data("Arthur", 30, 80.5f, 100.0f, 0.0f, 0.0f, 0.0f, false, false, true, 10.0f, 100.0f);

    public void Start()
    {
        Load();
    }
    
    public void Update()
    {
        
        
    }
    
    private void OnDestroy()
    {
        Save(); // Oyunu kapattığınızda veya sahneyi değiştirdiğinizde verileri kaydetmek için OnDestroy() kullanın.
    }
    
    public void Save()
    {
        // Konumu ayrı bir Vector3 olarak kaydedin
        data.position = transform.position;
        
       string json = JsonUtility.ToJson(data); //Convert the data to json format
       File.WriteAllText(Application.dataPath + "/Saves/Data.json", json);// for android use Application.persistentDataPath
    }
    
    public void Load()
    {
        string filePath = Application.dataPath + "/Saves/Data.json";
    
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<Data>(json);
            
            // Kayıtlı pozisyonu karakterin pozisyonuna atayın
            transform.position = data.position;
        }
        else
        {
            Debug.LogWarning("Data dosyası bulunamadı.");
        }
    }

    
}
