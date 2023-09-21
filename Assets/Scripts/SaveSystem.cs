using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class SaveSystem 
{
    static SaveSystem()
    {
        // EditorApplication.update olayını dinleyerek her çerçeve güncellendiğinde X tuşunu kontrol edeceğiz.
        EditorApplication.update += CheckForSaveKeyPress;
    }

    static void CheckForSaveKeyPress()
    {
        if (Event.current != null && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.X)
        {
            SaveData();
        }
    }

    static void SaveData()
    {
        DataController dataController = GameObject.FindObjectOfType<DataController>();
        if (dataController != null)
        {
            dataController.Save();
        }
    }
}