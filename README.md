# CMPG 323 Project 3 - [Add Your Student Number]

## Overview

In today's world, there are countless applications in use, and a developer's ability to comprehend existing code is often as crucial as their ability to write new code. This project involves enhancing and improving an existing ASP.NET Core MVC Web Application.

As part of this project, you'll delve into architectural patterns, coding principles, and design patterns to align with project requirements.

## Prerequisites

Before starting this project, ensure that you have completed the following prerequisites:

- **Azure Access**: Make sure you can access the NWU Azure tenant by logging into the Azure Portal using your MS Fed account: `12345678@student365.msfed.nwu.ac.za`.

- **Resource Group**: Create a resource group following the appropriate naming convention to logically group your work.

- **Development Environment**: Install Visual Studio 2022 Community edition and .NET Core 6 on your development machine.

- **Project Code Base**: Use the code base provided in eFundi (Projects > Project 3 Resources) as the foundation for your project.

## Requirements

### Functional Requirements

Functional requirements describe the system's functionality and how tasks should be performed. Ensure that the following functional requirements are met:

- [ ] [Add specific functional requirements]

### Non-Functional Requirements

Non-functional requirements impact the quality attributes of the system. These supportive requirements ensure that functional requirements are implemented according to best practices. Consider the following non-functional requirements:

- **Scalability**: Ensure the system can handle increased loads gracefully.

- **Security**: Implement robust authentication and authorization mechanisms to protect user data and system resources.

- **Performance**: Optimize the application for quick response times and efficient resource utilization.

- **Maintainability**: Write clean, well-documented code to ease future enhancements and maintenance.

- **Usability**: Create a user-friendly interface that is intuitive to navigate.

- **Reliability**: Guarantee that the system is robust and minimizes downtime.

## Project Tasks

### GitHub Administration

- [ ] Create and Configure GitHub Repository.
- [ ] Create a README.md file to describe your project and guide stakeholders.

### Project Progress

- [ ] Regularly commit and push project updates to source control.
- [ ] Iteratively update the GitHub project to demonstrate project progress.

### Project Setup

- [ ] Access the existing project.
- [ ] Fork the existing GitHub repository.
- [ ] Create a new development branch.

### Connect the Web App to the Data Source

- [ ] Add the connection string to the hosted database in the appsettings.json file.

### Design Pattern Implementation

#### Repository Classes

- [ ] Create a repository class for Orders data access operations.
- [ ] Create a repository class for Customers data access operations.
- [ ] Create a repository class for Products data access operations.

#### Data Access Operations Transfer

- [ ] Transfer data access operations from the Devices controller to the Orders Repository class.
- [ ] Transfer data access operations from the Zones controller to the Customers Repository class.
- [ ] Transfer data access operations from the Categories controller to the Products Repository class.

#### Repository Class Integration

- [ ] Implement the use of the Customer repository class in the Orders controller for customer-related data access.
- [ ] Implement the use of the Products repository class in the Orders controller for product-related data access.

### Project Close-out

- [ ] Ensure no credentials are stored on GitHub.
- [ ] Create an App Service (connected to an F1 tier service plan) for hosting the Web API.
- [ ] Publish the App to Azure and ensure it is secure and accessible.

### Project Documentation

- [ ] Explain how to use the App in the README.md file.
- [ ] Create a reference list document containing all visited and used resources for the project.

## Contributing

If you would like to contribute to this project, please follow the guidelines in our [CONTRIBUTING.md](CONTRIBUTING.md) file.

## License

This project is licensed under the [License Name]. For details, see the [LICENSE](LICENSE) file.



https://ecopowersolutions36564567.azurewebsites.net/
