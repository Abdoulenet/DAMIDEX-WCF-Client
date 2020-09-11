using DAMIDEX_WCF_Client.WCFRenaultService;
using System.Collections.Generic;

namespace DAMIDEX_WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize the service
            RenaultServiceClient renaultService = new RenaultServiceClient();
            var renaultToken = "Qnvouc12Y3Q=";

            // The code bellow allows you to call the method (Genereer Rapport Expertise) by using the VIN , you can use this method to get the reports as PDF ,and the pictures compressed to zip 
            var vinReport = renaultService.GenerrerRapportExpertise("", null, "VF1ABL1BBUC252259", renaultToken);

            // The code bellow allows you to call the method (Genereer Rapport Expertise) by using the Plate number , you can use this method to get the reports as PDF ,and the pictures compressed to zip 
            var plateNumberReport = renaultService.GenerrerRapportExpertise("89223H1", null, "", renaultToken);

            //the code below allows you to create automatically a new mission on our System
            VehicleDTO vehicule = new VehicleDTO();
            vehicule.Body = "J5";
            vehicule.Brand = "RENAULT";
            vehicule.Color = "Blanc";
            vehicule.DateOfCirculation = "30/11/2016";
            vehicule.Energy = Energies.DI;
            vehicule.Label = null;
            vehicule.Mileage = 93400;
            vehicule.Model = "2.0 dCi 175 Privilège BVA";
            vehicule.NumPVO = "95123";
            vehicule.Label = "label";

            vehicule.Power = 5;
            vehicule.Registration = "70029H6";
            vehicule.SeatingPlaces = 5;
            vehicule.Type = "VP";
            vehicule.VIN = "WAUZZZ4G7DN098300";
            vehicule.IdSite = "RCMA SUCCURSALE LISSASFA";
            vehicule.NotificationLink = "https://www.pvo2.fr/api/reclamation-cost/inspection/xxxxxxx/xxxxxxx/xxxxxxx/{inspectionId}";
            vehicule.CommercialName = "First Name Last Name";
            vehicule.IsSentToClient = false;

            var result = renaultService.CreateInspection(vehicule, renaultToken);


        }
    }
}
