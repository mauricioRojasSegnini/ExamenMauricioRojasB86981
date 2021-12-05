using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RojasB86981ExamenInge.Models
{
    public class JsonContentParser
    {
        private string[] ExtractRawContent(string fileName)
        {
            return File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data_Files/" + fileName));
        }

        public string ParseRawJson(string[] content)
        {
            string contentExtracted = "";
            foreach (string line in content)
            {
                contentExtracted += line + "\n";
            }
            return contentExtracted;
        }

        public dynamic ParseFromJSON(string fileName)
        {
            dynamic parsedContent = "";
            try
            {
                string[] rawData = ExtractRawContent(fileName);
                string contentReadyToParse = ParseRawJson(rawData);
                parsedContent = JsonConvert.DeserializeObject(contentReadyToParse);
            }
            catch (Exception e)
            {
                string error = "Error while parsing JSON raw data \n" + e.ToString();
                Debug.WriteLine(error);
            }
            return parsedContent;
        }

        public List<string> GetListFromString(string content)
        {
            List<string> listFromContent = new List<string>();
            string[] contentList = content.Split('|');
            foreach (string contentInList in contentList)
            {
                if (contentInList != "")
                {
                    listFromContent.Add(contentInList.Replace("_", " "));
                }
            }
            return listFromContent;
        }

        public string GetStringFromList(List<string> listContent)
        {
            string content = "";

            foreach (string element in listContent)
            {
                content += element.Replace(" ", "_") + "|";
            }

            return content;
        }

        public List<PizzaMenuModel> GetProductsOnMenuFromJson(dynamic jsonCollection)
        {
            List<PizzaMenuModel> pizzaOnMenu = new List<PizzaMenuModel>();
            foreach (var element in jsonCollection)
            {
                pizzaOnMenu.Add(new PizzaMenuModel
                {
                    Image = element.Image,
                    Name = element.Name,
                    Description = element.Description,
                    Price = element.Price,
                    Accompaniment = element.Accompaniment,
                    Ingredients = element.Ingredients
                    
                });
            }
            return pizzaOnMenu;
        }

        public List<PersonalPizzaModel> GetPersonalPizzaFromJson(dynamic jsonCollection)
        {
            List<PersonalPizzaModel> pizza = new List<PersonalPizzaModel>();
            foreach (var element in jsonCollection)
            {
                pizza.Add(new PersonalPizzaModel
                {
                    name = element.name,
                    tag = element.tag,
                    Size = element.Size,
                    Sauce = element.Sauce,
                    Mass = element.Mass,
                    Extras = element.Extras,
                    Ingredients = element.Ingredients,
                    Note = element.Note,
                    inCart = element.inCart,
                    price = element.price


                });
            }
            return pizza;
        }

        public List<Model> GetContentsFromJson<Model>(string jsonFile, Func<dynamic, List<Model>> GetModelsFromJson)
        {
            List<Model> models = new List<Model>();
            try
            {
                string[] rawContent = ExtractRawContent(jsonFile);
                string jsonString = ParseRawJson(rawContent);
                dynamic jsonCollection = JsonConvert.DeserializeObject(jsonString);
                models = GetModelsFromJson(jsonCollection);
            }
            catch
            {
                models = null;
            }
            return models;
        }


        public bool WriteToJsonFile<Model>(string fileName, Model model, Func<dynamic, List<Model>> GetModelsFromJson)
        {
            bool success = false;
            string jsonString = JoinNewData<Model>(fileName, model, GetModelsFromJson);
            try
            {
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data_Files/" + fileName), jsonString);
                success = true;
            }
            catch
            {
                Debug.WriteLine("Error occurred");
            }
            return success;
        }

        public string JoinNewData<Model>(string fileName, Model model, Func<dynamic, List<Model>> GetModelsFromJson)
        {
            string resultingJson = "";
            try
            {
                string[] rawJson = ExtractRawContent(fileName);
                string json = ParseRawJson(rawJson);
                dynamic jsonCollection = JsonConvert.DeserializeObject(json);
                List<Model> previousModels = GetModelsFromJson(jsonCollection);

                previousModels.Add(model);
                resultingJson = JsonConvert.SerializeObject(previousModels);
            }
            catch
            {
                Debug.WriteLine("Error occurred");
            }
            return resultingJson;
        }
    }
}