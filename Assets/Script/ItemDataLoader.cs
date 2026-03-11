using UnityEngine;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine.UI;

public class ItemDataLoader : MonoBehaviour
{

    private string jsonFileName = "items";

    private List<ItemData> itemList;


    void Start()
    {
        LoadItemData(); 
    }

    private string EncodeKorean(string text)
    {
        if (string.IsNullOrEmpty(text))return "";
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }

    }

    void LoadItemData()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>(jsonFileName);

        if (jsonFile != null)
        {
            byte[] bytes = Encoding.Default.GetBytes(jsonFile.text);
            string currentText = Encoding.UTF8.GetString(bytes);

            itemList = JsonConvert.DeserializeObject<List<ItemData>>(currentText);

            Debug.Log($"로드 된 아이템 수 : {itemList.Count}");

            foreach (var item in itemList)
            {
                Debug.Log($"아이템 : {EncodeKorean(item.itemName)}, 설명 : {EncodeKorean(item.description)}"); } ;

            }
        else
        {
            Debug.LogError($"JSON 파일을 찾을 수 없습니다. : {jsonFileName}");
        }


        }
    }
