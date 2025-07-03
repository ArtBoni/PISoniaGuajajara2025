using System.IO;
using UnityEngine;

public enum Tools
{
    None, Water, Shield
}
[System.Serializable]
public class PlayerTollsSystem
{
    [SerializeField] float toolColldown;
    [SerializeField] Tools toolInHand;

    public PlayerTollsSystem(float toolCooldown)
    {
        this.toolColldown = toolCooldown;
        this.toolInHand = Tools.None;
    }
}

public class Save : MonoBehaviour
{
    [SerializeField] PlayerTollsSystem toolsSystem = new PlayerTollsSystem(0.5f);

    [SerializeField] string fileName;
    string savePath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        savePath = Application.persistentDataPath + $"/{fileName}.json";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SavePath(toolsSystem);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerTollsSystem temp = Load();
            if (temp == null)
                return;
            toolsSystem = Load();
        }
    }
        
    public void SavePath(PlayerTollsSystem data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, json);
        print("Json Salvo");
    }
    public PlayerTollsSystem Load()
    {
        if (!File.Exists(savePath))
            return null;

        string json = File.ReadAllText(savePath);
        PlayerTollsSystem playerToolSystem = JsonUtility.FromJson<PlayerTollsSystem>(json);
        print("Jogo carregado");
        return playerToolSystem;
        
    }

    public void Delete()
    {
        if(!File.Exists(savePath))
            return;
        File.Delete(savePath);
    }
}
