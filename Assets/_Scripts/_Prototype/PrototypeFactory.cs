using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrototypeFactory : MonoBehaviour
{
    public List<CollectableData> allData;

    public GameObject buttonPanel;
    public GameObject buttonPrefab;
    private EditorManager editor;

    Coin coinPrototype;
    // Start is called before the first frame update
    void Start()
    {
        editor = EditorManager.instance;

        coinPrototype = new Coin(allData[0]._prefab, allData[0]._score);

        for(int i = 0; i < allData.Count; i++)
        {
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonPanel.transform);
            button.gameObject.name = allData[i]._name + "Button";
            button.GetComponentInChildren<TextMeshProUGUI>().text = allData[i]._name;
            button.GetComponent<Button>().onClick.AddListener(delegate { Spawner(button);});
        }
    }

    
    void Spawner(GameObject button)
    {
        var btn = button.GetComponentInChildren<TextMeshProUGUI>();

        switch (btn.text)
        {
            case "Coin":
                editor.item = coinPrototype.Clone().Spawn();
                break;

            default:
                break;
        }

        editor.instantiated = true;
    }
}
