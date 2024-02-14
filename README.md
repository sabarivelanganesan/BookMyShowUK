# Emovie Ticket System

This project aims to create a comprehensive ticketing system for cinemas, enabling users to browse movies, view information about actors and producers, and purchase tickets for screenings.

## Features

- **Models:** Established models for Cinema, Actors, Producers, Movies, and Actor_Movies (Join Model) to organize and manage data efficiently.
- **Database Configuration:** Configured DbContext to handle database operations, ensuring seamless interaction between the application and the database.
- **Controllers and Views:** Implemented controllers and views for each model to enable CRUD (Create, Read, Update, Delete) operations and provide a user-friendly interface.
- **Data-driven:** Utilizing a data-driven approach to populate and manage data across all controllers, ensuring dynamic and up-to-date information.

## Setup Instructions

1. Clone the repository: `git clone https://github.com/yourusername/emovie-ticket.git`
2. Navigate to the project directory: `cd emovie-ticket`
3. Install dependencies: `npm install` or `yarn install`
4. Configure the database connection in the `appsettings.json` file.
5. Run the migrations to create the database schema: `dotnet ef database update`
6. Start the application: `dotnet run`
7. Access the application in your browser at `http://localhost:5000`

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/new-feature`
3. Make your changes and commit them: `git commit -am 'Add new feature'`
4. Push to the branch: `git push origin feature/new-feature`
5. Submit a pull request

## License

This project is licensed under the [MIT License](LICENSE).
