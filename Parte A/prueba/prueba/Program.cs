// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using prueba.Model;
using System.Text.Json;

DirectoryInfo directory = new DirectoryInfo(@"\\Mac\Home\Desktop\prueba\prueba\JsonFiles");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
int filesQuant = files.Length; //get files quantity by counting the number of json files at "files".

List<User> users = new List<User>();

for (int i = 0; i < filesQuant; i++)
{
    string fileName = "u" + i + ".json";
    string root_JSON_data = File.ReadAllText(@"\\Mac\Home\Desktop\prueba\prueba\JsonFiles\" + $"{fileName}");

    User myDeserializedClass = JsonConvert.DeserializeObject<User>(root_JSON_data);

    
    if (myDeserializedClass != null)

    {
        users.Add(myDeserializedClass);

    }
}

Module newModule = new Module();

for (int i = 0; i < users.Count; i++)
{
    string fileUsing = "u" + i + ".json";

    switch (users[i].provider.content_module)
    {
        case "authz.provider_1":
            newModule.content_module.AuthzProvider1.Add(fileUsing);
            break;
        case "authz.provider_2":
            newModule.content_module.AuthzProvider2.Add(fileUsing);
            break;
        case "authz.provider_3":
            newModule.content_module.AuthzProvider3.Add(fileUsing);
            break;
        case "authz.provider_4":
            newModule.content_module.AuthzProvider4.Add(fileUsing);
            break;
    }

    switch (users[i].provider.auth_module)
    {
        case "authn.provider_1":
            newModule.auth_module.AuthnProvider1.Add(fileUsing);
            break;
        case "authn.provider_2":
            newModule.auth_module.AuthnProvider2.Add(fileUsing);
            break;
        case "authn.provider_3":
            newModule.auth_module.AuthnProvider3.Add(fileUsing);
            break;
        case "authn.provider_4":
            newModule.auth_module.AuthnProvider4.Add(fileUsing);
            break;
    }
}

string returnJson = JsonConvert.SerializeObject(newModule);
File.WriteAllText(@"data.json", returnJson);

JObject parsed = JObject.Parse(returnJson); //to visualize console output as json
File.WriteAllText(@"data.json", returnJson);
Console.WriteLine(parsed);

