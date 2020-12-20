﻿using System;
using System.Collections.Generic;
using System.Text;
using DO;
using static DO.Enums;

namespace DS
{
    public static class DataSource
    {
        public static List<Bus> Buses;
        public static List<BusStation> Stations;
        public static List<BusLine> BusLines;
        public static List<BusDrive> BusDrives;
        public static List<BusLineStation> BusLineStations;
        public static List<LineOutForARide> LinesOutForARide; 
        public static List<ConsecutiveStations> ListConsecutiveStations;
        /// <summary>
        /// initialization function fo bus lines
        /// </summary>
        public static void createLists()
        {
            Buses = new List<Bus> 
            { 
                new Bus{Active=true,LicensePlate="12345678",DateActivity=new DateTime(2018,12,3),DateTreatment=new DateTime(2019,10,3),Totalkilometers=111,KilometersGas=338,KilometersTreatment=1211,AirTire=15,OilCondition=true},
                new Bus{Active=true,LicensePlate="22345678",DateActivity=new DateTime(2018,11,3),DateTreatment=new DateTime(2019,11,3),Totalkilometers=112,KilometersGas=339,KilometersTreatment=1131,AirTire=75,OilCondition=true},
                new Bus{Active=true,LicensePlate="32345678",DateActivity=new DateTime(2018,10,3),DateTreatment=new DateTime(2019,10,3),Totalkilometers=1113,KilometersGas=303,KilometersTreatment=1141,AirTire=165,OilCondition=true},
                new Bus{Active=true,LicensePlate="42345678",DateActivity=new DateTime(2018,9,3),DateTreatment=new DateTime(2018,2,3),Totalkilometers=114,KilometersGas=3333,KilometersTreatment=1115,AirTire=157,OilCondition=true},
                new Bus{Active=true,LicensePlate="52345678",DateActivity=new DateTime(2018,1,3),DateTreatment=new DateTime(2019,2,23),Totalkilometers=115,KilometersGas=3343,KilometersTreatment=1116,AirTire=150,OilCondition=true},
                new Bus{Active=true,LicensePlate="62345678",DateActivity=new DateTime(2017,6,3),DateTreatment=new DateTime(2017,12,23),Totalkilometers=116,KilometersGas=3336,KilometersTreatment=1116,AirTire=15,OilCondition=true},
                new Bus{Active=true,LicensePlate="72345678",DateActivity=new DateTime(2015,7,3),DateTreatment=new DateTime(2019,12,29),Totalkilometers=117,KilometersGas=3383,KilometersTreatment=1171,AirTire=145,OilCondition=true},
                new Bus{Active=true,LicensePlate="82345678",DateActivity=new DateTime(2016,3,3),DateTreatment=new DateTime(2018,12,22),Totalkilometers=118,KilometersGas=3339,KilometersTreatment=1118,AirTire=154,OilCondition=true},
                new Bus{Active=true,LicensePlate="92345678",DateActivity=new DateTime(2011,1,3),DateTreatment=new DateTime(2019,12,14),Totalkilometers=119,KilometersGas=3330,KilometersTreatment=1191,AirTire=15,OilCondition=true},
                new Bus{Active=true,LicensePlate="02345678",DateActivity=new DateTime(2012,2,3),DateTreatment=new DateTime(2020,12,15),Totalkilometers=110,KilometersGas=3363,KilometersTreatment=1112,AirTire=20,OilCondition=true},



            };
            Stations = new List<BusStation> 
            { 
                new BusStation{Active=true,BusStationKey="06311",StationAddress="עמק בית שאן 2",StationName="בית שאן",Latitude=1* (33.3 - 31) + 31,Longitude = 1 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="06143",StationAddress="אליהו הנביא 2",StationName="אליהו",Latitude=2* (33.3 - 31) + 31,Longitude = 2 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="06153",StationAddress="עמק האלה 23",StationName="אלה",Latitude=3* (33.3 - 31) + 31,Longitude = 3 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="06144",StationAddress="יחזקאל הנביא 16",StationName="יחזקל",Latitude=4* (33.3 - 31) + 31,Longitude = 4 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="01755",StationAddress="יחזקאל הנביא 9",StationName="יחזקל",Latitude=5* (33.3 - 31) + 31,Longitude = 5 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="01686",StationAddress="מרדכי מוטה גור 15",StationName="מרדכי",Latitude=6* (33.3 - 31) + 31,Longitude = 6 * (35.5 - 34.3) + 34.3},
                new BusStation{Active=true,BusStationKey="06797",StationAddress="חיים ברלב 45",StationName="חיים",Latitude=7* (33.3 - 31) + 31,Longitude = 7 * (35.5 - 34.3) + 34.3},
            };
            BusDrives = new List<BusDrive>
            {
                new BusDrive{Active=true,LicensePlate="12345611",ExitStart=new TimeSpan(11,23,4),TimeDrive=new TimeSpan(1,662,33),TimeNextStop=new TimeSpan(12,2,3),LastStasion=06101,BusDriverFirstName="mark",BusDriverLastName="smith",BusDriverId="017909168"},
                new BusDrive{Active=true,LicensePlate="12345612",ExitStart=new TimeSpan(06,11,2),TimeDrive=new TimeSpan(1,23,3),TimeNextStop=new TimeSpan(1,2,33),LastStasion=06101,BusDriverFirstName="james",BusDriverLastName="lay",BusDriverId="017909168"},
                new BusDrive{Active=true,LicensePlate="12345613",ExitStart=new TimeSpan(20,24,3),TimeDrive=new TimeSpan(1,32,3),TimeNextStop=new TimeSpan(1,2,34),LastStasion=064101,BusDriverFirstName="jessi",BusDriverLastName="white",BusDriverId="01786543"},
                new BusDrive{Active=true,LicensePlate="12345614",ExitStart=new TimeSpan(33,4,5),TimeDrive=new TimeSpan(13,2,3),TimeNextStop=new TimeSpan(1,2,83),LastStasion=0611601,BusDriverFirstName="joul",BusDriverLastName="night",BusDriverId="01790111"},
                new BusDrive{Active=true,LicensePlate="12345615",ExitStart=new TimeSpan(7,8,9),TimeDrive=new TimeSpan(13,2,3),TimeNextStop=new TimeSpan(19,2,3),LastStasion=061107,BusDriverFirstName="ellen",BusDriverLastName="poal",BusDriverId="017900068"},
                new BusDrive{Active=true,LicensePlate="12345616",ExitStart=new TimeSpan(3,5,6),TimeDrive=new TimeSpan(1,2,33),TimeNextStop=new TimeSpan(1,82,3),LastStasion=069101,BusDriverFirstName="jacson",BusDriverLastName="noal",BusDriverId="01999168"},
                new BusDrive{Active=true,LicensePlate="12345876",ExitStart=new TimeSpan(3,5,6),TimeDrive=new TimeSpan(1,23,3),TimeNextStop=new TimeSpan(1,24,3),LastStasion=0687101,BusDriverFirstName="jacson",BusDriverLastName="wester",BusDriverId="033309168"},
                new BusDrive{Active=true,LicensePlate="12345617",ExitStart=new TimeSpan(3,4,69),TimeDrive=new TimeSpan(1,2,34),TimeNextStop=new TimeSpan(1,21,3),LastStasion=066101,BusDriverFirstName="percy",BusDriverLastName="jacson",BusDriverId="07779168"},
                new BusDrive{Active=true,LicensePlate="12345618",ExitStart=new TimeSpan(11,2,4),TimeDrive=new TimeSpan(2,3,45),TimeNextStop=new TimeSpan(1,2,23),LastStasion=057101,BusDriverFirstName="harry",BusDriverLastName="potter",BusDriverId="066609168"},
                new BusDrive{Active=true,LicensePlate="12345619",ExitStart=new TimeSpan(13,2,2),TimeDrive=new TimeSpan(10,02,9),TimeNextStop=new TimeSpan(1,2,63),LastStasion=821101,BusDriverFirstName="ron",BusDriverLastName="wez",BusDriverId="017999998"},
                new BusDrive{Active=true,LicensePlate="12345610",ExitStart=new TimeSpan(33,4,5),TimeDrive=new TimeSpan(11,0,21),TimeNextStop=new TimeSpan(1,2,36),LastStasion=901101,BusDriverFirstName="america",BusDriverLastName="singer",BusDriverId="04449168"},
            };

            BusLines = new List<BusLine>
            {  new BusLine{Active=true,BusLineNumber = 134,FirstStopNumber = "123456",LastStopNumber="987463",Area=(int)Zones.General},
               new BusLine{Active=true,BusLineNumber = 14,FirstStopNumber = "128256",LastStopNumber="917453",Area=(int)Zones.Zefat},
               new BusLine{Active=true,BusLineNumber = 112,FirstStopNumber = "120486",LastStopNumber="680463",Area=(int)Zones.Alon_Shvut},
               new BusLine{Active=true,BusLineNumber = 9,FirstStopNumber = "188456",LastStopNumber="907453",Area=(int)Zones.Beer_Sheva},
               new BusLine{Active=true,BusLineNumber = 22,FirstStopNumber = "120457",LastStopNumber="917563",Area=(int)Zones.Zeev_hill},
               new BusLine{Active=true,BusLineNumber = 19,FirstStopNumber = "193406",LastStopNumber="967061",Area=(int)Zones.Alon_Shvut},
               new BusLine{Active=true,BusLineNumber = 10,FirstStopNumber = "103456",LastStopNumber="937163",Area=(int)Zones.Itamar},
               new BusLine{Active=true,BusLineNumber = 233,FirstStopNumber = "123497",LastStopNumber="387563",Area=(int)Zones.Gush_Dan},
               new BusLine{Active=true,BusLineNumber = 7,FirstStopNumber = "120896",LastStopNumber="989453",Area=(int)Zones.Jerusalem_Corridor},
               new BusLine{Active=true,BusLineNumber = 80,FirstStopNumber = "684729",LastStopNumber="573625",Area=(int)Zones.General},
               new BusLine{Active=true,BusLineNumber =4,FirstStopNumber = "137563",LastStopNumber="958473",Area=(int)Zones.Ramat_Gan},
               new BusLine{Active=true,BusLineNumber = 119,FirstStopNumber = "198574",LastStopNumber="564738",Area=(int)Zones.Beer_Sheva},
               new BusLine{Active=true,BusLineNumber = 68,FirstStopNumber = "124209",LastStopNumber="980973",Area=(int)Zones.Gush_Etzion},
               new BusLine{Active=true,BusLineNumber = 89,FirstStopNumber = "249583",LastStopNumber="867490",Area=(int)Zones.Alon_Shvut},
               new BusLine{Active=true,BusLineNumber = 1,FirstStopNumber = "984763",LastStopNumber="123432",Area=(int)Zones.Jerusalem_Corridor},
               new BusLine{Active=true,BusLineNumber = 5,FirstStopNumber = "098453",LastStopNumber="109089",Area=(int)Zones.General},
               new BusLine{Active=true,BusLineNumber = 65,FirstStopNumber = "158749",LastStopNumber="198674",Area=(int)Zones.Itamar},
               new BusLine{Active=true,BusLineNumber = 55,FirstStopNumber = "678594",LastStopNumber="123543",Area=(int)Zones.Ramat_Gan},
               new BusLine{Active=true,BusLineNumber = 117,FirstStopNumber = "234564",LastStopNumber="689043",Area=(int)Zones.Zeev_hill},
               new BusLine{Active=true,BusLineNumber = 115,FirstStopNumber = "098532",LastStopNumber="574839",Area=(int)Zones.Galilee}
            };
            BusLineStations = new List<BusLineStation>
            {
                new BusLineStation{Active=true,CodeStation="1758493",NumberStationInLine=1},
                new BusLineStation{Active=true,CodeStation="1758493",NumberStationInLine=2},
                new BusLineStation{Active=true,CodeStation="1758493",NumberStationInLine=3},
                new BusLineStation{Active=true,CodeStation="989890",NumberStationInLine=4},

            };

            

           

        }
       
    }
   
  
}
