/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//책의 정보를 담은 퓨어클래스 and 컨테이터 클래스
*//*class BookInfo
{
    public string name;
    public string authour;
    public string publisher;
    public string date;
}
*//*
/// <summary>
/// 1. 책 내용을 미리 등록한 후, 책의 정보를 이용하여 책을 검색하는 서비스
/// 2. 5권정도 도서를 등록
/// 3. Library라는 이름의 딕셔너리에 책을 넣는다.
/// </summary>
/// 


public class DictionaryStudy : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public InputField inputA;
    public InputField inputB;
    public Button searchBtn;
    public Button registerBtn;

    Dictionary<string, string> library = new Dictionary<string, string>();
    
    // Start is called before the first frame update
    void Start()
    {
        library.Add("1", "1,1");
        library.Add("2", "2,3");
        library.Add("3", "1,3");
        library.Add("4", "1,4");
        library.Add("5", "1,2");
*//*        BookInfo bookInfo = new BookInfo();
        bookInfo.name = "퓨처셀프";
        bookInfo.authour = "벤자민";
        bookInfo.publisher = "상상스퀘어";
        bookInfo.date = "2024.05.07";

        Dictionary<BookInfo, string> keyValuePairs = new Dictionary<BookInfo, string>();
*//*
    }

    // Update is called once per frame
    void Update()
    {
        //실습1
        //1. 도서등록:책 제목 또는 위치를 입력하여 도서 등록
        //2. 도서검색:책 제목 또는 위치를 입력받아 결과를 출력
    }

    public void RegisterBook()
    {
        print(dropdown.value);
        print(Input.text);
        
        //library.Add
    }
    public void SearchBook()
    {

    }

}
*/