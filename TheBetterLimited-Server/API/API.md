Table of content 
1. Response Status Code
2. Authentication
3. [Resources](#Resources)
    1. [Users](#Users) 

## Resources

### Users

#### get attribute of users dto

```
GET /api/Users/index
```

example request
```c#
var client = new RestClient("http://localhost:5233/api/Users/index");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", $"Bearer {your token here}");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
```

example response body (in plain text)
```
Id
UserName
Password
EmailAddress
Status
Remarks
```

---

#### get the users account in the system

```
GET /api/Users?limit={limit}
```

example response body
```json
[
  {
    "id": "strin",
    "userName": "string",
    "password": "string",
    "emailAddress": "user@example.com",
    "status": "O",
    "remarks": "string"
  }
]
```

you may get HTTP BadRequests if the limit is out of range
```
Limit too large or too small
```

---

#### create a user 

```
POST /api/Users
```

example request body example:
```json
{
  "id": "strin",
  "userName": "string",
  "password": "string",
  "emailAddress": "user@example.com",
  "status": "O",
  "remarks": "string"
}
```

response body (json)
 TODO



---