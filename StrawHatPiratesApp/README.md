# Straw Hat Pirates App

This project is a simple .NET application that generates a list of the Straw Hat Pirates from the popular anime and manga series, One Piece. It provides an API to retrieve the names and main powers of each pirate.

## Features

- **Pirates List**: An endpoint to get a list of Straw Hat Pirates along with their names and two main powers.

## Getting Started

To run this application, follow these steps:

1. **Clone the repository**:
   ```
   git clone <repository-url>
   cd StrawHatPiratesApp
   ```

2. **Install dependencies**:
   Make sure you have the .NET SDK installed. You can install the necessary packages by running:
   ```
   dotnet restore
   ```

3. **Run the application**:
   Start the application using the following command:
   ```
   dotnet run
   ```

4. **Access the API**:
   Once the application is running, you can access the list of Straw Hat Pirates by navigating to:
   ```
   http://localhost:5000/api/pirates
   ```

## Project Structure

- **Controllers**: Contains the `PiratesController` which handles HTTP requests.
- **Models**: Contains the `Pirate` model representing a pirate's name and powers.
- **Views**: (Currently empty, can be used for future UI components)
- **Program.cs**: Entry point of the application.
- **appsettings.json**: Configuration settings for the application.
- **StrawHatPiratesApp.csproj**: Project file containing metadata and dependencies.

## Contributing

Feel free to submit issues or pull requests for improvements or new features.