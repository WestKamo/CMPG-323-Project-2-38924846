# CMPG-323-Project-2---38924846

# project Overview
NWU Tech Trends is a consulting organization specialized in software development with an emphasis on Data Integration, Generative Artificial Intelligence (GenAI), and Automation. 
This project intends to build a solution that quantifies the benefits and value gained in client environments, specifically by quantifying time and cost savings related with automations created by NWU Tech Trends.

# Components of the Solution
Web API: A RESTful API that allows automations to store telemetry data linked to projects and clients.
Web Application: A front-end application to manage (create, read, update, delete) projects and clients.
Robotic Process Automation (RPA) Testing: An RPA bot to ensure the web application functions correctly.
Reporting: Visual reports to display time and cost savings per project and client over time.

#This is the reference list
https://github.com/WestKamo/CMPG-323-Project-2-38924846/blob/master/Reference%20List.docx

# API Endpoints 
The RESTful API provides endpoints for managing projects and clients, storing telemetry data, and generating reports on time and cost savings. This section describes the available endpoints and how to use them.

🔖 GET /api/clients
        Description: Retrieve a list of all clients.
        Response: A JSON array of client objects.
🔖 GET /api/clients/
        Description: Retrieve details of a specific client by ID.
        Parameters: id - The unique identifier of the client.
        Response: A JSON object representing the client.
🔖 POST /api/clients
        Description: Create a new client.
        Request Body: A JSON object with client details (e.g., name, contact information).
        Response: A JSON object representing the newly created client.
🔖 PUT /api/clients/
        Description: Update an existing client.
        Parameters: id - The unique identifier of the client.
        Request Body: A JSON object with updated client details.
        Response: A JSON object representing the updated client.
🔖 DELETE /api/clients/
        Description: Delete a client by ID.
        Parameters: id - The unique identifier of the client.
        Response: A success message or an error message.

# Additional Aspects Implemented
Security: All endpoints are secured to prevent unauthorized access. Ensure proper authentication and authorization mechanisms are in place.
Error Handling: Error responses are standardized to help diagnose issues.
Pagination: For endpoints returning lists (e.g., projects, clients), pagination is implemented to manage large sets of data.
Rate Limiting: To prevent abuse, rate limiting is enforced on all endpoints.
