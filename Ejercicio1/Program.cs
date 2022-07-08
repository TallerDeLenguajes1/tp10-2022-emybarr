
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ejercicio1{

     public class Program{

        
        static void Main(string[] args) {

           GetCivili();

        }

        private static List<CivilizationLista> GetCivili(){
            var request = (HttpWebRequest)WebRequest.Create("https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try {
                using (WebResponse response = request.GetResponse()) {
                    using (Stream strReader = response.GetResponseStream()) {
                        using (StreamReader objReader = new StreamReader(strReader)) {
                            string responseBody = objReader.ReadToEnd();

                            var cLista = JsonSerializer.Deserialize<CivilizationLista>(responseBody);

                            foreach(Civilization civilization in cLista.Civilizations) {
                                Console.WriteLine(civilization.Id + "- " + civilization.Name);
                            }

                        }
                    }
                }
            } catch (WebException ex) {
                Console.WriteLine("alto error");
            }
            return null;
        }
    }
}
