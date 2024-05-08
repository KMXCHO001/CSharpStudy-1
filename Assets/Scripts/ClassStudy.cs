using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ClassStudy : MonoBehaviour
{
    [SerializeField] TMP_InputField vehicleNumberInput;
    [SerializeField] Button registerBtn;

    public class Car
    {
        public string carnumber;
        public DateTime date;
        public Car(int carNumber, DateTime date)
        {
            this.carNumber = carNumber;
            this.date = date;
        }

    }


    public class ParkingLot
    {
        List<Car> cars = new List<Car>();

        public void Incar(string carNumber)
        {
            Car car = new Car(carNumber,DateTime.Now);
            cars.Add(car);
        }

        public void Outcar()
        {
            Car carFound = cars.Find(x => x.carnumber == carNumber);
            cars.Remove(carFound);
        }

        public void ShowCarList()
        {

        }

        ParkingLot parkingLot;

        void Start()
        {
            parkingLot car = new ParkingLot();
            parkingLot.Incar("5555");
            parkingLot.ShowCarList();

            //주차장 관리시스템
            //1. Car 클래스 -> 차량번호, 입차시간을 필드로 가지는 클래스
            //2. ParkingLot 클래스 -> Car클래스를 넣을 수 있는 컬렉션으로 자동차를 관리
            //2-1. 차량 입차, 출차 기능(메서드), 현재 주차된 목록 출력 기능
        }

        public void OnRegisterBtnClkEvent()
        {
            print("parkingLot을 만들어 주세요.");
            return;
        }

        parkingLot.Incar(vehicleNumberInput.text);
        parkingLot.ShowCarList();

       


    }
}

