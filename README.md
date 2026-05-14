# .NET Learning Projects - Week 01

## Project Overview

This repository contains two .NET learning projects completed during Week 01:

1. **Create a web API with ASP.NET Core controllers** - A RESTful API project for managing pizza inventory
2. **Sales Summary** - A file processing utility that generates sales summary reports from JSON data

---

## Project 1: Web API with ASP.NET Core Controllers

### Location
`week01/ContosoPizza/`

### Description
A RESTful web API built with ASP.NET Core that demonstrates CRUD operations using controllers. The API manages a collection of pizza items with properties like Id, Name, Price, and Vegetarian status.

### Evidence of Completion

#### Existing API Endpoints (from module)

The following endpoints were implemented as part of the module:

**GET /api/pizza** 
```json
[
  {
    "id": 1,
    "name": "Margherita",
    "price": 12.99,
    "vegetarian": true
  },
  {
    "id": 2,
    "name": "Pepperoni",
    "price": 14.99,
    "vegetarian": false
  },
  {
    "id": 3,
    "name": "Hawaiian",
    "price": 13.99,
    "vegetarian": false
  }
]
```
**GET /api/pizza/1**
```json
{
  "id": 1,
  "name": "Margherita",
  "price": 12.99,
  "size": "Large"
}
```
**POST /api/pizza**
```json
{
  "name": "Hawaiian",
  "price": 16.99,
  "size": "Large"
}
```
**PUT /api/pizza**
```json
{
    "id": 3,
    "name": "Hawaiian",
    "isGlutenFree": false
}
```

**DELETE** {{ContosoPizza_HostAddress}}/pizza/3


## Project 2: Sales Summary
### Location
`week01/mslearn-dotnet-files/`

### Description
Add an additional function that generates a sales summary report file. The file should contain simple text that shows the actual sales total from the file and a detailed report of each file's total sales.
The file location is in week01\mslearn-dotnet-files\salesTotalDir\SalesSummaryReport.txt