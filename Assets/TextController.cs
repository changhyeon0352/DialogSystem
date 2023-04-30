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
        // 엑셀 파일의 경로와 파일 이름을 입력합니다.
        string path = Application.dataPath + "/Dialogue.xlsx";

        // 엑셀 파일을 읽어들입니다.
        //var excel = new ExcelQueryFactory(path);

        //엑셀 파일에서 'Dialogue' 시트를 선택합니다.
        
        //var dialogueSheet = from c in excel.Worksheet("Dialogue") select c;

        // 엑셀 파일의 각 행마다 대사와 화자 이름을 가져와서 리스트에 추가합니다.
        //foreach (var row in dialogueSheet)
        //{
        //    speakerList.Add(row[1]);
        //}
    }

    void Update()
    {
        // 마우스 클릭 시 다음 대사를 출력합니다.
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