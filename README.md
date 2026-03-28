# 🎵 ManageAlbumsApp

**ManageAlbumsApp** is a simple .NET MAUI application built with C# that allows users to manage a collection of music albums. Users can add albums, view all albums, or filter albums by year of production. The app demonstrates event-driven UI programming, input validation, and basic data management in a desktop/mobile environment.

---

## 📱 Features

- Add new albums with **Title**, **Band/Artist**, and **Year Produced**
- View all albums in the collection
- Filter albums by minimum year of production
- Real-time feedback on invalid inputs
- Clean and user-friendly interface

---

## 🛠️ Technologies Used

- C#
- .NET MAUI
- XAML for UI
- Event-driven programming

---

## 📂 Project Structure
ManageAlbumsApp/
│── Models/
│ └── Album.cs # Album data model
│ └── AlbumManager.cs # Handles album collection and operations
│
│── Views/
│ └── MainPage.xaml # UI layout
│ └── MainPage.xaml.cs # Code-behind (event handling)


---

## ⚙️ How It Works

### Adding an Album
- Users enter the album **Title**, **Band/Artist**, and **Year Produced**
- Input is validated; errors are displayed if fields are empty or the year is invalid
- Successfully added albums are stored in `_albumManager` and displayed in the interface

### Viewing Albums
- **Show All Albums**: Displays all albums in the collection
- **Show Albums By Year**: Filters and displays albums with a year greater than or equal to the entered year

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET MAUI workload installed

### Run the App
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/ManageAlbumsApp.git
