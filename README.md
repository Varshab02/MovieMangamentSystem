Movie Management System

Description

The Movie Management System is a Windows Forms application that allows users to manage a collection of movies. The application supports CRUD operations, navigation between movie records, data persistence using JSON, and follows a multi-layered architecture.


Features:
Functional Requirements
Manage Movies:
Add a new movie.
Update an existing movie's details.
Delete a movie.
View the list of movies.


Movie Details:
Movie ID (unique)
Title
Genre
Release Year
Director

Navigation:
Navigate between the movie records (First, Previous, Next, Last).

Data Persistence:
Save movie data to a JSON file.
Load movie data from a JSON file.


Validation:
Ensure the Movie ID is unique.
Validate that all required fields (Title, Genre, Release Year) are filled before adding or updating.

Non-Functional Requirements

Multi-layered Architecture:

Presentation Layer (WinForms UI)
Business Logic Layer (Handles validation and processing)
Data Access Layer (Manages data storage and retrieval)


Use of Hashtable:
In-memory storage using a Dictionary<int, Movie> where Movie ID is the key.

Interfaces:
IMovieService interface for CRUD operations.

Extension Methods:
Extension method to retrieve all movies as a list from Dictionary<int, Movie>.

JSON Serialization:
Serialize Dictionary<int, Movie> data to JSON for saving.

Deserialize JSON to reload data.
Steps to Create the Project
1. Set Up the Project
Open Visual Studio and create a new Windows Forms App (.NET Framework) project.
Add two Class Library projects: Business Logic Layer (BLL) and Data Access Layer (DAL).

2. Create Data Model
In the DAL project, create a Movie class with properties: MovieID, Title, Genre, ReleaseYear, and Director.
Use a Dictionary<int, Movie> to store movie records.

3. Implement Data Access Layer
Create a class MovieRepository that handles CRUD operations using the Dictionary<int, Movie>.
Implement methods for Add, Update, Delete, Get All Movies.
Use JSON serialization to save/load movie data.

4. Implement Business Logic Layer
Create an IMovieService interface defining CRUD operations.
Implement MovieService class that uses MovieRepository.
Add validation for unique MovieID and required fields.

5. Create Windows Forms UI
Design the form with text fields for movie details and buttons for Add, Update, Delete, Save, Load, First, Previous, Next, Last.
Use MovieService to handle user actions.

6. Implement Navigation
7. Store the current movie index and update displayed details when navigating.

8. Implement Save & Load Functionality

Convert Dictionary<int, Movie> to JSON and save it to a file.

Load JSON data back into the dictionary when opening the application.

8. Build and Test

Run the application, test all functionalities, and fix any issues.

Installation and Usage

Clone the repository or download the project files.

Open the project in Visual Studio.

Build and run the application.

Use the WinForms UI to add, update, delete, and navigate movies.

Click "Save" to store data in a JSON file.

Click "Load" to retrieve previously saved movie records.
