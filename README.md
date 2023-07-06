# Description
A simple API Product with CRUD

# Features
This API developed with C#, DotNet 7, Postgresql, Docker
 
# Tech Used
 ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white) ![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
      
# Getting Start:
Before you running the program, make sure you've run this command:
- `dotnet restore`
- `appsettings.json with config db`
- `docker compose up -d`

### Run the program
`dotnet run`

The program will run on http://localhost:3000


### API Route List
| Method | URL | Description |
| ----------- | ----------- | ----------- | 
| GET | localhost:3000/product  | Get All Product |
| POST | localhost:3000/product  | Create Product |
| POST | localhost:3000/product/{id}  | Update Product |
| GET | localhost:3000/product/{id}  | Get Detail a Product |
| DELETE | localhost:3000/product/{id}  | Delete a Product |
 
<!-- </> with 💛 by readMD (https://readmd.itsvg.in) -->
