Table of content 
1. Response Status Code
2. Authentication
3. [Resources](#Resources)
    1. [Users](#user-sample) 

## Resources

### user-sample

#### get attribute of users dto

```
GET /api/Users/index
```

response body (in plain text)
```
LoginFailedCount
LoginFailedAt
LastLogin
unlockDate
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

response body (json)
```json
[
  {
    "loginFailedCount": 0,
    "loginFailedAt": null,
    "lastLogin": null,
    "unlockDate": null,
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

request body example:
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