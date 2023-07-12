#### Login Response

- [Clean Architecture APi](#clean-architecture-api)
    - [Auth](#auth)
        - [Register Request](#register-request)
        - [Register Response](#register-response)
    - [Auth](#auth)
        - [Login Request](#login-request)
        - [Login Response](#login-response)

## Auth

### Register
````js
POST {{host}}/auth/register
````

#### Register Request
````json
{
"id": "120",
"firstNam": "mohamed",
"lastName": "fetni",
"email": "fetni.wassim@gmail.com",
"password":  "qwerty"
}
````
#### Register Response
````js
200 OK
````
````json
{
"id": "120",
"firstNam": "mohamed",
"lastName": "fetni",
"email": "fetni.wassim@gmail.com",
"password":  "qwerty",
"token":"token"
}
````

### Login
````js
POST {{host}}/auth/register
````

#### Login Request
````json
{
"email": "fetni.wassim@gmail.com",
"password":  "qwerty"
}
````
#### Login Response
````js
200 OK
````
````json
{
"id": "120",
"firstNam": "mohamed",
"lastName": "fetni",
"email": "fetni.wassim@gmail.com",
"token":"token"
}
````