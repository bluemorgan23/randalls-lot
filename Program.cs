/*
    Author: Chris Morgan
    Date: May 28th, 2019
    Exercise: Randall's Car Lot C# Challenge
 */

using System;
using System.Collections.Generic;

namespace randalls_lot
{

    class Program
    {

        static void Main(string[] args)
        {
            
            

            Dictionary<string, string> carOneInfo = new Dictionary<string, string>() {
                {"year", "2008"},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "sky magenta"}
            };

            Dictionary<string, string> carOneSID = new Dictionary<string, string>() {
                {"sales_id", "ecb1c841-1a43-4a7c-896e-712d2ec39c71"}
            };

            Dictionary<string, string> datePurchasedOne = new Dictionary<string, string>() {
                {"purchase_date", "2017-11-15"}
            };

            Dictionary<string, string> profitOne = new Dictionary<string, string>() {
                {"gross_profit", "871.26"}
            };

            Dictionary<string, string> carOneAgent = new Dictionary<string, string>();
            carOneAgent.Add("mobile", "(896) 478-6975");
            carOneAgent.Add("last_name", "Botsford");
            carOneAgent.Add("first_name", "Shaina");
            
            Dictionary<string, string> carOneCredit = new Dictionary<string, string>();
            carOneCredit.Add("credit_provider", "J.P.Morgan Chase & Co");
            carOneCredit.Add("account", "someNumber");

            Dictionary<string, Dictionary<string,string>> carOne = new Dictionary<string, Dictionary<string, string>>();

            carOne.Add("vehicle", carOneInfo);
            carOne.Add("sales_id", carOneSID);
            carOne.Add("sales_agent", carOneAgent);
            carOne.Add("purchase_date", datePurchasedOne);
            carOne.Add("gross_profit", profitOne);
            carOne.Add("credit", carOneCredit);

            Dictionary<string, string> carTwoInfo = new Dictionary<string, string>() {
                {"year", "2010"},
                {"model", "Hotquadtrax"},
                {"make", "Transtinntehcno"},
                {"color", "robin egg blue"}
            };

            Dictionary<string, string> carTwoSID = new Dictionary<string, string>() {
                {"sales_id", "a2f80554-bd9d-4ea1-8229-01fd4cf220a8"}
            };

            Dictionary<string, string> datePurchasedTwo = new Dictionary<string, string>() {
                {"purchase_date", "2017-04-28"}
            };

            Dictionary<string, string> profitTwo = new Dictionary<string, string>() {
                {"gross_profit", "156.02"}
            };

            Dictionary<string, string> carTwoAgent = new Dictionary<string, string>();
            carTwoAgent.Add("mobile", "562.300.2912");
            carTwoAgent.Add("last_name", "Davis");
            carTwoAgent.Add("first_name", "Gerardo");
            
            Dictionary<string, string> carTwoCredit = new Dictionary<string, string>();
            carTwoCredit.Add("credit_provider", "PNC Financial Services");
            carTwoCredit.Add("account", "34578280562836");

            Dictionary<string, Dictionary<string,string>> carTwo = new Dictionary<string, Dictionary<string, string>>();

            carTwo.Add("vehicle", carTwoInfo);
            carTwo.Add("sales_id", carTwoSID);
            carTwo.Add("sales_agent", carTwoAgent);
            carTwo.Add("purchase_date", datePurchasedTwo);
            carTwo.Add("gross_profit", profitTwo);
            carTwo.Add("credit", carTwoCredit);

            Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>> vehicles = new Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>>();

            List<Dictionary<string, Dictionary<string, string>>> listOfVehicles = new List<Dictionary<string, Dictionary<string, string>>>(){
                carOne, carTwo
            };

            vehicles.Add("vehicles", listOfVehicles);

            foreach(List<Dictionary<string, Dictionary<string, string>>> vehicleCollection in vehicles.Values){

                foreach(Dictionary<string, Dictionary<string, string>> vehicleInfoValues in vehicleCollection) {

                    Console.WriteLine(" ");
                    Console.WriteLine("Vehicle Information: ");

                    foreach(Dictionary<string, string> VehicleData in vehicleInfoValues.Values){
                        foreach(KeyValuePair<string, string> valueKey in VehicleData) {
                            Console.WriteLine($"{valueKey.Key}: {valueKey.Value}");
                        }
                    }
                }
            }

        
        }

    }
}

