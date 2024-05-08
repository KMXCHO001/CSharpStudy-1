using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // method
    //접근지정자, 리턴형(void), 클래스 이름(speak)
    public void Speak()
    {

    }

    public string Speak(string message) //메서드 오버로드 - 다형성 예
    {
        return message;
    }
}

public class Vehicle
{
    public void Honk()
    {

    }
}

public class Car : Vehicle
{   
    public Car()
    {

    }
    public void Accelerate()
    {
        this.Honk();
    }
}

public class Truck : Vehicle
{
    public void Accelerate()
    {
        this.Honk();
    }
}

public class Bus : Vehicle
{
    public void Accelerate()
    {
        this.Honk();
    }
}

public class ClassStudy : MonoBehaviour
{   
    
    void Start()
    {
        Person p1 = new Person("김철희", 29);
        //p1.name = "김철희"; //필드 값을 대입
        //p1.age = 29;

        print(p1.Speak("Hello"));

        //주차장 관리시스템
        //1. Car 클래스 -> 차량번호, 입차시간을 필드로 가지는 클래스
        //2. ParkingLot 클래스 -> Car클래스를 넣을 수 있는 컬렉션으로 자동차를 관리
        //2-1. 차량 입차, 출차 기능(메서드), 현재 주차된 목록 출력 기능
    }

    Car car = new Car();
    

}

