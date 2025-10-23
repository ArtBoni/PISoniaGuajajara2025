using System.IO;
using UnityEngine;

public enum Tools
{
    None, Water, Shield
}
[System.Serializable]
public class SaveData
{
    public PlayerTollsSystem playerTools;
    public float[] playerPosition; 

    public SaveData(PlayerTollsSystem tools, Vector3 position)
    {
        playerTools = tools;
        playerPosition = new float[] { position.x, position.y, position.z };
    }

    public Vector3 GetPosition()
    {
        return new Vector3(playerPosition[0], playerPosition[1], playerPosition[2]);
    }
}



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
    [SerializeField] Transform player; 
    [SerializeField] string fileName;

    string savePath;

    void Start()
    {
        savePath = Application.persistentDataPath + $"/{fileName}.json";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SavePath();
            print("Jogo Salvo");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    public void SavePath()
    {
        SaveData data = new SaveData(toolsSystem, player.position);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, json);
        print("Json Salvo");
    }

    public void Load()
    {
        if (!File.Exists(savePath))
            return;

        string json = File.ReadAllText(savePath);
        SaveData data = JsonUtility.FromJson<SaveData>(json);

        
       // toolsSystem = data.playerTools;

        // Restaurar posição do jogador
        player.position = data.GetPosition();

        print("Jogo carregado");
    }

    public void Delete()
    {
        if (!File.Exists(savePath))
            return;
        File.Delete(savePath);
    }

    public bool HasSave()
    {
        return File.Exists(savePath);
    }
}
