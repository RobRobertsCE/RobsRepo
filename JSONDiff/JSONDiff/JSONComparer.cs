using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONDiff
{
    public class JSONComparer
    {
//        JsonSchema schema = JsonSchema.Parse(@"{
//  'type': 'object',
//  'properties': {
//    'name': {'type':'string'},
//    'hobbies': {'type': 'array'}
//  }
//}");

//        JObject person = JObject.Parse(@"{
//  'name': 'James',
//  'hobbies': ['.NET', 'LOLCATS']
//}");

//        bool valid = person.IsValid(schema);
//        // true


//        Product product = new Product();
//product.Name = "Apple";
//product.Expiry = new DateTime(2008, 12, 28);
//product.Sizes = new string[] { "Small" };
 
//string json = JsonConvert.SerializeObject(product);
////{
////  "Name": "Apple",
////  "Expiry": "2008-12-28T00:00:00",
////  "Sizes": [
////    "Small"
////  ]
////}


//        Serialize JSONstring json = @"{
//  'Name': 'Bad Boys',
//  'ReleaseDate': '1995-4-7T00:00:00',
//  'Genres': [
//    'Action',
//    'Comedy'
//  ]
//}";

//Movie m = JsonConvert.DeserializeObject<Movie>(json);

//string name = m.Name;
// Bad Boys

        public void Compare<T>(string master, string toCompare)
        {

//            JObject person = JObject.Parse(@"{
//              'name': 'James',
//              'hobbies': ['.NET', 'LOLCATS']
//            }");

           

            dynamic dynObj = JsonConvert.DeserializeObject(master);
            dynamic dynObj1 = JsonConvert.DeserializeObject(toCompare);

            //JContainer is the base class
            var jObj = (JObject)dynObj;
            var jObj1 = (JObject)dynObj1;

            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;
                    Console.WriteLine("Testing {0}={1}", prop.Name, prop.Value);

                    var prop1 = jObj1.Children<JProperty>().Where((c) => c.Name == prop.Name).FirstOrDefault();

                    if (prop1 != null)
                    {
                        Console.WriteLine("found matching property");
                        Console.WriteLine("Comparing values {0}={1}", prop.Value, prop1.Value);
                        // test values 

                        

                        if (prop1.Value.ToString() == prop.Value.ToString())
                        {
                            Console.WriteLine("found matching values");
                        }
                        else
                        {
                            Console.WriteLine("found differing values");
                        }
                    }
                    else
                    {
                        Console.WriteLine("did not find matching property");
                    }                    
                }
            }

        }
    }
}
