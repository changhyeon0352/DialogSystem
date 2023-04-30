using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Linq;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private List<string> speakerList = new List<string>();
    private int currentDialogueIndex = 0;

    void Start()
    {
        // ���� ������ ��ο� ���� �̸��� �Է��մϴ�.
        string path = Application.dataPath + "/Dialogue.xlsx";

        // ���� ������ �о���Դϴ�.
        //var excel = new ExcelQueryFactory(path);

        //���� ���Ͽ��� 'Dialogue' ��Ʈ�� �����մϴ�.
        
        //var dialogueSheet = from c in excel.Worksheet("Dialogue") select c;

        // ���� ������ �� �ึ�� ���� ȭ�� �̸��� �����ͼ� ����Ʈ�� �߰��մϴ�.
        //foreach (var row in dialogueSheet)
        //{
        //    speakerList.Add(row[1]);
        //}
    }

    void Update()
    {
        // ���콺 Ŭ�� �� ���� ��縦 ����մϴ�.
        if (Input.GetMouseButtonDown(0))
        {
            if (currentDialogueIndex < speakerList.Count)
            {
                tmp.text = speakerList[currentDialogueIndex];
                currentDialogueIndex++;
            }
        }
    }
}