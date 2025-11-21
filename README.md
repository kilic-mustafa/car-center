# CarCenter 🚗

A simple ASP.NET Core MVC demo application for managing cars.

## 🧭 Overview

CarCenter is a lightweight web application that allows users to add, list, view details, update, and delete car records.
It uses in-memory data storage and Razor Views for server-side rendering.

## 📁 Project Structure

**Controller:** CarController  
**Actions:** Create, List, Detail, Update, Delete  
**Model:** CarModel  

**Views:**
- List.cshtml
- Create.cshtml
- Update.cshtml
- Detail.cshtml

**Layout:** _Layout.cshtml  
**Startup:** Program.cs

## ⚙️ Requirements

- .NET 9 SDK  
- Visual Studio / VS Code Rider (optional)

## ▶️ Run (Development)

```bash
# Navigate to the solution root
cd CarCenter

# Run the project
dotnet run --project CarCenter/CarCenter.csproj
```

Then open your browser at the shown URL (see launchSettings.json).

## 🌐 Routes

| HTTP Method | Route | Description |
|--------------|--------|-------------|
| GET | /Car/List | List all cars |
| GET | /Car/Create | Show create form |
| POST | /Car/Create | Create a new car |
| GET | /Car/Detail/{id} | View car details |
| GET | /Car/Update/{id} | Show update form |
| POST | /Car/Update | Submit updated data |
| POST | /Car/Delete | Delete a car |

## 🧩 Notes

- Data is stored in-memory via a static list in `CarController`.
- No external database is used.
- Model validation attributes are defined in `CarModel`.

## 🤝 Contributing

Pull requests are welcome!  
If you find a bug or have an idea, feel free to open an issue or submit a PR.
